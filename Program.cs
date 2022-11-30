using System;
namespace Stock{
    class Program{
    static PrintMainMenu printMainMenu;

    static void Main(string[] args){
        Program.printMainMenu = new PrintMainMenu();
        Program.printMainMenu.ShowMainMenu();
    }
}
}