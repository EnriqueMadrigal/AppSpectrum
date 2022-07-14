using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Mime;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Threading.Tasks;

using Spectrum.Models;

namespace Spectrum.utils
{
    public class drinks_connect
    {
        private string url = "https://www.thecocktaildb.com/api/json/v1/1/search.php?s=";


        public async Task<List<Drink_Item>> GetByName(string name)
        {

            List<Drink_Item> items = new List<Drink_Item>();

            try
            {

                using (var client = new HttpClient())
                {

                    var request = new HttpRequestMessage
                    {
                        Method = HttpMethod.Get,
                        RequestUri = new Uri(url+name),
                        //Content = new StringContent("", Encoding.UTF8, MediaTypeNames.Application.Json /* or "application/json" in older versions */),
                    };

                    var response = await client.SendAsync(request).ConfigureAwait(false);
                    response.EnsureSuccessStatusCode();


                    if (response.IsSuccessStatusCode)
                    {

                        var result = response.Content.ReadAsStringAsync().Result;

                        JObject obj = JsonConvert.DeserializeObject<JObject>(result);
                        dynamic obj1 = JsonConvert.DeserializeObject<dynamic>(result);

                        JArray jArray = (JArray)obj["drinks"];

                        foreach (JObject item in jArray)
                        {
                            Drink_Item newItem = new Drink_Item();

                            newItem.idDrink = item.GetValue("idDrink").ToString();
                            newItem.strDrink = item.GetValue("strDrink").ToString();
                            newItem.strInstructions = item.GetValue("strInstructions").ToString();
                            newItem.strDrinkThumb = item.GetValue("strDrinkThumb").ToString();
                            newItem.strCategory = item.GetValue("strCategory").ToString();
                            newItem.strVideo = item.GetValue("strVideo").ToString();
                            newItem.strAlcoholic = item.GetValue("strAlcoholic").ToString();


                            newItem.Ingredients = new List<Ingredient>();
                            newItem.Mesures = new List<Mesure>();

                            for (int i=1;i<16;i++)
                            {
                                String key1 = "strIngredient" + i.ToString();
                                String key2 = "strMeasure" + i.ToString();

                                String curIngridient = item.GetValue(key1).ToString();
                                String curMesure = item.GetValue(key2).ToString();

                                if (curIngridient.Length > 0)
                                {
                                    Ingredient newIngridient = new Ingredient();
                                    newIngridient.strIngredient = curIngridient;
                                    newItem.Ingredients.Add(newIngridient);
                                }


                                if (curMesure.Length > 0)
                                {
                                    Mesure newMesure = new Mesure();
                                    newMesure.strMesure = curMesure;
                                    newItem.Mesures.Add(newMesure);
                                }

                            }


                            items.Add(newItem);

                        }

                        


                        //throw new ArgumentException("Exception from GetToken");
                        Console.WriteLine(result.ToString());
                        

                    }



                }
            }
            catch (Exception e)
            {
                // throw new ArgumentException("Exception from GetByName");
                return null;

            }


            return items;

        }



    }
}
