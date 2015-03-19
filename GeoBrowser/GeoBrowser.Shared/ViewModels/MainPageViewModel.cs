using GeoBrowser.Interfaces;
using Microsoft.Practices.Prism.Commands;
using Microsoft.Practices.Prism.Mvvm;
using Microsoft.Practices.Prism.Mvvm.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GeoBrowser.ViewModels
{
    public class MainPageViewModel : ViewModel, IMainPageViewModel
    {
        private string title = default(string);
        private Uri viewerLocation = default(Uri);
        //private INavigationService navigationService;
        public string Title
        {
            get
            {
                return title;
            }
            set
            {
                SetProperty(ref title, value);
            }
        }
        public Uri ViewerLocation
        {
            get
            {
                return viewerLocation;
            }
            set
            {
                SetProperty(ref viewerLocation, value);
            }
        }
        public DelegateCommand OpenMap { get; set; }

        public MainPageViewModel()//(INavigationService navigationService)
        {
            //this.navigationService = navigationService;
            OpenMap = DelegateCommand.FromAsyncHandler(SendOpenMap, () => true);
            ////this gets called everytime, perhaps make it a singleton?
            // it was, now it'snot?
            this.viewerLocation = new Uri("http://localhost:3443/geoBrowser.html");
        }

        public override void OnNavigatedTo(object navigationParameter, Windows.UI.Xaml.Navigation.NavigationMode navigationMode, Dictionary<string, object> viewModelState)
        {
            // can init data here, do things we can't do in a constructor,
            // like IO bound async file read ops, etc
            this.Title = "Hello runtime!"; // ToDo: remove this
            //if (navigationParameter != null || navigationParameter == Experiences.Maps.ToString())
            //{
            //    // concept was flawed, use MapSignalR to load from here, literally.
            //    // can run progress, etc
            //    // maybe use map key on return, or null for null op, at which point rebind to extents/etc
            //    // don't want any refresh, need null op, may still have to prevent <viewer> instantiation
            //    // should never need to know about <viewer>
            //    // in short, if nothing else, never nav from, merely signal from navTo view to update map
            //    //this.viewerLocation = new Uri("http://localhost:3443/cesium.html");
            //}
            ////this.viewerLocation = new Uri("http://localhost:3443/geoBrowser.html");
        }

        public async Task SendOpenMap()
        {
            await Task.FromResult<object>(null);
        }
    }
}
