using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace MagazinZaDrehi_Dimitrin_8_Petar_17.Model
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public string Size { get; set; }
        public string Gender { get; set; }
        
        public int ProductTypesId { get; set; }
        public ProductType ProductTypes { get; set; }
    }
}
