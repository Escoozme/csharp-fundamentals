using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod8LectureStarter {
    class Coin {
        //field to represent the side facing up
        private string _sideUp;
        Random rand = new Random();

        //Constructor = default values of the class variables
        public Coin() {
            _sideUp = "Heads";
        }

        public void Toss() {
            //Use a random number to determine the side of the coin that's facing up
            //0 = Heads, 1 = Tails
            if(rand.Next(2) == 0)
                _sideUp = "Heads";
            else
                _sideUp = "Tails";
        }

        public string GetSideUp() {
            //The GetSideUp method returns the value of the _sideUp field
            return _sideUp;
        }
    }
}
