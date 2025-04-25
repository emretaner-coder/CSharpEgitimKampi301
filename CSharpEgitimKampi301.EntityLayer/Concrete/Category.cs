using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgitimKampi301.EntityLayer.Concrete
{
    public class Category
    {
        public int CategoryId { get; set; } 
        public string CategoryName { get; set; }
        public bool CategoryStatus { get; set; }  
        public List<Product> Products { get; set; } // bir kategori birden fazla ürün için olabilir Bire-çok ilişki
    }
}
/* Field-Variable-Property
 * Field: Class içinde tanımlanan değişkenlerdir. Genellikle private erişim belirleyicisi ile tanımlanır. int x --> Field
 * Variable: Method içinde tanımlanan değişkenlerdir. Genellikle local değişkenlerdir.
 * Property: Class içinde tanımlanan değişkenlerin dışarıya açılan kapısıdır. Genellikle public erişim belirleyicisi ile tanımlanır.
 */