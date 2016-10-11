﻿using Ignition.Foundation.Core.Mvc;

namespace Ignition.Project.IgnitionDemo.Sc.Components.About
{
    public class AboutPeopleTileAgent : Agent<AboutPeopleTileViewModel>
    {
        public override void PopulateModel()
        {
            var ds = Datasource as IAboutPeopleTile;

            if (ds == null) return;

            ViewModel.Heading = ds;
            ViewModel.Subtitle = ds;
            ViewModel.Image = ds;
            ViewModel.FacebookLink = ds;
            ViewModel.GitHubLink = ds;
            ViewModel.TumblrLink = ds;
        }
    }
}