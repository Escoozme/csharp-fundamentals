using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod8LectureStarter {
    class CarDetails {
        /*Fields need to start with an underscore to differentiate between the backing field and the Property*/
        private string _make, _model;
        private decimal _price;

        //Default Constructor
        public CarDetails() {
            _make = "";
            _model = "";
            _price = 0m;
        }

        //Properties. To make a property readonly, don't use a setter
        public string Make {
            get { return _make; }
            set { _make = value; }
        }

        public string Model {
            get { return _model; }
            set { _model = value; }
        }

        public decimal Price {
            get { return _price; }
            set { _price = value; }
        }
    }
}
