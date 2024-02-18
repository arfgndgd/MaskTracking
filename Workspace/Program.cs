using System;

namespace Workspace
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variables();

            Citizen citizen = new Citizen();
            citizen.Name = "Arif";

        }

        private static void Variables()
        {
            string mesaj = "Hello";
            double credit = 10000;
            int number = 100;
            bool auth = false;

            string name = "Arif";
            string surname = "Gündoğdu";
            int birthDate = 1996;
            long tcNo = 12345678912;

            Console.WriteLine(credit * 1.18);
        }

        public class Citizen
        {
            public string Name { get; set; } //pascal casing
            public string Surname { get; set; }
            public int BirthDate { get; set; }
            public long TcNo { get; set; }
        }
    }
}
