using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaimManagement.Core.Models
{
    public class ClaimDetail
    {
        [Key]
        public Guid Id { get; set; }

        public DateTime Date { get; set; }
        public string Day { get; set; }
        public DateTime From { get; set; }
        public DateTime To { get; set; }
        public int TotalworkingHour { get; set; }
        public string Remarks { get; set; }
        public Guid ClaimRequestId { get; set; }
        public virtual ClaimRequest ClaimRequest { get; set; }
    }
}