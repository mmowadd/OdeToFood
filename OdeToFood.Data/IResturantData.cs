using OdeToFood.Core;
using System.Collections.Generic;

namespace OdeToFood.Data
{
    public interface IResturantData
    {
        IEnumerable<Resturant> GetAll();
    }
}
