using Command.CustomerExample.Framework;

namespace Command.CustomerExample.Implementation;

/// <summary>
/// Represents a command for adding a customer, which is a concrete command in the Command Pattern.
/// </summary>
public class AddCustomerCommand : ICommand
{
    private readonly CustomerService _customerService;

    /// <summary>
    /// Initializes a new instance of the <see cref="AddCustomerCommand"/> class with the specified customer service.
    /// </summary>
    /// <param name="customerService">The customer service to use for adding a customer.</param>
    public AddCustomerCommand(CustomerService customerService)
    {
        _customerService = customerService;
    }

    /// <inheritdoc/>
    public void Execute()
    {
        _customerService.AddCustomer();
    }
}