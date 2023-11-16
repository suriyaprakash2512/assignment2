using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Username = "admin";
            string password = "12345";
            Console.WriteLine("enter the Username:");
            string enterusername = Console.ReadLine();
            Console.WriteLine("enter the Password:");
            string enterpassword = Console.ReadLine();
            if (enterusername == Username && enterpassword == password)
            {
                Console.WriteLine(" correct username & password,login successfull");
            }
            else if (enterusername == Username)
            {
                Console.WriteLine("invalid password");
            }
            else
            {
                Console.WriteLine("invalid username");
            }
            Console.ReadKey();

            //int preMarks;

            //int finalMarks;

            //Console.WriteLine("Enter Pre marks");

            //preMarks = int.Parse(Console.ReadLine());

            //if (preMarks >= 60)
            //{
            //    Console.WriteLine("Enter Final Marks");
            //    finalMarks = int.Parse(Console.ReadLine());
            //    if (finalMarks >= 58)
            //    {
            //        Console.WriteLine("Selected !!!");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Clear the Pre but Fail in Final");
            //    }
            //}

            //else
            //{
            //    Console.WriteLine("Fail in Pre");

            //}
            //Console.ReadKey();
        }
        }

    }
