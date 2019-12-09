using System.Collections.Generic;
using System.Linq;
using System.Collections;

namespace BusinessLogic
{
    public class PhonebookLogic : BaseLogic
    {
        /// <summary>
        /// Display all contact in the data grid
        /// </summary>
        public List<Person> GetAllContacts()
        {
            List<Person> personList = new List<Person>();

            // Get all Persons
            foreach (var item in DC.spContactsDisplay().OrderBy(o => o.ID))
            {
                Person person = new Person();
                try
                {
                    person.FirstName = item.FirstName;
                    person.LastName = item.LastName;
                    person.ID = item.ID;
                    person.GroupName = item.GroupName;
                    person.Phones.Add(new Phone((int)item.PhoneID, item.PhoneTypeName, item.PhoneNumber));
                    personList.Add(person);
                }
                catch { };
            }

            // Merge Similar Persons by Contact ID
            for (int i = 0; i < personList.Count - 1; )
            {
                if (personList[i].ID == personList[i + 1].ID)
                {
                    personList[i].Phones.AddRange(personList[i + 1].Phones);
                    personList.Remove(personList[i + 1]);
                }
                else
                {
                    i++;
                }
            }

            return personList;
        }


        /// <summary>
        /// Add new contact to phonebook
        /// </summary>
        public void AddContact(string firstName, string lastName, int groupID, List<Phone> phones)
        {
            int personID = DC.spInsertUpdateContact(firstName, lastName, groupID, null);

            foreach (var phone in phones)
            {
                DC.spLinkPhone(personID, phone.Number, phone.TypeID, null);
            }
        }

        /// <summary>
        /// Update contact details
        /// </summary>
        public void UpdateContact(string firstName, string lastName, int groupID, List<Phone> phones, int personID)
        {
            personID = DC.spInsertUpdateContact(firstName, lastName, groupID, personID);

            foreach (var phone in phones)
            {
                DC.spLinkPhone(personID, phone.Number, phone.TypeID, phone.PhoneID);
            }
        }

        /// <summary>
        /// Delete a person from phonebook by ID
        /// (Also delete person's phone numbers)
        /// </summary>
        public void DeletePerson(int personID)
        {
            DC.spDeletePerson(personID);
        }

        /// <summary>
        /// Delete a phone number by PhoneID
        /// </summary>
        public void DeletePhone(int phoneID)
        {
            DC.spDeletePhone(phoneID);
        }

        /// <summary>
        /// Display group name
        /// </summary>
        public IEnumerable GroupsDisplay()
        {
            return DC.spGroupsDisplay();
        }

        /// <summary>
        /// Display phone type name
        /// </summary>
        public IEnumerable PhoneTypeDisplay()
        {
            return DC.spPhoneTypesDisplay();
        }
    }
}
