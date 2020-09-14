using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JacobSmetana8C {
    class PersonEntry {
        //fields
        private string _name, _email, _phoneNumber;

        //Default Constructor
        public PersonEntry() {
            _name = "";
            _email = "";
            _phoneNumber = "";
        } 

        //Properties--------------------------------------------------
        public string Name {
            get { return _name; }
            set { _name = value; }
        }

        public string Email {
            get { return _email; }
            set { _email = value; }
        }

        public string Phone {
            get { return _phoneNumber; }
            set { _phoneNumber = value; }
        }
    }
}
