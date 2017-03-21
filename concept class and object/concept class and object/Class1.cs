using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace concept_class_and_object
{
    class Class1
    {
        private string getmessage(string name)
        { return "hello" + name; }
        private string c;

        public string myproperty
        {
            get { return c; }
            set { c = value; }
        }

    }
}
