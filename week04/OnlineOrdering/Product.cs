public class Product
{
    private string _productName;
    private string _productId;
    private double _price;
    private int _quantity;

    public Product(string productname, string productid, double price, int quantity)
    {
        _productName = productname;
        _productId = productid;
        _price = price;
        _quantity = quantity; 
    }
    public double CostOfProduct()
    {
        return _price * _quantity;
    }

    public string GetShippingInfo()
    {
        return $"{_productName} {_productId}\n";
    }
}