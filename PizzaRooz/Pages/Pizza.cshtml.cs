using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PizzaRooz.Models;

namespace PizzaRooz.Pages
{
    public class PizzaModel : PageModel
    {
        public List<PizzasModel> fakeDB = new List<PizzasModel>() { 
            new PizzasModel(){ImageTitle="Margerita",PizzaName="Margertia",BasePrice=2,TomatoSuace =true, Cheese=true, FinalPrice=5},
			new PizzasModel(){ImageTitle="Bolognese",PizzaName="Bolognese",BasePrice=2,TomatoSuace =true, Cheese=true, FinalPrice=6.2f},
			new PizzasModel(){ImageTitle="Hawaiian",PizzaName="Hawaiian",BasePrice=2,TomatoSuace =true, Cheese=true,Ham=true, FinalPrice=6.5f},
			new PizzasModel(){ImageTitle="Carbonara",PizzaName="Carbonara",BasePrice=2,TomatoSuace =true, Cheese=true,Mushroom=true, FinalPrice=6.5f},
			new PizzasModel(){ImageTitle="MeatFeast",PizzaName="MeatFeast",BasePrice=2,TomatoSuace =true, Cheese=true,Ham=true, FinalPrice=7.5f},
			new PizzasModel(){ImageTitle="Mushroom",PizzaName="Mushroom",BasePrice=2,Mushroom=true, FinalPrice=4},
			new PizzasModel(){ImageTitle="Pepperoni",PizzaName="Pepperoni",BasePrice=2,Peperoni=true, FinalPrice=3.5f},
			new PizzasModel(){ImageTitle="Seafood",PizzaName="Seafood",BasePrice=2,Peperoni=true, FinalPrice=6.2f},
			new PizzasModel(){ImageTitle="Vegitarian",PizzaName="Vegitarian",BasePrice=2,TomatoSuace =true, Cheese=true, Mushroom=true,Paneer=true,FinalPrice=8.3f},


		};
        public void OnGet()
        {
        }
    }
}
