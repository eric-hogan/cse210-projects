public class Product
{
    string _productName;
    string _productId;
    float _productPrice;
    int _numSold;


    public Product(string name, string id, float price, int quantity)
    {
        _productName = name;
        _productId = id;
        _productPrice = price;
        _numSold = quantity;
    }
    public float TotalCost()
    {
        float total = _numSold * _productPrice;
        return total;
    }
}