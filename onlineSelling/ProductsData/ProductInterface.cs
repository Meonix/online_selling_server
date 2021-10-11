using onlineSelling.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace onlineSelling.ProductsData
{
    interface ProductInterface
    {
        List<Product> getProducts();

        Product getProduct(Guid id);

        Product addProduct(Product product);

        void deleteProduct(Guid id);
    }
}
