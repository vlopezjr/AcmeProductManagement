using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APM.WebAPI.models
{
    public interface IProductRepository
    {
        Product Create();
        List<Product> Retrieve();
        Product Save(Product product);
        Product Save(int id, Product product);
    }
}
