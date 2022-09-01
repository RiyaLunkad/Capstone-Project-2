using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace LibraryManagment
{
    internal class AddingMagazines : IEnumerable
    {

        public static List<Paper> Magazines = new List<Paper>                             //list of magazines
        {
            new Paper{Title="Grazia" },
            new Paper{Title="Bazar"  },
            new Paper{Title="Vogue" },
            new Paper{Title="Cosmopoliton"}

            
        };
        public void add(Paper newpaper)                                         //add paper
        {
            if (Magazines == null)
            {
                Magazines = new List<Paper>();

            }
            Magazines.Add(newpaper);
        }

        public IEnumerator GetEnumerator()                                    //view all the paper
        {
            if (Magazines!= null)
            {
                return Magazines.GetEnumerator();
            }
            else
            {
                return null;
            }
        }
    }
    public class Paper
    {
        public string Title { get; set; }                                       //property for title of paper
    }
}
