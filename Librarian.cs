using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryManagment
{
    internal class Librarian
    {
        public void LibrarianPortal()                                                           //menu for librarian
        {
            Console.WriteLine();
            Console.WriteLine("--------------WELCOME TO THE LIBRARIAN PORTAL-----------");
            Console.WriteLine();

            Console.WriteLine("----------------------------------");
            Console.WriteLine("Enter  1 for Books              ");
            Console.WriteLine("Enter  2 for Magazine          ");
            Console.WriteLine("Enter  3 to Exit    ");
            Console.WriteLine("-----------------------------------");

            Librarian l = new Librarian();

            string LibrarianChoice = Console.ReadLine();
            int y = int.Parse(LibrarianChoice);

            Books b = new Books();
            MagazinesMenu p = new MagazinesMenu();

            if (y == 1)
            {
                b.Booksportal();
            }
            else if (y == 2)
            {
                p.news();

            }

        }
    }
}
