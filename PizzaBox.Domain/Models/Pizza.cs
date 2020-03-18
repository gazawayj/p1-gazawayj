using System.Collections.Generic;

namespace PizzaBox.Domain.Models
{
  public class Pizza
  {
    public Crust Crust { get; set; }
    public Size Size { get; set; }
    public string Name { get; set; }
    public List<Topping> Toppings { get; set; }
  }
}