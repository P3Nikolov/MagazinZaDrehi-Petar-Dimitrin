using MagazinZaDrehi_Dimitrin_8_Petar_17.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagazinZaDrehi_Dimitrin_8_Petar_17.Controller
{
    internal class Products_Controller
    {
        private DrehiContext _dhContext = new DrehiContext();

        public Product getById(int id)
        {
            Product found = _dhContext.Products.Find(id);
            if (found != null)
            {
                _dhContext.Entry(found).Reference(x => x.ProductTypes).Load();
            }
            return found;
        }

        public List<Product> GetAll()
        {
            return _dhContext.Products.Include("ProductTypes").ToList();
        }
        
        
    }
}
