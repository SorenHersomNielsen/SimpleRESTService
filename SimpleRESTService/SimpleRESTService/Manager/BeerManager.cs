using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SimpleRESTService.Model;

namespace SimpleRESTService.Manager
{
    public class BeerManager
    {
        private static int nextId = 1;

        private readonly static List<Beer> BeerList = new List<Beer>
        {
            new Beer {Id = nextId++, Name = "Carlsberg", Price = 39, Abv = 5},
            new Beer {Id = nextId++, Name = "Tuborg", Price = 29, Abv = 4}
        };

        public List<Beer> GetAll()
        {
            return new List<Beer>(BeerList);
        }
        
        public Beer GetbyId(int id)
        {
            return BeerList.Find(BeerList => BeerList.Id == id);
        }

        public Beer Add(Beer NewBeer)
        {
            NewBeer.Id = nextId++;
            BeerList.Add(NewBeer);
            return NewBeer;
        }

        public Beer Update(int id, Beer updates)
        {
            Beer beer = BeerList.Find(beer1 => beer1.Id == id);
            if (beer == null)
            {
                return null;
            }
            beer.Name = updates.Name;
            beer.Price = updates.Price;
            beer.Abv = updates.Abv;
            return beer;
        }

        public Beer Delete(int id)
        {
            Beer beer = BeerList.Find(beer1 => beer1.Id == id);
            if (beer == null)
            {
                return null;
            }
            BeerList.Remove(beer);
            return beer;
        }
    }
}
