using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoGame
{
    public class Game
    {
     public string GameId { get; set; } 

     public string Title { get; set; }

     public string Genre { get; set; }

     public int ReleaseYear { get; set; }

     public bool IsAvailable { get; set; }

     public decimal PricePerDay { get; set; }

     public Game(string gameId, string title, string genre, int releaseYear, bool isAvailable, decimal pricePerDay)
        {
            GameId = gameId;
            Title = title;
            Genre = genre;
            ReleaseYear = releaseYear;
            IsAvailable = isAvailable;
            PricePerDay = pricePerDay;
        }
        public override string? ToString()
        {
            return $"GameID: {GameID}, Title: {Title}, Genre: {Genre}, Release Year: {ReleaseYear}, " + $"Available: {IsAvailable}, Price/Day:{PricePerDay}";
        }
    }

}
