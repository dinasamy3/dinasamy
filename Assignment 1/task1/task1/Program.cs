// See https://aka.ms/new-console-template for more information
//using static System.Runtime.InteropServices.JavaScript.JSType;
//Console.WriteLine("Hello, World!");



using System;
    class program
    {
        static void main (string[] args) {

            Console.WriteLine("enter a number : ");
            int num =int.Parse(Console.ReadLine());
            if (num%3==0 && num%4==0) {

                Console.WriteLine("Yes");
            }
               
       
            else
            {
                Console.WriteLine("No");
            }
        }
    }
