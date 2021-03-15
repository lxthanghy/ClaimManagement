using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaimManagement.Core.Models
{
    public class ProjectRoleStaff
    {
        [Key]
        [Column(Order = 1)]
        public string ProjectCode { get; set; }

        [Key]
        [Column(Order = 2)]
        public Guid RoleInProjectId { get; set; }

        [Key]
        [Column(Order = 3)]
        public Guid StaffId { get; set; }

        public virtual Project Project { get; set; }
        public virtual RoleInProject Role { get; set; }
        public virtual Staff Staff { get; set; }
    }
}