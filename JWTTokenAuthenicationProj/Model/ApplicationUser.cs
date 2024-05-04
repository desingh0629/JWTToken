namespace JWTTokenAuthenicationProj.Model
{
    public class ApplicationUser
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string EMailId { get; set; }
        public string Password { get; set; }
        public DateTime CreatedDate { get; set; }
        public string Designation { get; set; }
    }
}
