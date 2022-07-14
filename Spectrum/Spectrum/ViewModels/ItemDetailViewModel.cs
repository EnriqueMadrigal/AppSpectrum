using Spectrum.Models;
using System;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using Xamarin.Forms;
using Spectrum.utils;


namespace Spectrum.ViewModels
{
    [QueryProperty(nameof(ItemId), nameof(ItemId))]
    public class ItemDetailViewModel : BaseViewModel
    {
        private string itemId;
        private string text;
        private string description;
        private string image;

        public ObservableCollection<Drink_Item> Drinks { get; }

        public ItemDetailViewModel()
        {
            Drinks = new ObservableCollection<Drink_Item>();
        }


        public string Id { get; set; }

        public string Text
        {
            get => text;
            set => SetProperty(ref text, value);
        }

        public string Description
        {
            get => description;
            set => SetProperty(ref description, value);
        }

        public string Image
        {
            get => image;
            set => SetProperty(ref image, value);
        }


        public string ItemId
        {
            get
            {
                return itemId;
            }
            set
            {
                itemId = value;
                LoadItemId(value);
            }
        }

        public async void LoadItemId(string itemId)
        {
            try
            {
                drinks_connect connect = new drinks_connect();

                

                var item = await DataStore.GetItemAsync(itemId);
                Id = item.Id;
                Text = item.Text;
                Description = item.Description;
                Image = item.Image;

                Drinks.Clear();
                var _drinks = await connect.GetByName(Text);
                foreach(Drink_Item newDrink in _drinks)
                {
                    Drinks.Add(newDrink);
                }


            }
            catch (Exception)
            {
                Debug.WriteLine("Failed to Load Item");
            }
        }
    }
}
