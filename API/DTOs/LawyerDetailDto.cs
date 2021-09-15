using System;

namespace API.DTOs
{
    public class LawyerDetailDto
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

    }
}