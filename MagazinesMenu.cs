using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace LibraryManagment
{

    internal class MagazinesMenu : Librarian                                                    //menu for magazine option
    {


        public void news()
        {
            Console.WriteLine();
            Console.WriteLine("1 Viewing all the available magazines");
            Console.WriteLine("2 Add New Magazines ");
            Console.WriteLine("3 Back");
            Console.WriteLine();

            int x = Convert.ToInt32(Console.ReadLine());

            AddingMagazines n = new AddingMagazines();

            if (x == 1)                                                                 //for viewing all the availabe magazines
            {

                
                foreach (Paper y in n)
                {
                    Console.WriteLine($"Title- {y.Title}");
                }
                Console.WriteLine();
                news();
            }
            else if (x == 2)                                                        //add new magazine
            {
                Console.WriteLine("Please Enter Magazines Title ");
                string b = Console.ReadLine();
                Console.WriteLine();
                Console.WriteLine();

                n.add(new Paper { Title = b });

                foreach (Paper y in n)
                {
                    Console.WriteLine($"Title- {y.Title}");
                }
                Console.WriteLine();
                news();

            }

            else if (x == 3)                                                    //else go to librarian menu
            {
                LibrarianPortal();
            }
        }
    }
}
