using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PizzaRooz.Models;

namespace PizzaRooz.Pages.Forms
{
    public class CustomPageModel : PageModel
    {
        [BindProperty]
        public PizzasModel Pizza { get; set; }

        public float PizzaPrice { get; set; }
        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            PizzaPrice = Pizza.BasePrice;
            if (Pizza.TomatoSuace)
            {
                PizzaPrice += 1f;
            }
            if (Pizza.Cheese)
            {
                PizzaPrice += 2f;
            }
			if (Pizza.Peperoni)
			{
				PizzaPrice += 1.5f;
			}
			if (Pizza.Pineapple)
			{
				PizzaPrice += 1.8f;
			}
			if (Pizza.Paneer)
			{
				PizzaPrice += 2.2f;
			}
            if (Pizza.Ham)
            {
                PizzaPrice += 2.5f;
            }
            if (Pizza.Mushroom)
            {
                PizzaPrice += 2f;
            }
            return RedirectToPage("/Checkout/Checkout",new { Pizza.PizzaName,PizzaPrice});
		}
    }
}
