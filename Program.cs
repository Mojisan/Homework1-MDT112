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
                    if(((int)password[2] - 48) >= 6 && ((int)password[2] - 48) != 8) {
                        if(((int)password[4] - 48) != 1 && ((int)password[4] - 48) != 3 && ((int)password[4] - 48) != 5) {
                           if(((int)password[5] - 48) % 3 == 0) {
                            Console.WriteLine("True");
                           } else {
                            Console.WriteLine("False");
                           }
                        }
                        else {
                            Console.WriteLine("False");
                        }
                    }
                    else {
                            Console.WriteLine("False");
                    }
                    break;
                    case"FBI":
                    if(((int)password[0] - 48) >= 4 && ((int)password[0] - 48) <= 7) {
                        if(((int)password[3] - 48) % 2 == 0 && ((int)password[3] - 48) != 6) {
                           if(((int)password[1] - 48) % 2 != 0) {
                            Console.WriteLine("True");
                           } else {
                            Console.WriteLine("False");
                           }
                        }
                        else {
                            Console.WriteLine("False");
                        }
                    }
                    else {
                            Console.WriteLine("False");
                    }
                    break;
                    case"NSA":
                    if(30 % ((int)password[5] - 48) == 0) {
                        if(((int)password[3] - 48) % 3 == 0 && ((int)password[3] - 48) % 2 != 0) {
                           if(((int)password[0] -48) == 7 || ((int)password[1] -48) == 7 || ((int)password[2] -48) == 7 || 
                           ((int)password[3] -48) == 7 || ((int)password[4] -48) == 7 || ((int)password[5] -48) == 7) {
                            Console.WriteLine("True");
                           } else {
                            Console.WriteLine("False");
                           }
                        }
                        else {
                            Console.WriteLine("False");
                        }
                    }
                    else {
                            Console.WriteLine("False");
                    }
                    break;
                    default:
                    Console.WriteLine("Error");
                    break;
                }
            }
            else {
                Console.WriteLine("Error");
            }

        }
    }
}