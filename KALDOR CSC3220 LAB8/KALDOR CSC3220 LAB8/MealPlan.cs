using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KALDOR_CSC3220_LAB8
{
    public class MealPlan
    {
        //Backing fields
        private string _planName;
        private int _cost;

        //Constructors
        public MealPlan()
        {
            _planName = "";
            _cost = 0;
        }

        public MealPlan (string planName, int cost)
        {
            _planName = planName;
            _cost = cost;
        }
        
        //Properties
        public string PlanName
        {
            get { return _planName; }
            set { _planName = value; }
        }
        public int Cost
        {
            get { return _cost; }
            set { _cost = value; }
        }

        //Methods
    }
}
