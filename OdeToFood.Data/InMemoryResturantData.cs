using OdeToFood.Core;
using System.Collections.Generic;

namespace OdeToFood.Data
{
    public class InMemoryResturantData : IResturantData
    {
        readonly List<Resturant> resturants;
        public InMemoryResturantData()
        {
            resturants = new List<Resturant>
            {
                new Resturant{Id = 1,Name = "Pizza King",Cousin= CousinTypeEnum.ITALIAN, Location = "MidTown"},
                new Resturant{Id = 2,Name = "KFC",Cousin= CousinTypeEnum.NONE, Location = "90 St"},
                new Resturant{Id = 3,Name = "Hamza",Cousin= CousinTypeEnum.Egyptian, Location = "Nasr City"}
            };
        }
        public IEnumerable<Resturant> GetAll() => resturants;

    }
}
