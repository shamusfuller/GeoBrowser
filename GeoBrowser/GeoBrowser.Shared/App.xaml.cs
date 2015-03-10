using Microsoft.Practices.Prism.Mvvm;
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
        
        public App()
        {
            this.InitializeComponent();
        }

        protected override object Resolve(Type type)
        {
            return base.Resolve(type);
        }

        protected override Task OnLaunchApplicationAsync(LaunchActivatedEventArgs arg)
        {
            this.NavigationService.Navigate(Experiences.Main.ToString(), null);
            return Task.FromResult<object>(null);
        }
    }
}