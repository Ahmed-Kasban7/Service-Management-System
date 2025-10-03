using Domain.Common;


namespace Domain.Entities;

public abstract class Person : BaseEntity
{
     public string Name { get; set; } = null!;
     public string Address { get; set; } = null!;
     public string? URL { get; set; }
     public string? Notes { get; set; }

     public Person(string? personId,string name, string address, string? url, string? notes): base(personId)
     {
         Name = name;
         Address = address;
         URL = url;
         Notes = notes;
     }

}
