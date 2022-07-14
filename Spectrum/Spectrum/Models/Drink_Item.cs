using System;
using System.Collections.Generic;
using System.Text;

namespace Spectrum.Models
{
    public class Drink_Item
    {
        public string idDrink { get; set; }
        public string strDrink { get; set; }
        public string strInstructions { get; set; }
        public string strCategory { get; set; }
        public string strAlcoholic { get; set; }
        public string strDrinkThumb { get; set; }
        public string strVideo { get; set; }


        public List<Ingredient> Ingredients { get; set; }
        public List<Mesure> Mesures { get; set; }


    }
}
