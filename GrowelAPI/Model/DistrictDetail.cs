using System.ComponentModel.DataAnnotations.Schema;

namespace GMSAPI.Model
{
    public class DistrictDetail
    {
        public int Id { get; set; }
        public string DistrictName { get; set; }
        public int StateID { get; set; }

        [ForeignKey("StateID")]
        public StateDetail State { get; set; }
    }
}

