using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using GMSAPI.Model;

namespace GMSAPI.DTO
{
    public class EmployeeForRegisterDTO
    {
        public int Id { get; set; }

        public string EmpCode { get; set; }

        public string  EmpName { get; set; }

        public int DesignationID { get; set; }
        public Designation Designation { get; set; }

        public int DepartmentID { get; set; }

        public DepartmentInfo Department { get; set; }
       
        public string DOB { get; set; }

         public string DOJ { get; set; }
         public string Email { get; set; }
        public string BloogGroup { get; set; }
        public string ImagePath { get; set; }
      

        public ICollection<ContactInfo> Contacts { get; set; }
        
        public int ReportingTo { get; set; }
        
        public int ShirtSize { get; set; }
        
        public int SegmentID { get; set; }
       
    
        public int HQID { get; set; }
       
    
        public int DistID { get; set; }
        
        public int StateID { get; set; }
        
        public int Pincode { get; set; }
        
        public int AadharID { get; set; }
        
        public int BankID { get; set; }
        
        public int PanID { get; set; }
        
        [Required]
        public string UserName { get; set; }
        
        [Required]
        [StringLength(12,MinimumLength=6,ErrorMessage="You must have password length between 6 to 8")]
        public string Password { get; set; }

    }
}