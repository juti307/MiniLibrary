using MiniLibrary.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace MiniLibrary
{
    class View
    {
        private string tytul;
        private string autor;
        private string gatunek;
        private DateTime data;
        public int selectedClass;

        public View()
        {
            Menu.Hello2();
            
          

        }

        public int Chosen ()
        {
            selectedClass = Menu.MultipleChoice(true,
        "~~ View the book list",
        "~~ Add new position",
        "~~ Delete a book",
        "~~ Find a book by Title",
        "~~ Display all books from the category",
        "~~ Display all books of the author",
        "~~ Exit the Bookland");

            return selectedClass;

        }

        public string Tytul
        {
            get { return tytul; }
            set { tytul = value; }
        }

        public string Gatunek
        {
            get { return gatunek; }
            set { gatunek = value; }
        }

        public string Autor
        {
            get { return autor; }
            set { autor = value; }
        }

        public string ChooseGenre()
        {
            
            selectedClass = Menu.UNChoice(true,
     "~~  Adventure",
     "~~  Romance",
     "~~  Action",
     "~~  Fantasy",
     "~~  Poetry ",
     "~~  Horror",
     "~~  Other");

            switch(selectedClass)
            {
                case 0: return "Adventure"; break;
                case 1: return "Romance"; break;
                case 2: return "Action"; break;
                case 3: return "Fantasy"; break;
                case 4: return "Poetry"; break;
                case 5: return "Horror"; break;
                case 6:  this.GetGenre(); return this.Gatunek;
                    break;
                default: return "lack";
            }
        }

        public void ShowList (List<Book> books)
        {
            int i = 1;
            Console.WriteLine();
            foreach (Book b in books)
            {
                Console.Write(i + ". "); //  + b.Name + ", written by " + b.Author + ", in the genre of " + b.Genre + ", added on ");
                Console.ForegroundColor = ConsoleColor.Cyan; Console.Write(b.Name); Console.ResetColor();
                Console.Write(", written by "); Console.ForegroundColor = ConsoleColor.DarkCyan; Console.Write(b.Author); Console.ResetColor();
                Console.Write(", in the genre of "); Console.ForegroundColor = ConsoleColor.Blue; Console.Write(b.Genre); Console.ResetColor();
                Console.Write(", added on "); Console.ForegroundColor = ConsoleColor.DarkBlue; Console.Write(b.Date.ToString("d") + "\n"); Console.ResetColor();
                i++;
            }
            
        }

        

        public void GetAuthor()
        {
            Console.WriteLine("Type the author: ");
            autor = Console.ReadLine();
           
        }
        public void GetTitle()
        {
            Console.WriteLine("Type the title: ");
            tytul = Console.ReadLine();
        
        }
        public void GetGenre()
        {
            Console.WriteLine("Type the genre: ");
            gatunek = Console.ReadLine();
        }



    }
}
