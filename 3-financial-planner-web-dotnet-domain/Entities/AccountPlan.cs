using System.ComponentModel.DataAnnotations;

namespace financial_planner_web_dotnet_domain.Entities
{
    public class AccountPlan
    {
        [Key]
        public int? Id { get; set; }

        [Required]
        [StringLength(50)]
        public string NameDescription { get; set; }

        [Required]
        [StringLength(15)]
        public string Kind { get; set; }
    }
}
