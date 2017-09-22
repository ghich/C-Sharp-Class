using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KALDOR_CSC3220_LAB8
{
    public class Student
    {
        //Backing Fields
        private string _firstName;
        private string _lastName;
        private string _email;
        private Dorm _dorm;
        private MealPlan _mealPlan;
        private int _totalCost;

        //Constructors
        public Student()
        {
            _firstName = "";
            _lastName = "";
            _email = "@spu.edu";
        }

        public Student (string firstName, string lastName, string email)
        {
            _firstName = firstName;
            _lastName = lastName;
            _email = email;
        }

        //Properties
        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }

        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }

        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

        public Dorm Dorm
        {
            get { return _dorm; }
            set { _dorm = value; }
        }

        public MealPlan MealPlan
        {
            get { return _mealPlan; }
            set { _mealPlan = value; }
        }

        //Methods
        public string FullName
        {
            get { return _firstName + " " + _lastName; }
        }

        public int TotalCharge
        {
            get { return this._mealPlan.Cost + this._dorm.Cost; }
        }
    }
}
