using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork._03._11
{
    class Human
    {
        public Human(string name , string surname , string gender)
        {
            Name = name;
            Surname = surname;
            Gender = gender;
        }
        public string Name;
        public string Surname;
        public string Gender;

        public virtual string ShowInfo()
        {
            return $"Name : {Name} Surname : {Surname} Gender : {Gender} "; 
        }
    }
}
