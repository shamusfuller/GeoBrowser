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
    public class MapsPageViewModel : ViewModel, IMapsPageViewModel
    {
        private INavigationService navigationService;

        public string title = default(string);
        public DelegateCommand GoBack { get; private set; }


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

        public MapsPageViewModel(INavigationService navigationService)
        {
            this.navigationService = navigationService;
        }

        public override void OnNavigatedTo(object navigationParameter, Windows.UI.Xaml.Navigation.NavigationMode navigationMode, Dictionary<string, object> viewModelState)
        {
            // can init data here, do things we can't do in a constructor,
            // like IO bound async file read ops, etc
            this.Title = "Maps";
            //base.OnNavigatedTo(navigationParameter, navigationMode, viewModelState);
            GoBack = DelegateCommand.FromAsyncHandler(ToMain, () => true);

        }

        public async Task ToMain()
        {
            //navigationService.GoBack();
            navigationService.Navigate(Experiences.Main.ToString(), Experiences.Maps);
            await Task.FromResult<object>(null);
        }
    }
}
