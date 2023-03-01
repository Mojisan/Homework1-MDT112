using System;
namespace Homework1 {
    class Program {
        static void Main(string[] args) {
            string agency, password;
            Console.Write("Password : ");
            password = Console.ReadLine();
            Console.Write("Agency : ");
            agency = Console.ReadLine();

            Console.WriteLine(password);
            Console.WriteLine(agency);
        }
    }
}