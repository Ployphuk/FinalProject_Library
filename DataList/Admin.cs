using System;

class Admin: Person {
    private string AdminID;

    public Admin(string name, string surname, string userName, string password)
    : base (name,surname){
        this.AdminID = AdminID;
    }

    public string GetAdminID(){
        return this.AdminID;
    }
}