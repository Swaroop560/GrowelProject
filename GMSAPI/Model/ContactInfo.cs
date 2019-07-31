namespace GMSAPI.Model
{
    public class ContactInfo
    {
       public int Id { get; set; }
       public string ContactNo { get; set; }
       
       public MasterEmployee MasterEmployee { get; set; }
       public int EmpID { get; set; }
       
    }
}