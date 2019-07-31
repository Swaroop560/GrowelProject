using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace GMSAPI.Model
{
    public class MasterEmployee
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
        public  SegmentDetail Segment { get; set; }
        
        
        public int HQID { get; set; }
        public HeadQuatersDetail HQ { get; set; }
        
        
        public int DistID { get; set; }
        public DistrictDetail District { get; set; }
        

        public int StateID { get; set; }
        public StateDetail State { get; set; }

        public int Pincode { get; set; }
        

        public int AadharID { get; set; }
        public AadharDetail Aadhar { get; set; }
        

        public int BankID { get; set; }
        public BankDetail Bank { get; set; }
        

        public int PanID { get; set; }
        public PanCardDetail Pan { get; set; }

        public string UserName { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
        
        
    

    }
}