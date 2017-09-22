using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KALDOR_CSC3220_LAB8
{
    public class Dorm
    {
        //Backing fields
        private string _dormName;
        private int _cost;

        //Constructors
        public Dorm()
        {
            _dormName = "";
            _cost = 0;
        }

        public Dorm(string dormName, int cost)
        {
            _dormName = dormName;
            _cost = cost;
        }

        //Property declarations and accessors
        public string DormName
        {
            get { return _dormName; }
            set { _dormName = value; }
        }

        public int Cost
        {
            get { return _cost; }
            set { _cost = value; }
        }

    }
}
