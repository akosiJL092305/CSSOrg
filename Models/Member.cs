namespace OrgAPI.Models
{
    public class Member
    {
        public int Id { get; set; }

        public int UserId { get; set; }  // links to login user

        public string Full_Name { get; set; }

        public string Address { get; set; }

        public string Contact { get; set; }
    }
}