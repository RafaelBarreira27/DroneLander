using DroneLander.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DroneLander.Services
{
    public interface IScoreService
    {
        string Username { get; set; }
        List<Models.HighScore> HighScores { get; set; }
        List<DroneLander.Models.HighScore> GetScores();
        void UpdateScore(HighScore s);
    }
}
