using Business.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;

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

            //Arrays
            string student1 = "ffadsf";
            string student2 = "fadsfasf";
            string student3 = "fasdfassss";

            string[] students = new string[3];
            students[0] = "dsfdsa";
            students[1] = "fss";
            students[2] = "ss";

            students = new string[4];        //Stack       //Heap
            students[3] = "fasdfafafaffa";   //students    //[0,1,2] iken yeniden new yaptığımız için [ , , ,3] olup diğerlerini boş bırakır
                                             //Garbage Collector --> bu aşamada [0,1,2] arayini bellekten atıyor
            for (int i = 0; i < students.Length; i++)
            {
                Console.WriteLine(students[i]);
            }


            string[] cities1 = new[] {"İstanbul", "Kocaeli", "İzmir"};
            string[] cities2 = new[] {"Adana", "Konya", "Samsun" };

            cities2 = cities1;
            cities1[0] = "Uşak";
            Console.WriteLine(cities2[0] + cities2[1]);

            int number1 = 10;
            int number2 = 4;
            number2 = number1;
            number1 = 14;

            Person person1 = new Person();
            person1.Name = "Arif";

            Person person2 = new Person();
            person2.Name = "Filiz";

            foreach (string city in cities1)
            {
                Console.WriteLine(city);
            }


            List<string> newCities = new List<string> { "İstanbul", "Sinop", "Hatay" };
            newCities.Add("Adana");
            foreach (var city in newCities)
            {
                Console.WriteLine(city);
            }


            // Maske Kontrol
            Citizen citizen = new Citizen();
            citizen.FirstName = "ARİF";
            citizen.LastName = "GÜNDOĞDU";
            citizen.DateOfBirthYear = 1996;
            citizen.NationalIdentity = 23;

            PttManager pttManager = new PttManager(new CitizenManager());
            pttManager.GiveMask(citizen);
            
            Console.ReadLine();
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
