using System.Collections.Generic;

public class Customer{
    public int CustomerId {get; set;}

    public string CompanyName {get; set;}

    public string Address {get; set;}

    public string City {get; set;}

    public string Region {get; set;}

    public string PostalCode {get; set;}

    public string Country {get; set;}

    public string Phone {get; set;}

    public string Fax {get; set;}

    public ICollection<Customer> customers { get; set; }

}

