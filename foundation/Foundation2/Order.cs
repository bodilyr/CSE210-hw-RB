public class Order
{
    //member variables
    private List<Product> _products;
    private Customer _customer;

    //constructor to assign values to member variables
    public Order (Customer customer)
    {
        _customer = customer;
        _products = new List<Product>();
    }
    
    //calculate total cost of order
    public decimal GetTotalCost()
    {
        decimal total = 0;
        foreach (var product in _products)
        {
            total += product.GetTotalPrice();
        }
        //ternary operator - simplify a conditional assingment (if-else or true/false)
        total += _customer.IsInUSA() ? 5 : 35;

        return total;
    }

    //add a product to the list
    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    //methodsfor packing and shipping labels
    public string GetPackingLabel()
    {
        string packingLabel = "";
        foreach (var product in _products)
        {
            packingLabel += $"{product.GetName()}  (ID: {product.GetProdID()})\n";
        }
        return packingLabel;
    }

    public string GetShippingLabel()
    {
        return $"{_customer.GetName()}\n{_customer.GetAddress().GetAddress()}";
    }
}