namespace BlazingPizza.Data;

public class Pizza
{
    public int PizzaId { get; set; }
    
    public string Name { get; set; } = string.Empty;
    
    public string Description { get; set; } = string.Empty;
    
    public decimal Price { get; set; }
    
    public bool Vegetarian { get; set; }
    
    public bool Vegan { get; set; }

    public string ImageUrl { get; set; } = string.Empty;

}