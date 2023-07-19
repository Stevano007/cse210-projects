public class Products{
    private string _productName;
    private int _productID;
    private double _productPrice;
    private double _productQuantity;


    public Products(string productName, int productID, double productPrice, double productQuantity){
        _productName=productName;
        _productID=productID;
        _productPrice=productPrice;
        _productQuantity=productQuantity;
    }

    public string getProductName(){
        return _productName;
    }
    public int getProductID(){
        return _productID;
    }
    public double getProductPrice(){
        return _productPrice*_productQuantity;
    }

}