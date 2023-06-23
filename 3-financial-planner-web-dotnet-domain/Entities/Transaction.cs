using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace financial_planner_web_dotnet_domain.Entities
{
    public class Transaction
    {
        [Key]
        public int? Id { get; set; }

        public string Historic { get; set; }

        [Required]
        public DateTime Date { get; set; }

        public decimal? Value { get; set; }

        [Required]
        [ForeignKey("AccountPlan")]
        public int AccountPlanId { get; set; }

        public virtual AccountPlan AccountPlan { get; set; }
    }
}
