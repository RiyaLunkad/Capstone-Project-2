using System;
using System.Collections.Generic;
using System.Text;


namespace LibraryManagment
{
    internal class StudentsMenu
    {
        public void studentPortal()                                                         //student menu

        {

            Console.WriteLine();
            Console.WriteLine("---------------WELCOME TO THE STUDENT PORTAL------------");
            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine("Enter 1 to BorrowBook                  ");
            Console.WriteLine("Enter 2 to Get Date & Time of Borrowing");
            Console.WriteLine("Enter 3 to ReturnBook                  ");
            Console.WriteLine("Enter 4 to Get Date & Time of Borrowing");
            Console.WriteLine("Enter 5 to View Available Books        ");
            Console.WriteLine("Enter 6 to End The Session             ");
            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine();
            int x = Convert.ToInt32(Console.ReadLine());

            Addingbook t = new Addingbook();

            student obj = new student();

            if (x == 1)                                                     //for borrow
            {
                obj.BorrowOperation();
                studentPortal();
            }
            else if(x==2)                                                    //for time & date of borrow
            {
                DateTime now=DateTime.Now;
                Console.WriteLine("Time & Date is:{0}",now);          
            }
            else if (x == 3)                                                  //for return
            {
                obj.ReturnOperation();
                studentPortal();
            }
            else if (x == 4)                                                     //for time & date of borrow
            {
                DateTime now = DateTime.Now;
                Console.WriteLine("Time & Date is:{0}", now); 

            }
            else if (x == 5)                                                      //to view all available book
            {
                foreach (Book b in t)
                {
                    Console.WriteLine($"   *-  Book ID-{b.ID}  Book Name-{b.Name}");
                }
                studentPortal();

            }
            else if (x == 6)                                                         //exit
            {

            }


        }

    }
}
