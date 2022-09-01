using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryManagment
{
    internal class BorrowOperation : StudentsMenu
    {
        public static void BorrowBook()                                                    //for borrow book
        {
            Addingbook t = new Addingbook();
            Console.Write("   *-  Enter Book Code: ");
            int borrow = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            foreach (Book b in t)
            {
                if (b.ID.Equals(borrow))                                                
                {
                    if (b.Borrowed == true)
                    {
                        Console.WriteLine("------------Book is already taken-------------");     

                        Console.WriteLine();
                    }
                    else
                    {
                        Console.WriteLine(b.ID + ":" + b.Name);
                        Console.WriteLine("------------Book Successfully Issued------------");

                        b.Borrowed = true;
                        Console.WriteLine();

                    }
                }


            }

        }
        public static void ReturnBook()
        {
            Addingbook t = new Addingbook();
            Console.Write("   *-  Enter Book Code To Return:  ");
            int returning = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            foreach (Book b in t)
            {
                if (b.ID.Equals(returning))
                {
                    if (b.Borrowed == true)
                    {
                        b.Borrowed = false;

                        Console.WriteLine($"----Book ID-{b.ID} BookName-{b.Name}------- succesfully returned---------------");
                        Console.WriteLine();

                    }
                    else
                    {
                        Console.WriteLine("--------------You Have not Borrowed this book-----------");
                        Console.WriteLine();

                    }
                }


            }
        }


    }
}
