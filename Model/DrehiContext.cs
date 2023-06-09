using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagazinZaDrehi_Dimitrin_8_Petar_17.Model
{
    public class DrehiContext:DbContext
    {
        public DrehiContext():base("DrehiContext")
        {

        }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductType> ProductTypes { get; set; }
    }
}
