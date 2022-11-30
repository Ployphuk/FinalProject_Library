using System;

class UserMenu{
    private User user;

    public void ShowUserMenu(User user){

    }

    private void PrintHeadScree(){
        Console.Clear();
        Console.WriteLine(" User Screen");
    }

    private void ShowBorrowBookScreen(){
        
    }

    private void SetUp(User user){
        this.user = (User)user;
    }
}