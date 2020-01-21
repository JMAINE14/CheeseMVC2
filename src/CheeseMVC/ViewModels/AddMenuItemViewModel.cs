using CheeseMVC.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CheeseMVC.ViewModels
{
    public class AddMenuItemViewModel
    {
        public int MenuID { get; set; }
        public int CheeseID { get; set; }

        public Menu Menu { get; set; }

        public List<SelectListItem> Cheeses { get; set; }

        public AddMenuItemViewModel( Menu m, IEnumerable<Cheese> ch)
        {
            Cheeses = new List<SelectListItem>();

            foreach (Cheese specificCheese in ch)
            {
                Cheeses.Add(new SelectListItem
                {
                    Value = specificCheese.ID.ToString(),
                    Text = specificCheese.Name
                });
            }
        }
        public AddMenuItemViewModel()
        {

        }
    }
}
