﻿public class CartItem
{
    public CartItem() { }

    public CartItem(Product product, int quantity)
    {
        this.Product = product;
        this.Quantity = quantity;
    }

    public Product Product { get; set; }
    public int Quantity { get; set; }

    public void AddQuantity(int quantity)
    {
        this.Quantity += quantity;
    }

    /*public int TotalUnitPrice(int total, decimal price)
    {
        Product.UnitPrice = price;
        Quantity * price = total;
        return total;
    }*/

    public string Display()
    {
        string displayString =
            Product.Name + " (" + Quantity.ToString()
            + " at " + Product.UnitPrice.ToString("c") + " each = " + Product.UnitPrice * Quantity +")";

        return displayString;
    }

}