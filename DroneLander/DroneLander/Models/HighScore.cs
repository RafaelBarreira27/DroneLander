using DroneLander.Common;
using PropertyChanged;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DroneLander.Models
{
    [AddINotifyPropertyChangedInterface]
    public class HighScore
    {
        public HighScore(string n, string s)
        {
            Name = n;
            Score = s;
        }
        public string Score { get; set; }
        public string Name { get; set; }
    }     
}