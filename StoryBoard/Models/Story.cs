namespace StoryBoard.Models
{
    public class Story
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public string Title { get; set; }
        public string Description { get; set; }
        public string Content { get; set; }

        public string UserId { get; set; }
        public User User { get; set; }
    }
}
