using MiniLibrary.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Media;

namespace MiniLibrary
{
    class Controller
    {
        private Models.Book book;
        private View view;
        private int choice;
        
        public void ShowBooksController()
        {
            //Muzyka działa tylko na Windows - przykro mi :(
            SoundPlayer player = new SoundPlayer("inossi-sunset-eyes.wav");
            player.Load();
            player.PlayLooping();
            view = new View();
            book = new Models.Book();

            while (true)
            {
               choice =  view.Chosen();
                switch (choice)
                {
                    case 0:
                        view.ShowList(book.BookList());
                        break;
                    case 1:
                        view.GetTitle();
                        view.GetAuthor();
                        view.GetGenre();
                        book.AddBook(view.Tytul, view.Autor, view.Gatunek);
                        break;
                    case 2:
                        view.GetTitle();
                        book.DeleteBook(book.FindByTitle(view.Tytul));
                        break;
                    case 3:
                        view.GetTitle();
                        view.ShowList(book.FindByTitle(view.Tytul));
                        break;
                    case 4:
                        string genre = view.ChooseGenre();
                        view.ShowList(book.FindByGenre(genre));
                        break;
                    case 5:
                        view.GetAuthor();
                        view.ShowList(book.FindByAuthor(view.Autor));
                        break;
                    case 6:
                        Environment.Exit(0);
                        break;
                }
                Console.ReadKey();
            }
            

            
        }

    }
}
