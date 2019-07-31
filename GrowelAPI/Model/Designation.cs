namespace GMSAPI.Model
{
    public class Designation
    {
        public int Id { get; set; }
        public string DesignationName { get; set; }

        public DepartmentInfo Dept { get; set; }
        public int DeptId { get; set; }

    }
}