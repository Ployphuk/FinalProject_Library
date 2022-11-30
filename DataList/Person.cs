using System;
public abstract class Person{
    private string name;
    private string surname;

    public Person(string name, string surname){
        this.name = name;
        this.surname = surname;
    }

    public string GetName(){
        return this.name;
    }
    public string GetUserName(){
        return this.surname;
    }
}