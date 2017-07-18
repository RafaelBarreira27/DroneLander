using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DroneLander.Models;

namespace DroneLander.Services
{
    class ScoreService : IScoreService
    {
        public string Username { get; set; }
        public List<Models.HighScore> HighScores { get; set; } = new List<HighScore>
            {
                new HighScore("ze", "9.0"),
                new HighScore ("ze", "12.0")
            };

        public List<HighScore> GetScores()
        {
            return HighScores.OrderBy(o =>(Convert.ToDouble(o.Score))).Reverse().ToList();
        }

        public void UpdateScore(HighScore score)
        {
            if (HighScores.Count < 10)
            {
                HighScores.Add(score);
            }
            else
            {
                foreach (HighScore s in HighScores)
                {
                    if(Convert.ToInt32(s.Score) < Convert.ToInt32(score.Score))
                    {
                        HighScores.Remove(s);
                        HighScores.Add(score);
                    }
                }
            }
        }
    }
}
