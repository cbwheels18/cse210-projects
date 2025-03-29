public class Order
{
    private List<Product> _products = new List<Product>();
    private Customer _customer;
    private decimal _shippingCost;

    

    public Order( Customer customer)
    {
        _customer = customer;
        if (customer.IsInUsa())
        {
            _shippingCost = 5;
        }
        else
        {
            _shippingCost = 35;
        };
    }

    public List<Product> GetProducts()
    {
        return _products;
    }

    public decimal GetTotalCost()
    {
        decimal total = 0;
        foreach (Product product in _products)
        {
            total += product.GetTotalCost();
        }
        total += _shippingCost;
        return total;
    }

    public string GetPackingLabel()
    {
        string label = "";
        foreach (Product product in _products)
        {
            label += $"Product ID: {product.GetProductId()}, Name: {product.GetName()}\n";
        }
        return label;
    }

    public string GetShippingLabel()
    {
        return Customer._address.GetFullAddress();
    }
}