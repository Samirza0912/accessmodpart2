using System;
namespace hwaccessmodpart2.Models
{
    public class Student : Person
    {
        private int _point;

        public int point
        {
            get { return _point; }
            set
            {
                if (value < 0 || value > 100)
                {
                    Console.WriteLine("Point should be between 0 and 100");
                    return;
                }
                value = _point;
            }
        }
        public Student()
        {

        }
    }
}
