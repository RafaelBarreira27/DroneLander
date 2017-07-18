using DroneLander.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DroneLander.PageModels
{
    public class HighScorePageModel: FreshMvvm.FreshBasePageModel
    {
        IScoreService _scoreService;

        public HighScorePageModel(IScoreService scoreService)
        {
            _scoreService = scoreService;
        }

        public override void Init(object initData)
        {
            ScoreList = _scoreService.GetScores();
            base.Init(initData);
        }

        public List<Models.HighScore> ScoreList { get; set; }

        protected override void ViewIsAppearing(object sender, EventArgs args)
        {
            base.ViewIsAppearing(sender, args);
        }
    }
}
