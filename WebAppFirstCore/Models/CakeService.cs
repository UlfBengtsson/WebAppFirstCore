using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppFirstCore.Models
{
    public class CakeService : ICakeService
    {
        readonly CakeDbContext _cakeDbContext;

        public CakeService(CakeDbContext cakeDbContext)
        {
            _cakeDbContext = cakeDbContext;
        }

        public List<Cake> AllCakes()
        {
            return _cakeDbContext.Cakes.ToList();
        }

        public Cake CreateCake(string name, int price, string details)
        {
            Cake cake = new Cake() { Name = name, Price = price, Details = details };

            _cakeDbContext.Cakes.Add(cake);
            _cakeDbContext.SaveChanges();   //Don´t forget this

            return cake;
        }

        public bool DeleteCake(int id)
        {
            bool wasRemoved = false;

            Cake cake = _cakeDbContext.Cakes.SingleOrDefault(cakes => cakes.Id == id);

            if (cake == null)
            {
                return wasRemoved;
            }

            _cakeDbContext.Cakes.Remove(cake);
            _cakeDbContext.SaveChanges();   //Don´t forget this

            return wasRemoved = true;
        }

        public Cake FindCake(int id)
        {
            return _cakeDbContext.Cakes.SingleOrDefault(cakes => cakes.Id == id);
        }

        public bool UpdateCake(Cake cake)
        {
            bool wasUpdated = false;

            Cake original = _cakeDbContext.Cakes.SingleOrDefault(cakes => cakes.Id == cake.Id);
            if (original != null)
            {
                original.Name = cake.Name;
                original.Price = cake.Price;
                original.Details = cake.Details;

                _cakeDbContext.SaveChanges();   //Don´t forget this
                wasUpdated = true;
            }

            return wasUpdated;
        }
    }
}
