namespace ShowTime.Models
{
    public class Card
    {
        public int Id { get; set; }
        public bool IsOpen { get; set; } = false;
        public bool IsDone { get; set; } = false;
        public string ImageUrl { get; set; }
    }
}
