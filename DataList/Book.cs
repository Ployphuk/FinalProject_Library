public class Book
{
    private int serialNumber;
    private string BookName;

    public Book(int serialNumber,string BookName)
    {
        this.serialNumber = serialNumber;
        this.BookName = BookName;
    }

    public int GetSerialNumber()
    {
        return this.serialNumber;
    }

    public string GetBookName()
    {
        return this.BookName;
    }
}