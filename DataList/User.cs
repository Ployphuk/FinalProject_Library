class User : Person {
    string userName;
    string password;

    public User(string name, string surname, string userName, string password) 
        : base(name,surname){
        this.userName = userName;
        this.password = password;
    }

    public string GetUserName() {
        return this.userName;
    }

    public string GetPassword() {
        return this.password;
    }


}