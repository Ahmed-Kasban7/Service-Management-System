using Domain.Enums;

namespace Domain.Entities;
public class Customer :Person
{
    public int Points { get; private set; }
    public CustomerType Type { get; set; } = CustomerType.Regular;
    public MarketingSource Source { get; set; } = MarketingSource.None;


    // When retrive customer data form data base 
    public Customer(string? personId,string name , string address , string? url,string? notes
        , int points, CustomerType type, MarketingSource source) 
        : base (personId,name, address, url , notes)
    {
        Points = points;
        Type = type;
        Source = source;
    }

    // When create new customer 
    public Customer(string name, string address, string? url, string? notes
      , CustomerType type, MarketingSource source) : this(null, name, address, url, notes, 0, type, source) { }



}

