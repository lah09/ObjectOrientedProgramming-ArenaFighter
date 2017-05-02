using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arena_Fighter

{

    class Round
    {
        public int hScore, vScore;
        public int d1;
        public int Die1  //can use here "public int D1 { get; set; }
        {
            get { return d1; }
            set { d1 = value; }
        }

        public int d2;   //can use here "public int D2 { get; set; }
        public int Die
        {
            get { return d2; }
            set { d2 = value; }
        }
    }
}