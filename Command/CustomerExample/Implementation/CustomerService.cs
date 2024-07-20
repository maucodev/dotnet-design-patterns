using System;

namespace Command.CustomerExample.Implementation;

/// <summary>
/// Represents a customer service that acts as a receiver in the Command Pattern.
/// </summary>
public class CustomerService
{
    /// <summary>
    /// Adds a customer to the database.
    /// </summary>
    public void AddCustomer()
    {
        Console.WriteLine("Customer added to the database");
    }
}