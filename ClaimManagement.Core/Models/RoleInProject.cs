using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaimManagement.Core.Models
{
    public class RoleInProject
    {
        [Key]
        public Guid Id { get; set; }

        public string RoleName { get; set; }
        public virtual List<ProjectRoleStaff> ProjectRoleStaffs { get; set; }
    }
}