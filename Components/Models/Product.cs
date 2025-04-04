﻿namespace Company_Frontend.Components.Models;

public class Product
{
    public string? Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public decimal Price { get; set; }
    public bool Status { get; set; }
    public Category? Category { get; set; }
}
