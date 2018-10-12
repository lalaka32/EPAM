using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW6
{
    class Teacher : Man
    {
        private List<Student> _students;

        public Teacher(List<Student> students)
        {
            Students = students;
        }

        internal List<Student> Students
        {
            get { return _students; }
            set
            {
                if (_students != null)
                {
                    _students = value;
                }
            }
        }

        public void PunishStudents(int value)
        {
            foreach (Student student in _students)
            {
                student.IncreaceYearOfEducation(value);
            }
        }

    }
}
