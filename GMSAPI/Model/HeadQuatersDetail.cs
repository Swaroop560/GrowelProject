using System.ComponentModel.DataAnnotations.Schema;

namespace GMSAPI.Model
{
    public class HeadQuatersDetail
    {
        public int Id { get; set; }
        public string HeadQuatersName { get; set; }

        public int SegmentID { get; set; }

        public int DistrictID { get; set; }

        [ForeignKey("SegmentID")]
        public SegmentDetail Segment { get; set; }

        [ForeignKey("DistrictID")]
        public DistrictDetail District { get; set; }
        

    }
}

