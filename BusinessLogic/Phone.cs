using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessLogic
{
    public class Phone
    {
        public int? PhoneID { get; set; }
        public string Number { get; set; }
        public int TypeID { get; set; }
        public string TypeName { get; set; }


        public Phone(int? phoneID, int typeID, string number)
        {
            PhoneID = phoneID;
            Number = number;
            TypeID = typeID;
        }

        public Phone(int? phoneID, string typeName, string number)
        {
            PhoneID = phoneID;
            Number = number;
            TypeName = typeName;               
        }
    }
}
