using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW6
{
    class Student : Man
    {
        private int _yearOfEducation;

        public int YearOfEducation
        {
            get { return _yearOfEducation; }
            set { _yearOfEducation = value; }
        }
        public void IncreaceYearOfEducation(int value)
        {
            if (value>0)
            {
                _yearOfEducation += value;
            }
        }
    }
}
