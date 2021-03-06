using GMSAPI.Model;
using Microsoft.EntityFrameworkCore;

namespace GMSAPI.DataContext
{
    public class EmployeeContext : DbContext
    {
        public EmployeeContext(DbContextOptions<EmployeeContext> options) : base(options)
        {
            
        }
      
        public DbSet<EmployeeRoot> EmployeeRoots { get; set; }

        public DbSet<Department> Departments { get; set; }

        public DbSet<MasterEmployee> MasterEmployees { get; set; }

        
        public DbSet<DepartmentInfo> DepartmentInfos { get; set; }

        public DbSet<AadharDetail> AadharDetails { get; set; }
        
        public DbSet<BankDetail> BankDetails { get; set; }
        public DbSet<PanCardDetail> PanCardDetails { get; set; }
        public DbSet<PassPortDetail> PassPortDetails { get; set; }
        public DbSet<SegmentDetail> SegmentDetails { get; set; }
        public DbSet<StateDetail> StateDetails { get; set; }

        public DbSet<DistrictDetail> DistrictDetails { get; set; }

        public DbSet<ContactInfo> ContactInfos { get; set; }

        public DbSet<Designation> Designations { get; set; }

        public DbSet<HeadQuatersDetail> HeadQuatersDetails { get; set; }


        

    }
}

