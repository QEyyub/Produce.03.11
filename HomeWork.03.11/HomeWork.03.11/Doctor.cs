using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork._03._11
{
    class Doctor:Human
    {
        public Doctor(int no, string specialty, int experience, string name, string surname, string gender) : base(name, surname, gender)
        {
            No = no;
            Specialty = specialty;
            Experience = experience;

        }
        public int No;
        public string Specialty;
        public int Experience;

        public override string ShowInfo()
        {
            return base.ShowInfo() + $"No : {No} Specialty : {Specialty} Experience : {Experience}";
        }
    }
}
