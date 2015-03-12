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
        private INavigationService navigationService;
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
        public DelegateCommand NavigateToMaps { get; private set; }

        public MainPageViewModel(INavigationService navigationService)
        {
            this.navigationService = navigationService;
        }

        public override void OnNavigatedTo(object navigationParameter, Windows.UI.Xaml.Navigation.NavigationMode navigationMode, Dictionary<string, object> viewModelState)
        {
            // can init data here, do things we can't do in a constructor,
            // like IO bound async file read ops, etc
            this.Title = "Hello runtime!";
            this.viewerLocation = new Uri("http://localhost:3443/geoBrowser.html");
            //base.OnNavigatedTo(navigationParameter, navigationMode, viewModelState);

            NavigateToMaps = DelegateCommand.FromAsyncHandler(ToMaps, () => true); 

        }

        public async Task ToMaps()
        {
            navigationService.Navigate(Experiences.Maps.ToString(), null);
            await Task.FromResult<object>(null);
        }
    }
}
