﻿// <copyright file="MauiProgram.cs" company="Mooville">
//   Copyright © 2024 Roger Deetz. All rights reserved.
// </copyright>

namespace Mooville.QUno.Maui.iOS
{
    using Microsoft.Maui.Hosting;
    
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder.UseSharedMauiApp();

            return builder.Build();
        }
    }
}
