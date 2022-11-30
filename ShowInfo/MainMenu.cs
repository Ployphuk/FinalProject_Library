using System;
using System.Collections.Generic;

enum MainMenu{
    Login = 1,
    Register
}

class PrintMainMenu{
    private List<User> users;

    public void ShowMainMenu(){
        PrepareUser();
        PrintHeadMainmenu();
        InputMainmenu();
    }
    private void PrepareUser(){
        this.users = new List<User>();
    }

    private void PrintHeadMainmenu(){
        Console.WriteLine("Welcome To Library Program");
        Console.WriteLine("Press 1 : Login " );
        Console.WriteLine("Press 2 : Register");
    }

    private void InputMainmenu(){
        Console.Write("Input : ");
        MainMenu menu = (MainMenu)(int.Parse(Console.ReadLine()));
        ChooseMainMenu(menu);
    }

    private void ChooseMainMenu(MainMenu menu){
        if(menu == MainMenu.Login){
            SwitchToLogin();
        }else if(menu == MainMenu.Register){
            SwitchToRegister();
        }
    }

    private void SwitchToLogin(){
        Console.WriteLine("Login");
    }

    private void SwitchToRegister(){
        Console.WriteLine("register");
    }
}