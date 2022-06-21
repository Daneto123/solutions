using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;

namespace task1
{
    class MovieStar
    {
        private string dateOfBirth;
        private string name;
        private string surname;
        private string sex;
        private string nationality;


        public string DateOfBirth
        {
            get { return dateOfBirth; }
            set { dateOfBirth = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Surname
        {
            get { return surname; }
            set { surname = value; }
        }

        public string Sex
        {
            get { return sex; }
            set { sex = value; }
        }

        public string Nationality
        {
            get { return nationality; }
            set { nationality = value; }
        }

        public static object PrintText(string pathFile)
        {
            var serializer = new JsonSerializer();
            var stream = new StreamReader(pathFile);
            var reader = new JsonTextReader(stream);

            return serializer.Deserialize(reader);
        }

    }
}
