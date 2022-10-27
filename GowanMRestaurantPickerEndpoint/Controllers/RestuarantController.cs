/*Madeline Gowan
10-27-2022
Restuarant Picker - Endpoint
In this program we must generate a random restuarant. Allow the user to choose if they want a completely random restuarant, or one from a specific category.

Peer review: John Magpantay                        Notes: Clean Code, what stood out to me the most is the data validation and letting the user choose between categories of what they want randomize. Great job Overall!
*/

using Microsoft.AspNetCore.Mvc;

namespace GowanMRestaurantPickerEndpoint.Controllers;

[ApiController]
[Route("[controller]")]
public class RestaurantController : ControllerBase
{
    Random rnd = new Random();

    [HttpGet]
    [Route("Info")]
    //cheat sheet: https://localhost:xxxx/Restaurant/Info
    public string Info(){
        return "This program is going to help you pick a restuarant! You can enter 'Random', or you can pick a category: 'Coffee', 'Burgers' or 'Pizza'";
    }

    [HttpGet]
    [Route("Random")]
    //cheat sheet: https://localhost:xxxx/Restaurant/Random
    public string Random(){
        string[] pickRandom = {"Starbucks", "Dutch Bros", "Poppy Coffee", "Scooter's", "Empresso", "Terra Coffee", "House of Shaw", "Cafe Acacia", "Color Me Coffee", "Lollicup", "Squeeze Burger", "The Habit", "Flip's Burgers", "Victory Grill", "In-n-Out Burger", "Burger King", "Midnightrue at Burnie's", "Five Star Burger", "Super Burger", "Wendy's", "Little Caesar's", "Round Table", "Domino's", "Pizza Hut", "Mountain Mike's", "David's Pizza", "BJ's", "Eddie's Pizza", "VIP Pizza", "Michael's New York Style Pizza"};
        int indexR = rnd.Next(pickRandom.Length);
        return $"You should go to {(pickRandom[indexR])}!";
    }

    [HttpGet]
    [Route("Coffee")]
    //cheat sheet: https://localhost:xxxx/Restaurant/Coffee
    public string Coffee(){
        string[] pickCoffee = { "Starbucks", "Dutch Bros", "Poppy Coffee", "Scooter's", "Empresso", "Terra Coffee", "House of Shaw", "Cafe Acacia", "Color Me Coffee", "Lollicup" };
        int indexC = rnd.Next(pickCoffee.Length);
            return $"You should go to {(pickCoffee[indexC])}!";
    }

    [HttpGet]
    [Route("Burgers")]
    //cheat sheet: https://localhost:xxxx/Restaurant/Burgers
    public string Burgers(){
        string[] pickBurger = { "Squeeze Burger", "The Habit", "Flip's Burgers", "Victory Grill", "In-n-Out Burger", "Burger King", "Midnightrue at Burnie's", "Five Star Burger", "Super Burger", "Wendy's" };
        int indexB = rnd.Next(pickBurger.Length);
            return $"You should go to {(pickBurger[indexB])}!";
    }
    

    [HttpGet]
    [Route("Pizza")]
    //cheat sheet: https://localhost:xxxx/Restaurant/Pizza
    public string Pizza(){
        string[] pickPizza = { "Little Caesar's", "Round Table", "Domino's", "Pizza Hut", "Mountain Mike's", "David's Pizza", "BJ's", "Eddie's Pizza", "VIP Pizza", "Michael's New York Style Pizza" };
        int indexP = rnd.Next(pickPizza.Length);
            return $"You should go to {(pickPizza[indexP])}!";
    }

}