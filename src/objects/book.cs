using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem
{
    //Struct for each book added, each book has a title, author, genre,
    //short description, ISBN number, overall rating, cost in USD, and a total number of pages
    public struct Book
    {

        public string title;
        public string author;
        public string genre;
        public string description;

        public string isbn;
        public string rating;
        public decimal cost;
        public uint   numberOfPages;

        public Book(string TITLE, string AUTHOR, string GENRE, string DESCRIPTION, string ISBN_NUMBER, string RATING, decimal COST, uint NUMBER_OF_PAGES)
        {
            this.title =         TITLE;
            this.author =        AUTHOR;
            this.genre =         GENRE;
            this.description =   DESCRIPTION;
            this.isbn =          ISBN_NUMBER;
            this.rating =        RATING;
            this.cost =          COST;
            this.numberOfPages = NUMBER_OF_PAGES;
        }

    }
}
