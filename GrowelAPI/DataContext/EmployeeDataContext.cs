using GMSAPI.Model;
using GrowelAPI.Model;
using Microsoft.EntityFrameworkCore;

namespace GrowelAPI.DataContext
{
    public class EmployeeDataContext : DbContext
    {
        public EmployeeDataContext(DbContextOptions<EmployeeDataContext> options): base(options)
        {
            
        }

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

        public DbSet<MasterEmployee> MasterEmployees { get; set; }

        public DbSet<Login> Logins { get; set; }
        

    }
}