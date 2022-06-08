using Microsoft.AspNetCore.Mvc;
using la_mia_pizzeria_static.Models;

namespace la_mia_pizzeria_static.Controllers
{
    public class PizzaController : Controller
    {
        public static listaPizze pizze = null;

        
        public IActionResult Index()
        {
            if (pizze ==null)
            {
                pizze = new listaPizze();

                Pizza pizza1 = new Pizza()
                {
                    Id = "1",
                    Nome = "Margherita",
                    Descrizione = "Pizza con mozzarella e pomodoro",
                    ImgPath = "/img/pizza1.jpg",
                    Prezzo = "5.00"

                };

                pizze.pizzas.Add(pizza1);

                Pizza pizza2 = new Pizza()
                {
                    Id = "2",
                    Nome = "Filetto",
                    Descrizione = "Pizza con pomodorini tagliatti a fette",
                    ImgPath = "/img/pizza2.jpg",
                    Prezzo = "7.00"

                };

                pizze.pizzas.Add(pizza2);

                Pizza pizza3 = new Pizza()
                {
                    Id = "3",
                    Nome = "Al salame",
                    Descrizione = "Pizza con fette di salame",
                    ImgPath = "/img/pizza3.jpg",
                    Prezzo = "6.50"

                };

                pizze.pizzas.Add(pizza3);

            }

            return View(pizze);
        }


        public IActionResult Show(int id)
        {
            foreach (var ele in pizze.pizzas)
            {
                if (ele.Id == Convert.ToString(id)) { return View("Show", pizze.pizzas[id - 1]); }

            }

            return NotFound(" La pizza con l'id " + id + " non è stato trovato ");

        }
    }
}
