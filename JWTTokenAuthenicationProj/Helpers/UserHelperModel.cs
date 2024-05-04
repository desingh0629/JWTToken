namespace JWTTokenAuthenicationProj.Helpers
{
    public class UserHelperModel
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }        
        public string UserMessage { get; set; }
        public string AccessToken { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
