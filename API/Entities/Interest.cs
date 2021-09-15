using System.ComponentModel.DataAnnotations.Schema;

namespace API.Entities
{
    [Table("UserInterests")]
    public class Interest
    {
        public int Id { get; set; }
        public string Interest1 { get; set; }
        public string Interest2 { get; set; }
        public string Interest3 { get; set; }
        public string Interest4 { get; set; }
        public string Interest5 { get; set; }
        public string Interest6 { get; set; }
        public string Interest7 { get; set; }
        public string Interest8 { get; set; }
        public string Interest9 { get; set; }
        public string Interest10 { get; set; }

        public AppUser AppUser { get; set; }
        public int AppUserId { get; set; }

    }
}