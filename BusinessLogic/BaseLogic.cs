using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessLogic
{
    public class BaseLogic : IDisposable
    {
        private PhonebookDataContext dc = new PhonebookDataContext();
        protected PhonebookDataContext DC
        {
            get
            {
                return dc;
            }
        }


        public void Dispose()
        {
            dc.Dispose();
        }
    }
}
