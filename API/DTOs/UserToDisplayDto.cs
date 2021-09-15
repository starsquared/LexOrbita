using System;
using System.Collections.Generic;

namespace API.DTOs
{
    public class UserToDisplayDto
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string PhotoUrl { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string ZipCode { get; set; }
        public string Phone { get; set; }
        public string AppUserType { get; set; }
        public DateTime Created { get; set; } 
        public DateTime LastActive { get; set; } 
        public string Introduction { get; set; }
        public ICollection<InterestDto> Interests { get; set; }
        public ICollection<PhotoDto> Photos { get; set; }

        public ICollection<LawyerDetailDto> LawyerDetails { get; set; }
    }
}