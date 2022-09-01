using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace LibraryManagment
{
    internal class student : StudentsMenu
    {

        public void BorrowOperation()                                                     //borrow menu for student
        {

            Console.WriteLine();
            Console.WriteLine("-----------------------------");
            Console.WriteLine("Enter 1 to Borrow    ");
            Console.WriteLine("Enter 2 to Exit      ");
            Console.WriteLine("------------------------------");
            Console.WriteLine();

            int val = int.Parse(Console.ReadLine());

            if (val == 1)                                                           //for borrow
            {
                LibraryManagment.BorrowOperation.BorrowBook();
            }
            else if (val == 2)                                                     //else exit
            {
                studentPortal();
            }

            else
            {
                Console.WriteLine("Invalid option ");
            }

        }

        public void ReturnOperation()                                                   //to return book
        {
            Console.WriteLine();
            Console.WriteLine("-----------------------------");
            Console.WriteLine("      Enter 1 to Return   ");
            Console.WriteLine("      Enter 2 to Exit     ");
            Console.WriteLine("------------------------------");
            Console.WriteLine();

            int value = int.Parse(Console.ReadLine());

            if (value == 1)                                                             //to return
            {
                LibraryManagment.BorrowOperation.ReturnBook();
            }
            else if (value == 2)                                                        //to exit
            {
                studentPortal();
            }
            else
            {
                Console.WriteLine("   *-  Invalid option");
            }
        }
    }
}
