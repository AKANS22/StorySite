namespace StoryBoard.Models
{
    public class User
    {
       public string Id { get; set; } = Guid.NewGuid().ToString();
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public List<Story> Stories { get; set; }
    }
}
