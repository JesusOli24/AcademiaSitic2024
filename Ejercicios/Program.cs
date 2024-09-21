using System;

namespace Ejercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            string courseName = "Academia SITIC";
            String courseName2= "Academia SITIC 2";

            int StudentCount = 28;
            bool isStartingNow = true;

            int? age = null;
            //1
            Console.WriteLine(age != null ? age : 0);
            //2
            Console.WriteLine(age.GetValueOrDefault(0)); 
            //3
            if(age != null)
            {
                Console.WriteLine(age);
            }
            else
            {
                Console.WriteLine(0);
            }
            Console.ReadKey();
            User User = new();
            Employer emp = new();
            emp.PersonId;
        }
        public class User
        {
            
            //forma corta
            public int IdUser { get; set; }

            //Forma Media
            private string _password;
            public string Password
            {
                get
                {
                    return _password;
                }
                set
                {
                    _password = value;
                }
            }
            //Forma Larga
            public string GetName()
            {
                return _name;
            }
            public void SetName(string name)
            {
                _name = name;

            }
            private string _name;
        }

        public class Person
        {
            public int PersonId { get; set; }
            public string Name { get; set; }
        }
        public class Employer : Person
        {
            public DateTime StartDate { get; set; }
        }
    }
}
