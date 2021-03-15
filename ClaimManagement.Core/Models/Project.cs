using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaimManagement.Core.Models
{
    public class Project
    {
        [Key]
        public string ProjectCode { get; set; }

        public string ProjectName { get; set; }
        public int Duration { get; set; }
        public DateTime From { get; set; }
        public DateTime To { get; set; }

        public string PM { get; set; }

        public string QA { get; set; }

        public List<string> TechnicalLead
        {
            get
            {
                return this.ProjectRoleStaffs.Where(x => x.Role.RoleName == "TechnicalLead")
                .Select(x => x.Staff.StaffName)
                .ToList();
            }
        }

        public List<string> BA
        {
            get
            {
                return this.ProjectRoleStaffs.Where(x => x.Role.RoleName == "BA")
                .Select(x => x.Staff.StaffName)
                .ToList();
            }
        }

        public List<string> Developers
        {
            get
            {
                return this.ProjectRoleStaffs.Where(x => x.Role.RoleName == "Developers")
                .Select(x => x.Staff.StaffName)
                .ToList();
            }
        }

        public List<string> Testers
        {
            get
            {
                return this.ProjectRoleStaffs.Where(x => x.Role.RoleName == "Testers")
                .Select(x => x.Staff.StaffName)
                .ToList();
            }
        }

        public List<string> TechnicalConsultancy
        {
            get
            {
                return this.ProjectRoleStaffs.Where(x => x.Role.RoleName == "TechnicalConsultancy")
                .Select(x => x.Staff.StaffName)
                .ToList();
            }
        }

        public virtual List<ProjectRoleStaff> ProjectRoleStaffs { get; set; }
    }
}