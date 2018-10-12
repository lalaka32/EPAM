using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW6
{
    class Man
    {
        private const int MIN_WEIGHT = 0;
        private const int MAX_WEIGHT = 300;
        private const int MIN_AGE = 0;
        private const int MAX_AGE = 150;

        private string _name;
        private int _age;
        private int _weight;

        public Man(string name = "NoName", int age = 20, int weight = 60, Sex sex = Sex.Man)
        {
            _name = name;
            _age = age;
            _weight = weight;
            Sex = sex;
        }

        public Sex Sex { get; set; }

        public int Weight
        {
            get { return _weight; }
            set
            {
                if (value > MIN_WEIGHT && value < MAX_WEIGHT)
                {
                    _weight = value;
                }
            }
        }

        public int Age
        {
            get { return _age; }
            set
            {
                if (value > MIN_AGE && value < MAX_AGE)
                {
                    _age = value;
                }
            }
        }

        public string Name
        {
            get { return _name; }
            set
            {
                if (!String.IsNullOrEmpty(value))
                {
                    _name = value;
                }
            }
        }

    }
}
