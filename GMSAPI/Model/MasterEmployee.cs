using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace GMSAPI.Model
{
    public class MasterEmployee
    {
        public int Id { get; set; }

        public string EmpCode { get; set; }

        public string  EmpName { get; set; }

        

        
        public int ReportingTo { get; set; }

        
        public ICollection<ContactInfo> Contacts { get; set; }

    
        public int Pincode { get; set; }
        public string Email { get; set; }
        public string DOJ { get; set; }
        public string DOB { get; set; }
        public string BloogGroup { get; set; }
        public string ImagePath { get; set; }
        
        
        public int ShirtSize { get; set; }

        
        
        public virtual DepartmentInfo DepartmentInfo { get; set; }
        public int DeptID { get; set; }

        
        public virtual Designation Designation { get; set; }
        public int DesignationID { get; set; }
        
        
        public virtual SegmentDetail Segment { get; set; }
        public int SegmentID { get; set; }
        
        
        public virtual HeadQuatersDetail HQ { get; set; }
        public int HQID { get; set; }
        
        
        public virtual DistrictDetail District { get; set; }
        public int DistID { get; set; }

        
        public virtual StateDetail State { get; set; }
        public int StateID { get; set; }

        
        public virtual AadharDetail Aadhar { get; set; }
        public int AadharID { get; set; }

        
        public virtual BankDetail Bank { get; set; }
        public int BankID { get; set; }

        
        public virtual PanCardDetail Pan { get; set; }
        public int PanID { get; set; }
        




        

    }
}