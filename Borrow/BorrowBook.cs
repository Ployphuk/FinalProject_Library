using System;

class BorrwBook{
    private User user;
    private BookList bookList;

    public void BorrowScreen(User person){

    }

    public void SetUp(User person){
        this.user = user;
    }

    private void PrintBorrowHead(){
        Console.WriteLine("BorrowBook System");
        Console.WriteLine("---------------------");
    }

    private void PrintBookList(){
        this.bookList = new BookList();

        bookList.FetchBookList();
    }

}