public class Product
{
    string _productName;
    string _productId;
    int _productPrice;
    int _numSold;


    public Product(string name, string id, int price, int quantity)
    {
        _productName = name;
        _productId = id;
        _productPrice = price;
        _numSold = quantity;
    }

    public string GetProductInformation()
    {
        return $"{_productName}| {_productId}| {_numSold}| {_productPrice}";
    }
    public int TotalCost()
    {
        int total = _numSold * _productPrice;
        return total;
    }
}