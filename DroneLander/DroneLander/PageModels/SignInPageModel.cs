using DroneLander.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace DroneLander.PageModels
{
    public class SignInPageModel : FreshMvvm.FreshBasePageModel
    {
        IScoreService _scoreService;

        public SignInPageModel(IScoreService scoreService) : base ()
        {
            _scoreService = scoreService;
        }

        public override void Init(object initData)
        {
            base.Init(initData);
        }

        protected override void ViewIsAppearing(object sender, EventArgs args)
        {
            base.ViewIsAppearing(sender, args);
        }

        public string Username { get; set; }

        public Command AcTualSignInCommand
        {
            get
            {
                return new Command(() =>
                {
                    _scoreService.Username = Username;
                    //CoreMethods.PushPageModel<PageModels.MainPageModel>();
                    CoreMethods.PopPageModel("true");
                });
            }
        }
    }
}
