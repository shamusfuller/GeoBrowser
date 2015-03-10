using System;
using System.Collections.Generic;
using System.Text;

namespace GeoBrowser.Interfaces
{
    public interface IMainPageViewModel
    {
        string Title { get; set; }
        Uri ViewerLocation { get; set; }
    }
}
