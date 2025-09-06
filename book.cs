using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem
{
    //Struct for each book added, each book has a title, author, genre,
    //short description, ISBN number, overall rating, cost in USD, and a total number of pages
    struct Book
    {
        string title;
        string author;
        string genre;
        string description;

        string ISBN;
        string rating;
        double cost;
        int numberOfPages;

        Book(string TITLE, string AUTHOR, string GENRE, string DESCRIPTION, string ISBN_NUMBER, string RATING, double COST, int NUMBER_OF_PAGES)
        {
            title =         TITLE;
            author =        AUTHOR;
            genre =         GENRE;
            description =   DESCRIPTION;
            ISBN =          ISBN_NUMBER;
            rating =        RATING;
            cost =          COST;
            numberOfPages = NUMBER_OF_PAGES;

        }
    }
}
