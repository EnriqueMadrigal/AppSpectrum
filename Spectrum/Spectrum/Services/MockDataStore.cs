using Spectrum.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Spectrum.Services
{
    public class MockDataStore : IDataStore<Item>
    {
        readonly List<Item> items;

        public MockDataStore()
        {
            items = new List<Item>()
            {
                /*
                new Item { Id = Guid.NewGuid().ToString(), Text = "First item", Description="This is an item description." },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Second item", Description="This is an item description." },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Third item", Description="This is an item description." },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Fourth item", Description="This is an item description." },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Fifth item", Description="This is an item description." },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Sixth item", Description="This is an item description." }
                */
new Item { Id = Guid.NewGuid().ToString(), Text = "Old Fashioned", Image = "old_fashioned.jpg", Description="There may be no better test of a bartender's mettle than ordering an Old Fashioned." },
new Item { Id = Guid.NewGuid().ToString(), Text = "Margarita", Image ="margarita.jpg", Description="Cloyingly sweet margarita mixes have given this drink a bad name. A well-made version is a fresh mix of lime juice and tequila, with a hint of sweetener." },
new Item { Id = Guid.NewGuid().ToString(), Text = "Cosmopolitan",Image ="cosmopolitan.jpg" ,Description="The cosmo became almost ubiquitous in the '90s thanks to the TV show Sex and the City, but this spin on the martini remains just as tasty today as when Carrie Bradshaw made it famous." },
new Item { Id = Guid.NewGuid().ToString(), Text = "Negroni",Image ="negroni.jpg", Description="A favorite of bartenders all over the world, the Negroni is a simple three-ingredient cocktail" },
new Item { Id = Guid.NewGuid().ToString(), Text = "Martini", Image = "martini",Description="James Bond was wrong—whether you drink it with gin or vodka, stirred is the way to go when ordering a martini." },
new Item { Id = Guid.NewGuid().ToString(), Text = "Mojito", Image = "mojito",Description="Originating in Cuba, this refreshing rum-based sip is filled with mint and lime—a perfect combination for sipping by the pool or beach." },
new Item { Id = Guid.NewGuid().ToString(), Text = "Whiskey", Image = "whiskey.jpg", Description="Perhaps the most refreshing whiskey cocktail, this is an old reliable favorite." },
new Item { Id = Guid.NewGuid().ToString(), Text = "French", Image = "french.jpg", Description="Created during World War I, the name of this drink was supposedly inspired by the fact that taking a sip of it feels like getting shelled with a French 75mm field gun, a powerful piece of artillery." },
new Item { Id = Guid.NewGuid().ToString(), Text = "Manhattan", Image = "manhattan.jpg",Description="Created sometime in the mid-1800s, the Manhattan is one of the booziest classic drink recipes." },
new Item { Id = Guid.NewGuid().ToString(), Text = "Spritz", Image = "spritz.jpg",Description="SLow on alcohol and high on refreshment, the spritz has been a crowd-pleasing favorite aperitivo for more than two centuries." },
new Item { Id = Guid.NewGuid().ToString(), Text = "Gimlet", Image = "gimlet.jpg",Description="The classic recipe calls for gin, but this drink is just as tasty if you substitute vodka instead." },
new Item { Id = Guid.NewGuid().ToString(), Text = "Sazerac", Image = "sazerac.jpg",Description="If you like a drink with some bite, give this classic New Orleans concoction a try." },
new Item { Id = Guid.NewGuid().ToString(), Text = "Vesper", Image = "vesper.jpg",Description="You might think of a martini when you think of James Bond, but this drink is the true tipple of the iconic spy—the recipe first appeared in Ian Fleming's 1953 novel Casino Royale in homage to the Bond girl Vesper Lynd. While Bond takes his 'shaken, not stirred', most stick to the rule that spirits-only cocktails should be stirred instead." },
new Item { Id = Guid.NewGuid().ToString(), Text = "Mimosa", Image = "mimosa.jpg",Description="We'd like to salute Frank Meier, the bartender at the Ritz Paris who in 1925 reportedly served the first mimosa. The recipe just might be the simplest cocktail ever created." },
new Item { Id = Guid.NewGuid().ToString(), Text = "Tom Collins", Image = "tom_collins.jpg",Description="Essentially a sour topped with club soda, the Tom Collins is a classic cocktail that's as easy and delicious to whip up at home as it is at your favorite bar." },
new Item { Id = Guid.NewGuid().ToString(), Text = "Paloma", Image = "paloma.jpg",Description="In Mexico the paloma is just as popular as the classic margarita, and with a thirst-quenching combination of tequila, lime, and grapefruit soda it's bound to become a summer favorite of yours too." },
new Item { Id = Guid.NewGuid().ToString(), Text = "Sidecar", Image = "sidecar.jpg",Description="This simple mix of brandy, lemon juice, and orange liqueur dates to the 1920s. Once you try one you'll understand why the recipe has survived so long." },
new Item { Id = Guid.NewGuid().ToString(), Text = "Mint Julep", Image = "mint_julep.jpg",Description="The official drink of the Kentucky Derby is worth ordering even when you're not at Churchill Downs." },
new Item { Id = Guid.NewGuid().ToString(), Text = "Daiquiri", Image = "daiquiri.jpg",Description="Forget the sweet frozen version made with a blender. A classic daiquiri is one of the most well-balanced cocktails around." },
new Item { Id = Guid.NewGuid().ToString(), Text = "Dark & Stormy", Image = "dark_stormy.jpg", Description="The Dark 'n Stormy was created on Bermuda in the late 1800s when British sailors, already rum fans, took to brewing ginger beer and combined their two favorites into one tasty concoction. Traditionally the cocktail is made exclusively with Bermuda-native Gosling’s Black Seal Rum." },
new Item { Id = Guid.NewGuid().ToString(), Text = "Martinez", Image = "martinez.jpg", Description="Not quite a Manhattan and not quite a Martini, the Martinez uses 'Old Tom,' a slightly sweeter style of gin that debuted in the mid-1800s. For the authentic taste, ask for it by name." },
new Item { Id = Guid.NewGuid().ToString(), Text = "Pina Colada", Image = "pina_colada.jpg", Description="Piña Colada is a cocktail made with rum, cream of coconut or coconut milk, and pineapple juice, usually served either blended or shaken with ice. It may be garnished with either a pineapple wedge, maraschino cherry, or both. There are two versions of the drink, both originating in Puerto Rico. " },
new Item { Id = Guid.NewGuid().ToString(), Text = "Screwdriver", Image = "screwdriver.jpg", Description="A screwdriver is a popular alcoholic highball drink made with orange juice and vodka. In the UK, it is referred to as a 'vodka and orange'.[1] While the basic drink is simply the two ingredients, there are many variations. Many of the variations have different names in different parts of the world." }



            };
        }

        public async Task<bool> AddItemAsync(Item item)
        {
            items.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> UpdateItemAsync(Item item)
        {
            var oldItem = items.Where((Item arg) => arg.Id == item.Id).FirstOrDefault();
            items.Remove(oldItem);
            items.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> DeleteItemAsync(string id)
        {
            var oldItem = items.Where((Item arg) => arg.Id == id).FirstOrDefault();
            items.Remove(oldItem);

            return await Task.FromResult(true);
        }

        public async Task<Item> GetItemAsync(string id)
        {
            return await Task.FromResult(items.FirstOrDefault(s => s.Id == id));
        }

        public async Task<IEnumerable<Item>> GetItemsAsync(bool forceRefresh = false)
        {
            return await Task.FromResult(items);
        }
    }
}