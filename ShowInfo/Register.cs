using System;
using System.Collections.Generic;

enum RegisterMenu{
    User = 1,
    Admin
}

class PrintRegisterMenu{
    public void RegisterHeader(){
        Console.WriteLine("Register Menu ");
        Console.WriteLine("You have to create new accout for use program");
        Console.WriteLine(" First of all we have to khow who you are");
        Console.WriteLine("Press 1 : If you are new User");
        Console.WriteLine("Press 2 : If you are new Admin");
    }

    private void GetRegisterChoice(){
        Console.Write(" Press your choice : ");
        RegisterMenu register = (RegisterMenu)(int.Parse(Console.ReadLine()));
    }

    private void ChooseType(RegisterMenu register){

        if(register == RegisterMenu.User){

        }else if(register == RegisterMenu.Admin){
            
        }
    }

    private static void NewUser(){
        Console.Clear();
    }
}