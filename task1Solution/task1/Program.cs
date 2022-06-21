using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace task1
{
    class Program
    {

        public static int CalculateAge(string birthD)
        {
            var birthDate = birthD.Split(',');
            int age = Int32.Parse(birthDate[1]);
            int Age = 2022 - age;

            return Age;
        }

        static void Main(string[] args)
        {
            var filePath = @"C:\Users\dancho\Downloads\input.txt";

            var text = MovieStar.PrintText(filePath).ToString();
            //Console.WriteLine(text);

            List<MovieStar> account = JsonConvert.DeserializeObject<List<MovieStar>>(text);

            foreach (var star in account)
            {
                Console.WriteLine(star.Name + " " + star.Surname);
                Console.WriteLine(star.Sex);
                Console.WriteLine(star.Nationality);
                int Age = CalculateAge(star.DateOfBirth);

                Console.WriteLine($"{Age} years old");

                Console.WriteLine();
            }
            



        }
    }
}
