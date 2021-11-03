using System;

namespace HomeWork._03._11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hekimlerin sayini elave edin");
            string countStr = Console.ReadLine();
            int count = Convert.ToInt32(countStr);

            Doctor[] NewDoc = new Doctor[count];
            if (count > 0)
            {

                for (int i = 0; i < count; i++)
                {
                    Console.WriteLine($"{i + 1}. Hekimin Infolarini daxil edin : ");

                    string name = GetInputStr("Name", 3, 30);
                    string surname = GetInputStr("Surname", 5, 30);
                    string gender = GetGender("Gender");
                    int no = GetInputNum("No", 1, 100);
                    string specialty = GetInputStr("Specialty", 3, 30);
                    int experience = GetInputNum("Experience", 0, 50);


                    Doctor doctor = new Doctor(no, specialty, experience, name, surname, gender);
                    Array.Resize(ref NewDoc, NewDoc.Length + 1);
                    NewDoc[NewDoc.Length - 1] = doctor;
                }
                foreach (var dc in NewDoc)
                {
                    Console.WriteLine($"Butun Infolar :{dc.ShowInfo()}");
                }
            }
            
        }

        static bool HasDigit(string text)
        {
            char[] chr = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            foreach (var ch in chr)
            {
                foreach (var txt in text)
                {
                    if (ch == txt) return true;
                }
                
            }
            return false;
        }

        static string GetInputStr(string Name, int min, int max)
        {
            string input;
            do
            {
                Console.WriteLine($"{Name} deyerini daxil edin ");
                input = Console.ReadLine();

            } while (input.Length < min || input.Length > max );

            return input;


        }

        static string GetGender(string gen, bool checkGender = true)
        {
            string inputGender;
            //bool checkGender = ;
            do
            {

                if (!checkGender)
                {
                    Console.WriteLine("Zehmet olmasa Kishi ve ya Qadin daxil edin");

                }
                Console.WriteLine("Cinsi daxil edin");

                inputGender = Console.ReadLine();

                checkGender = false;

            } while (inputGender != "Kishi" && inputGender != "Qadin");
            return inputGender;


        }

        static int GetInputNum(string Name, int min = int.MinValue, int max = int.MaxValue)
        {
            string inputstr;
            int input;

            do
            {
                Console.WriteLine($"{Name} deyerini daxil edin ");
                inputstr = Console.ReadLine();
                input = Convert.ToInt32(inputstr);

            } while (input< min || input> max );

            return input;
        }
    }
}
