using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Entities
{
    [Table("LawyerDetails")]
    public class LawyerDetail
    {
        public int Id { get; set; }
        public string LawCollegeStudiedIn { get; set; }
        public DateTime DateLawDegreeObtained { get; set; }
        public string BarCouncilRegisteredAt { get; set; }
        public string CorporateExperience { get; set; }
         public string LawFirmExperience { get; set; }
         public string IndependentPracticeExperience { get; set; }
        public string IdentityCardUrl { get; set; }
        public string BarCouncilRegistrationUrl { get; set; }
        public string PublicId { get; set; }
        public AppUser AppUser { get; set; }
        public int AppUserId { get; set; }
    }
}