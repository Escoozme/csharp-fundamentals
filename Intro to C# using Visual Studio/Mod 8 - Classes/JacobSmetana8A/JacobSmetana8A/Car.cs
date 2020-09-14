using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JacobSmetana8A {
    class Car {
        //fields
        private string _year, _make;
        private int _speed;

        //Constructor
        public Car() {
            _year = "";
            _make = "";
            _speed = 0;
        }

        //Accelerate and Brake methods
        public void Accelerate() {
            _speed += 5;
        }

        public void Brake() {
            _speed -= 5;
        }

        //Properties for Year, Make, and Speed
        public string Year {
            get { return _year; }
            set { _year = value; }
        }

        public string Make {
            get { return _make; }
            set { _make = value; }
        }

        public int Speed {
            get { return _speed; }
            set { _speed = value; }
        }
    }
}
