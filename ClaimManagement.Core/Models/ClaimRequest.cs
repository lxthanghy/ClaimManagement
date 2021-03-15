using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaimManagement.Core.Models
{
    public class ClaimRequest
    {
        [Key]
        public Guid Id { get; set; }

        public string StaffName { get; set; }
        public string StaffDepartment { get; set; }
        public Guid StaffId { get; set; }
        public string ProjectName { get; set; }
        public string Status { get; set; }
        public string RoleInProject { get; set; }
        public int ProjectDuration { get; set; }
        public string AuditTrail { get; set; }
        public DateTime? SubmittedDate { get; set; }
        public DateTime? ApprovedDate { get; set; }
        public virtual Staff Staff { get; set; }
        public virtual List<ClaimDetail> ClaimDetails { get; set; }
    }
}