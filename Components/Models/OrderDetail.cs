namespace Company_Frontend.Components.Models;
public class OrderDetail
{
    public Product Product { get; set; }
    public int Quantity { get; set; }

    public OrderDetail(Product product)
    {
        Product = product;
        Quantity = 1;
    }
}