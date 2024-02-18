using System;

namespace Workspace
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variables();

            Person person = new Person();
            person.Name = "Arif";

            SayHello(name: "Arif");
            SayHello();

            int result = Addition(3);//parametre verirsek bunu vermezsek metodtaki parametreyi alır
        }

        static void SayHello(string name="noname") //void metodlar herhangi bir şey döndürmez, bilgi vermez sadece işi yapar.
        {
            Console.WriteLine("Hello " + name);
        }

        static int Addition(int number1=5, int number2=2) //bir sonuç döndürmek istersek void yerine tip yazarız
        {
            int sonuc = number1 + number2;
            Console.WriteLine("Toplam " + sonuc.ToString());
            return sonuc;
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

        public class Person
        {
            public string Name { get; set; } //pascal casing
            public string Surname { get; set; }
            public int BirthDate { get; set; }
            public long TcNo { get; set; }
        }
    }
}
