﻿using GeoBrowser.Interfaces;
using GeoBrowser.ViewModels;
using GeoBrowser.Views;
using Microsoft.Practices.Prism.Mvvm;
using Microsoft.Practices.Prism.Mvvm.Interfaces;
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
        //// using Unity 3.5.1405-prerelease for phone support
        //private UnityContainer _container = new UnityContainer();

        public App()
        {
            this.InitializeComponent();
        }

        protected override object Resolve(Type type)
        {
            //return _container.Resolve(type);
            return base.Resolve(type);
        }

        protected override Task OnLaunchApplicationAsync(LaunchActivatedEventArgs arg)
        {
            this.NavigationService.Navigate(Experiences.Main.ToString(), null);
            return Task.FromResult<object>(null);
        }
        protected override Task OnInitializeAsync (IActivatedEventArgs args)
        {
            //_container.RegisterInstance(NavigationService);
            //_container.RegisterInstance(new MainPageViewModel(NavigationService));
            return Task.FromResult<object>(null);
        }
    }
}