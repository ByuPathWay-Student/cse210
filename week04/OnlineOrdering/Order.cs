public class Order
{
    private List<Product> _products;
    private Customer _customer;

    public Order(List<Product> products, Customer customer)
    {
        _customer = customer;
        _products = products;
    }

    public int CalculateTotal()
    {
        int total = 0;
        foreach (Product product in _products)
        {
            total += product.ProductTotal(); 
        }
        if (_customer.CheckCountry())
        {
            total += 5;
        }
        else
        {
            total += 35;
        }
        return total;
    }

    public string DisplayPackingLabel()
    {
        string packingLabel = "";
        foreach (Product product in _products)
        {
            packingLabel += product.GetLabel();
        }
        return packingLabel;
    }

    public string DisplayShippingLabel()
    {
        return _customer.GetCustomer();
    }


}