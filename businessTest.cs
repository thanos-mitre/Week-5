public void GetAllCustomers_ReturnsAllCustomers()
{
    // Arrange
    var customerRepo = new CustomerRepository();
    var customers = new List<Customer>
    {
        new Customer { CustomerId = 1, FirstName  = "Pavlos", LastName  = "Georgiou"},
        new Customer { CustomerId = 2, FirstName  = "Takis", LastName  = "Papadopoulos" }
    };
    ErpDB.Customers.AddRange(customers);

    var result = customerRepo.GetAll();

    Assert.That(result, Is.EqualTo(ErpData.Customers));
}