// <copyright file="Main.cs" company="Mooville">
//   Copyright © 2024 Roger Deetz. All rights reserved.
// </copyright>

namespace Mooville.QUno.Maui.iOS
{
    using ObjCRuntime;
    using UIKit;

    public class Program
    {
        static void Main(string[] args)
        {
            UIApplication.Main(args, null, typeof(AppDelegate));

            return;
        }
    }
}
