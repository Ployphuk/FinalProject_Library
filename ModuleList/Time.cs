using System;
class Time{
    public void PrintTimeMenu(){
        PrintTimeInfo();
        InputDay();
    }

    private void PrintTimeInfo(){
        Console.WriteLine("| ----- Please select the date you want to borrow the book. -----");
        Console.WriteLine("|");
        Console.WriteLine("| Press 1 : 7 days");
        Console.WriteLine("| Press 2 : 15 days");
        Console.WriteLine("|");
        Console.WriteLine("| —--------------------------------------------------------------");
    }

    private void InputDay(){
        Console.Write(" Input Menu :");
        int input = int.Parse(Console.ReadLine());

        switch(input){
            case 1:{
                Print7Days();
                break;
            }
            case 2:{
                Print15Days();
                break;
            }
        }
    }

    private void Print7Days(){
        DateTime today = DateTime.Now;
        Console.WriteLine("| Book borrowing date : {0}",today);
        DateTime Deadline = today.AddDays(7);
        Console.WriteLine("| Book return date (7 days) : {0}",Deadline);
    }

    private void Print15Days(){
        DateTime today = DateTime.Now;
        Console.WriteLine("| Book borrowing date : {0}",today);
        DateTime Deadline = today.AddDays(15);
        Console.WriteLine("| Book return date (15 days) : {0}",Deadline);
    }



}