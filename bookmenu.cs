using System;
using System.Collections.Generic;
using System.Text;


namespace LibraryManagment
{
    
    internal class Books : MagazinesMenu
    {
        public void Booksportal()                                                                       //menu for librarian
        {
            Console.WriteLine();
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("1 for Adding the books                  ");
            Console.WriteLine("2 for Removing the book                 ");
            Console.WriteLine("3 for Viewing all the available books   ");
            Console.WriteLine("4 for Back                              ");
            Console.WriteLine("---------------------------------------------");

            Addingbook t = new Addingbook();

            string input = Console.ReadLine();
            int z = int.Parse(input);

            if (z == 1)                                                                     //if statement for adding
            {
                Console.Write(" >>>>>>  How Many Books You Want to Add Now: ");
                int quantity = Convert.ToInt32(Console.ReadLine());

                for (int i = 0; i < quantity; i++)
                {
                    
                    Console.Write("   *-  Please Enter Book Name: ");
                    string b = Console.ReadLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    

                    t.ADD(new Book {  Name = b });                                          //adding new book
                }


                foreach (Book x in t)
                {
                    Console.WriteLine($"   *- Book ID-{x.ID}   Book Name-{x.Name}");
                }
                Console.WriteLine();

                Booksportal();

            }
            else if (z == 2)                                                                    //statement for removing the book
            {
                Console.Write("   *-  Type Book code to Remove: ");
                int i = Convert.ToInt32(Console.ReadLine());
                t.Rem(i);

                foreach (Book x in t)
                {
                    Console.WriteLine($"   *-  Book ID-{x.ID}  Book Name-{x.Name}");
                }
                Console.WriteLine();
                Booksportal();
            }
           

            else if (z == 3)                                                        //statement for displaying all the books
            {
                foreach (Book x in t)
                {
                    Console.WriteLine($"   *-  Book ID-{x.ID}  Book Name-{x.Name}");
                }
                Console.WriteLine();
                Booksportal();
            }

            else                                                                     //else go to librarian menu
            
            {
                Console.WriteLine("------------------------------------");
                Console.WriteLine("Enter  1 for Books               ");
                Console.WriteLine("Enter  2 for Newspaper           ");
                Console.WriteLine("Enter  3 to Exit     ");
                Console.WriteLine("----------------------------------");
                int y = Convert.ToInt32(Console.ReadLine());
                if (y == 1)
                {
                    Booksportal();
                }
                else if (y == 2)
                {
                    news();
                }
                else if (y == 3)
                {

                }
                else
                {
                    Console.WriteLine("   *-  Invalid Input");

                }
            }
        }

    }
}
