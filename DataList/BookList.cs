using System.Collections.Generic;
using System;

class BookList {
    private List<Book> books;

    public BookList() {
        this.books = new List<Book>() {
            new Book(1,"One Pice"),
            new Book(2,"Calculus"),
        };
    }

    public void FetchBookList() {
        Console.Clear();
        Console.WriteLine("Book List");
        Console.WriteLine("---------");

        foreach (Book book in this.books) {
            Console.WriteLine("Book ID: {0}", book.GetSerialNumber());
            Console.WriteLine("Book name: {0}", book.GetBookName());
        }
    }

    public Book GetBook(string bookID) {
        foreach (Book book in this.books) {
            if (int.Parse(bookID) == book.GetSerialNumber()) {
                return book;
            }
        }

        return new Book(0, "Not has book");
    }

}