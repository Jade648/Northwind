public class Customer{
    public int CustomerId {get; set;}

    public string CompanyName {get; set;}

    public ICollection<Customer> customers { get; set; }

}

