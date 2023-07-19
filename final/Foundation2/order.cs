public class Order{
    List<Products> products = new List<Products>();
    private Customer _customer;

    public Order(Customer customer){
        _customer=customer;
    }

    public double CalculateTotalCost(){
        double totalCost=0;
        foreach(Products product in products){
            totalCost+=product.getProductPrice();
        }
        if(_customer.IsInUsa()){
            totalCost+=5;
        }
        else {totalCost+=35;
        }
        
        return totalCost;
    }
    public void AddProduct(Products product){
        products.Add(product);
    }

    public string ShippingLabel(){
        return $"{_customer.GetName()} ---- {_customer.GetAddress()}";
    }

    public string PackingLabel(){
        string packingLabel="";
        foreach(Products product in products){
            packingLabel+=product.getProductName()+ "  " +product.getProductID()+ "\n"; 
        }
        return packingLabel;
    }
}