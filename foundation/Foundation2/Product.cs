public class Product
{
    //member variables
    private string _prodName;
    private string _prodID;
    private decimal _prodPrice;
    private int _quantity;

    public Product(string prodName, string prodID, decimal prodPrice, int quantity)
    {
        _prodName = prodName;
        _prodID = prodID;
        _prodPrice = prodPrice;
        _quantity = quantity;
    }

    //method to get total price of order (product price x quantity of product)
    public decimal GetTotalPrice()
    {
        return _prodPrice * _quantity;
    }

    //methods or getters for private variables
    public string GetName()
    {
        return _prodName;
    }

    public string GetProdID()
    {
        return _prodID;
    }
}
