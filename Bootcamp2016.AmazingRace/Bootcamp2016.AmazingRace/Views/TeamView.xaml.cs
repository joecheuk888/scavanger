using Bootcamp2016.AmazingRace.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Bootcamp2016.AmazingRace.Views
{

    public partial class TeamView : ContentPage

    {
        private IDataService dataService;
        public TeamView(IDataService ds)
        {
            this.dataService = ds;
            InitializeComponent();
        }

    }
}
