using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace projectData
{
    public class Product
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }

        [Required]
        public virtual Shop shop { get; set; }

        [ForeignKey("Shop")]
        public int ShopID { get; set; }

        public override string ToString()
        {
            return Name + "--->" + Price.ToString() + ShopID.ToString();
        }
    }
}