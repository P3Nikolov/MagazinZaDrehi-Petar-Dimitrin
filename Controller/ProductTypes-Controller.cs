using MagazinZaDrehi_Dimitrin_8_Petar_17.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagazinZaDrehi_Dimitrin_8_Petar_17.Controller
{
    internal class ProductTypes_Controller
    {
        private DrehiContext _dhContext = new DrehiContext();
        public List<ProductType> GetAllTypes()
        {
            return _dhContext.ProductTypes.ToList();  
        }
        public string GetBreedId (int id)
        {
            return _dhContext.ProductTypes.Find(id).Name;
        }
    }
}
