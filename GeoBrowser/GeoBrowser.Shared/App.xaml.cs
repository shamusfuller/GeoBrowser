using Microsoft.Practices.Prism.Mvvm;
using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
using Windows.ApplicationModel;
using Windows.ApplicationModel.Activation;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Animation;
using Windows.UI.Xaml.Navigation;


namespace GeoBrowser
{
    public sealed partial class App : MvvmAppBase
    {
        private UnityContainer _container = new UnityContainer();

        public App()
        {
            this.InitializeComponent();
        }

        protected override object Resolve(Type type)
        {
            //return base.Resolve(type);
            return _container.Resolve(type);
        }

        protected override Task OnLaunchApplicationAsync(LaunchActivatedEventArgs arg)
        {
            this.NavigationService.Navigate(Experiences.Main.ToString(), null);
            return Task.FromResult<object>(null);
        }
        protected override Task OnInitializeAsync (IActivatedEventArgs args)
        {
            _container.RegisterInstance(NavigationService);
            return Task.FromResult<object>(null);
        }

        // .Register() does not exist?
        //protected override void OnInitialize(IActivatedEventArgs args)
        //{
        //    ViewModelLocationProvider.Register(typeof(MainPage),)
        //    ViewModelLocator.Register(typeof(StartPage).ToString(),
        //            () => new StartPageViewModel(FlyoutService));
        //}
    }
}