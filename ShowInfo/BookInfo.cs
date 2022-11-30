using System;

class BookInfo{
    public void ShowBookScreen(){

    }

    private void PrintBookListScreen(){
        Console.WriteLine("List book ");
        Console.WriteLine("**********");
    }

    private void PrintListBook(){
        BookList bookList = new BookList();

        bookList.FetchBookList();
    }
}