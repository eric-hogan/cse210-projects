using System.Data.Common;
public class Order
{
    List<Product> _products = new List<Product>();


    public string GetPackingLabel()
    {
        return "packing label";
    }

    public string GetShippingLable()
    {
        return "shipping label";
    }

    public float CalculateTotalPrice()
    {
        return 87;
    }
}