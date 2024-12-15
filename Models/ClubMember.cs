namespace Member_Registration_Demo_Project.Models
{
    public class ClubMember
    {
        public Guid Id { get; set; }

        public string MemberName { get; set; }

        public Guid SocietyId { get; set; }

        public int Gender { get;set; }

        public int MembershipCategory { get; set; }

        public Guid HobbiesId { get; set; }

        public string Remark { get;set; }

        public bool IsActive { get; set; }
    }
}
