using System;
using System.Globalization;

namespace hwaccessmodpart2.Models
{
    public class Person
    {
        private string _name;
        private string _surname;
        private int _age;

        public string name
        {
            get
            {
                return _name;
            }
            set
            {
                var textInfo = new CultureInfo("en-US").TextInfo;
                var capitalizedText = textInfo.ToTitleCase(textInfo.ToLower(value));
                Console.WriteLine(capitalizedText);
                if (value.Length<3 && value.Length>30)
                {
                    Console.WriteLine("Name cannot be less than 3 or more than 30");
                    return;
                }
                value = _name;
            }
        }
        public string surname
        {
            get
            {
                return _surname;
            }
            set
            {
                var textInfo = new CultureInfo("en-US").TextInfo;
                var capitalizedText = textInfo.ToTitleCase(textInfo.ToLower(value));
                Console.WriteLine(capitalizedText);
                if (value.Length < 3 && value.Length > 35)
                {
                    Console.WriteLine("Surname cannot be less than 3 or more than 35");
                    return;
                }
                value = _surname;
            }
        }
        public int age { get { return _age; }
            set
            {
                if (value<=0)
                {
                    Console.WriteLine("Age cannot be 0 or negative");
                    return;
                }
                value = _age;
            }
            
        }

    }
}
