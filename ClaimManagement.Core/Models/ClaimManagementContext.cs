using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaimManagement.Core.Models
{
    public class ClaimManagementContext : DbContext
    {
        public ClaimManagementContext() : base("ClaimManagementConnection")
        {
            Database.SetInitializer(new ClaimManagementInitializer());
        }

        public DbSet<Project> Projects { get; set; }
        public DbSet<RoleInProject> RoleInProjects { get; set; }
        public DbSet<ProjectRoleStaff> ProjectRoleStaffs { get; set; }

        public DbSet<Staff> Staffs { get; set; }
        public DbSet<ClaimRequest> ClaimRequests { get; set; }
        public DbSet<ClaimDetail> ClaimDetails { get; set; }
    }
}