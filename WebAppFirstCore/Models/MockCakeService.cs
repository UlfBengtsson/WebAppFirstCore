using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppFirstCore.Models
{
    public class MockCakeService : ICakeService
    {
        private List<Cake> cakes = new List<Cake>();
        private int idCount = 1;

        public MockCakeService()
        {
            cakes.Add(new Cake() { Id=0, Name="Strawberry Cake", Price=98, Details= "Jummy Strawberry's" });
        }

        public List<Cake> AllCakes()
        {
            return cakes;
        }

        public Cake CreateCake(string name, int price, string details)
        {
            Cake cake = new Cake() { Id = idCount, Name = name, Price = price, Details = details };
            idCount++;
            cakes.Add(cake);
            return cake;
        }

        public bool DeleteCake(int id)
        {
            bool wasRemoved = false;

            foreach (Cake item in cakes)
            {
                if(item.Id == id)
                {
                    cakes.Remove(item);
                    wasRemoved = true;
                    break;
                }
            }

            return wasRemoved;
        }

        public Cake FindCake(int id)
        {
            foreach (Cake item in cakes)
            {
                if (item.Id == id)
                {
                    return item;
                }
            }

            return null;
        }

        public bool UpdateCake(Cake cake)
        {
            bool wasUpdated = false;

            foreach (Cake original in cakes)
            {
                if (original.Id == cake.Id)
                {
                    original.Name = cake.Name;
                    original.Price = cake.Price;
                    original.Details = cake.Details;

                    wasUpdated = true;
                    break;
                }
            }

            return wasUpdated;
        }
    }
}
