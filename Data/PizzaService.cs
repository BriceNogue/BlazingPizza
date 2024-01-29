using BlazingPizza.Pages;
using Microsoft.AspNetCore.Mvc;

namespace BlazingPizza.Data;

public class PizzaService
{
    private Pizza[] ListPizzas = new Pizza[]{
    new Pizza
    {
        PizzaId = 1,
        Name = "Pizza Margherita",
        Description = "Tomato sauce, mozzarella cheese, and basil leaves",
        Price = 9.99m,
        Vegetarian = true,
        Vegan = false
    },
    new Pizza
    {
        PizzaId = 2,
        Name = "Pizza Pepperoni",
        Description = "Tomato sauce, mozzarella cheese, and pepperoni slices",
        Price = 10.99m,
        Vegetarian = false,
        Vegan = false
    },
    new Pizza
    {
        PizzaId = 3,
        Name = "Pizza Quatre Fromages",
        Description = "Tomato sauce, mozzarella, gorgonzola, emmental, and goat cheese",
        Price = 12.99m,
        Vegetarian = true,
        Vegan = false
    },
    new Pizza
    {
        PizzaId = 4,
        Name = "Pizza Hawaienne",
        Description = "Tomato sauce, mozzarella cheese, ham, and pineapple",
        Price = 11.99m,
        Vegetarian = false,
        Vegan = false
    },
    new Pizza
    {
        PizzaId = 5,
        Name = "Pizza Végétarienne",
        Description = "Tomato sauce, mozzarella cheese, bell peppers, onions, mushrooms, and olives",
        Price = 10.99m,
        Vegetarian = true,
        Vegan = true
    },
    new Pizza
    {
        PizzaId = 6,
        Name = "Pizza Calzone",
        Description = "Folded pizza with tomato sauce, mozzarella cheese, ham, and mushrooms",
        Price = 11.99m,
        Vegetarian = false,
        Vegan = false
    },
    new Pizza
    {
        PizzaId = 7,
        Name = "Pizza Prosciutto e Funghi",
        Description = "Tomato sauce, mozzarella cheese, ham, and mushrooms",
        Price = 11.99m,
        Vegetarian = false,
        Vegan = false
    },
    new Pizza
    {
        PizzaId = 8,
        Name = "Pizza Diavola",
        Description = "Tomato sauce, mozzarella cheese, spicy salami, and chili flakes",
        Price = 11.99m,
        Vegetarian = false,
        Vegan = false
    },
    new Pizza
    {
        PizzaId = 9,
        Name = "Pizza Capricciosa",
        Description = "Tomato sauce, mozzarella cheese, ham, mushrooms, artichokes, and olives",
        Price = 12.99m,
        Vegetarian = false,
        Vegan = false
    },
    new Pizza
    {
        PizzaId = 10,
        Name = "Pizza Frutti di Mare",
        Description = "Tomato sauce, mozzarella cheese, mixed seafood (shrimp, squid, mussels, etc.)",
        Price = 13.99m,
        Vegetarian = false,
        Vegan = false
    }
};
    
    public Task<Pizza[]> GetPizzasAsync()
    {
        // Call your data access technology here
        return Task.FromResult(ListPizzas);
    }

    
}