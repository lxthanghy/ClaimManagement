using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaimManagement.Core.Models
{
    public class Staff
    {
        [Key]
        public Guid Id { get; set; }

        public string StaffName { get; set; }
        public string DepartmentName { get; set; }
        public string JobRank { get; set; }
        public decimal Salary { get; set; }

        [Column(TypeName = "nvarchar")]
        [MaxLength(128)]
        public string UserId { get; set; }

        public virtual List<ClaimRequest> ClaimRequests { get; set; }
        public virtual List<ProjectRoleStaff> ProjectRoleStaffs { get; set; }
    }
}