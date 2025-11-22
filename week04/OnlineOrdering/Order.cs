public class Order
{
    private List<Product> _products = new List<Product>();
    private Costumer _costumer;

    public Order(Costumer costumer)
    {
        _costumer = costumer;
    }
    public void AddProducts(Product product)
    {
        _products.Add(product);
    }
    public double TotalCost()
    {
        double total = 0;

        foreach(var item in _products)
        {
            total += item.CostOfProduct();
        }
        if (_costumer.LiveUsa())
        {
            total += 5;
        }
        else
        {
            total +=35;
        }
        return total;
    }

    public string PackingLabel()
    {
        string label ="";
        foreach(var item in _products)
        {
            label += item.GetShippingInfo();
        }
        return label;
    }

    public string ShippingLabel()
    {
        return _costumer.GetCostumerInfo();
    }


}