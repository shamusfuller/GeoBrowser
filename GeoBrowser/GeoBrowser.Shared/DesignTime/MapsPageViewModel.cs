using GeoBrowser.Interfaces;
using Microsoft.Practices.Prism.Commands;
using System;
using System.Collections.Generic;
using System.Text;

namespace GeoBrowser.DesignTime
{
    public class MapsPageViewModel : IMapsPageViewModel
    {
        public string Title { get; set; }
        public MapsPageViewModel()
        {
            Title = "Maps";
        }


        //public DelegateCommand GoBack { get; set; }
    }
}
