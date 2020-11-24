using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CurrencyConverter.Pages
{
    public class ConverterModel : PageModel
    {
		public string euro;
        public string input;
		public Double euroRate = 1.14;

        public void OnGet()
        {
        }

		public void OnPost()
        {
			string inputValue = Request.Form["input"];

            if (!string.IsNullOrEmpty(inputValue))
			{
				double inputValueDouble = Convert.ToDouble(Request.Form["input"]);
				double convertedValue = Math.Round(inputValueDouble * this.euroRate, 2);
				this.euro = "Euros: €" + convertedValue.ToString("n2");
			}


			this.input = inputValue;
        }
    }
}
