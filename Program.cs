using System;
namespace Homework1 {
    class Program {
        static void Main(string[] args) {
            string agency, password;
            Console.Write("Password : ");
            password = Console.ReadLine();

            if(password.Length <= 6) {
                Console.Write("Agency : ");
                agency = Console.ReadLine();
                switch(agency) {
                case"CIA":
                Console.WriteLine("Hello CIA");
                if(((int)password[2] - 48) >= 6 && ((int)password[2] - 48) != 8) {
                    if(((int)password[4] - 48) != 1 && ((int)password[4] - 48) != 3 && ((int)password[4] - 48) != 5) {
                        if(((int)password[5] - 48) % 3 == 0) {
                            Console.WriteLine("True");
                        } else {
                            Console.WriteLine("False");
                        }
                    } else {
                            Console.WriteLine("False");
                    }
                } else {
                    Console.WriteLine("False");
                }
                break;
                case"FBI":
                Console.WriteLine("Hello FBI");
                break;
                case"NSA":
                Console.WriteLine("Hello NSA");
                break;
                default:
                Console.WriteLine("Error");
                break;
            }
            } else {
                Console.WriteLine("Error");
            }
        }
    }
}