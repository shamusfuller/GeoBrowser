using Microsoft.Practices.Prism.Commands;
using System;
using System.Collections.Generic;
using System.Text;

namespace GeoBrowser.Interfaces
{
    public interface IMapsPageViewModel
    {
        string Title { get; set; }
        //DelegateCommand GoBack { get; private set; }
    }
}
