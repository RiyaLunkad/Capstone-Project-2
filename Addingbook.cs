using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace LibraryManagment
{
    internal class Addingbook : IEnumerable
    {
        public static List<Book> books = new List<Book>                                 //adding books of count 10
        {
            new Book{Name="Game of Thrones"},
            new Book{Name="A Million Thoughts"},
            new Book{Name="Lord of the Rings"},
            new Book{Name="The Pursuit Of Happiness" },
            new Book{Name="On The Open Road" },
            new Book{Name="Reflections" },
            new Book{Name="India's Greatest Short Stories" },
            new Book{Name="The Alchemist" },
            new Book{Name="Becoming Better Grownups" },
            new Book{Name="A Thousand Splendid Suns"}
        };

        public void ADD(Book NewBook)                                               //add 
        {
            if (books == null)
            {
                books = new List<Book>();

            }
            books.Add(NewBook);
        }

        public void Rem(int i)                                                  //remove
        {
            if (books != null)
            {
                books.RemoveAll(r => r.ID == i);

            }

        }


        public IEnumerator GetEnumerator()                               //display all
        {
            if (books != null)
            {
                return books.GetEnumerator();
            }
            else
            {
                return null;
            }

        }

    }



    public class Book
    {
        public Boolean Borrowed
        { get; set; }

        private static int bookIDCounter;                                                   //for auto incremented id

        static Book()
        {
            Book.bookIDCounter =99;                                                         //id count will start from 100
        }
        public Book()
        {
            this._BookID=++Book.bookIDCounter;
        }
        private int _BookID;
        public int ID
        {
            get
            {
                return _BookID;
            }
        }
            

        public string Name { get;set; }                                             //property for name

    }
}
