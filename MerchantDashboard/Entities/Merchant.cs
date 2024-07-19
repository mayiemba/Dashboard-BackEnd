using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MerchantDashboard.Entities
{
    public class Merchant
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int RefNumber { get; set; }
        public string Name { get; set; } = string.Empty;
        public int Id { get; set; }
        public string Location { get; set; } = string.Empty;
        public int Attempts { get; set; }
        public string Status { get; set; } = string.Empty;
        
    }
}
