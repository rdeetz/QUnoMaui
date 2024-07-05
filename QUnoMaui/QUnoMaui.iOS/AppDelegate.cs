// <copyright file="AppDelegate.cs" company="Mooville">
//   Copyright � 2024 Roger Deetz. All rights reserved.
// </copyright>

namespace Mooville.QUno.Maui.iOS
{
    using Microsoft.Maui;
    using Microsoft.Maui.Hosting;
    using Foundation;

    [Register(nameof(AppDelegate))]
    public class AppDelegate : MauiUIApplicationDelegate
    {
        protected override MauiApp CreateMauiApp() => MauiProgram.CreateMauiApp();
    }
}
