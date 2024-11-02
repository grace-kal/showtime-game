namespace ShowTime.Models
{
    public class Board
    {
        public int Id { get; set; }
        public int SizeX { get; set; } = 3;
        public int SizeY { get; set; } = 4;
        public int Points { get; set; }
        public List<Card> Cards { get; set; }
    }
}
