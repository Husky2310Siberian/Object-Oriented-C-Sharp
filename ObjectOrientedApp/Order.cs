namespace ObjectOrientedApp.Model;

public class Order
{
    private int _id;
    private DateTime _date;

    // only one of two can be private 
    // private set , accessible from Class
    public int Id { get { return _id; } private set { _id = value; } }
    public DateTime Date { get { return _date; } private set { _date = value; } }
    
    
}