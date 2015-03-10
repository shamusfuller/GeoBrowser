using GeoBrowser.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace GeoBrowser.DesignTime
{
    public class MainPageViewModel: IMainPageViewModel
    {
        public string Title { get; set; }
        public Uri ViewerLocation { get; set; }

        public MainPageViewModel()
        {
            Title = "Hello Designtime!";
            ViewerLocation = new Uri("http://localhost:3443/geoBrowser.html");
        }
    }
}
