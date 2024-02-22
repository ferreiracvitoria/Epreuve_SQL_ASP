using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ASPEpreuve.Models
{
    public class ProduitCreateForm
    {
        [DisplayName("Nom")]
        public string Nom {  get; set; }

        [DisplayName("Description")]
        public string Description { get; set; }

        [DisplayName("Prix")]
        public decimal Prix { get; set; }

        [DisplayName("Stock")]
        public int Stock { get; set; }
    }
}
