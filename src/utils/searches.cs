using System;
using System.Collections.Generic;
using LibrarySystem.src;

namespace LibrarySystem.utils
{
    public static class BookSearchUtilityClass
    {
        //Take in search by title, search through whole library, and return list of all the books with that same name
        //Ignores case of letters
        public static List<Book> SearchForBookByTitle(string bookTitle, ref List<Book> listOfBooks)
        {
            List<Book> booksWithSameTitle = new List<Book>();
            for (int i = 0; i < listOfBooks.Count; i++)
            {
                Book currentBook = listOfBooks[i];
                if (string.Equals(currentBook.title, bookTitle, StringComparison.OrdinalIgnoreCase))
                {
                    booksWithSameTitle.Add(currentBook);
                }
            }
            return booksWithSameTitle;
        }

        //Take in string of bookAuthor, search through whole library and return a list of all the books with the same author
        //Ignores case of letters
        public static List<Book> SearchForBookByAuthor(string bookAuthor, ref List<Book> listOfBooks)
        {
            List<Book> booksWithSameAuthor = new List<Book>();
            for (int i = 0; i < listOfBooks.Count; i++)
            {
                Book CurrentBook = listOfBooks[i];
                if (string.Equals(CurrentBook.author, bookAuthor, StringComparison.OrdinalIgnoreCase))
                {
                    booksWithSameAuthor.Add(CurrentBook);
                }
            }
            return booksWithSameAuthor;
        }

        //Search for books with same genre as user input, returns a list of all the books with that genre
        //Ignore case of letters
        public static List<Book> SearchForBookByGenre(string bookGenre, ref List<Book> listOfBooks)
        {
            List<Book> booksWithSameAuthor = new List<Book>();
            for (int i = 0; i < listOfBooks.Count; i++)
            {
                Book CurrentBook = listOfBooks[i];
                if (string.Equals(CurrentBook.genre, bookGenre, StringComparison.OrdinalIgnoreCase))
                {
                    booksWithSameAuthor.Add(CurrentBook);
                }
            }
            return booksWithSameAuthor;
        }
    }
}
