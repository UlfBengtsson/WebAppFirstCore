using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppFirstCore.Models
{
    public interface ICakeService
    {   // CRUD

        //Create
        Cake CreateCake(string name, int price, string details);

        //Read All
        List<Cake> AllCakes();
        //Read One
        Cake FindCake(int id);

        //Update
        bool UpdateCake(Cake cake);

        //Delete
        bool DeleteCake(int id);
    }
}
