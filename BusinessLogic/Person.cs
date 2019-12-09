using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace BusinessLogic
{
    public class Person
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string GroupName { get; set; }
        public List<Phone> Phones { get; set; }

        public Person()
        {
            Phones = new List<Phone>();
        }
    }
}
