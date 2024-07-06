// <copyright file="MainPage.xaml.cs" company="Mooville">
//   Copyright © 2024 Roger Deetz. All rights reserved.
// </copyright>

namespace Mooville.QUno.Maui
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            this.InitializeComponent();
            this.buttonCounter.Clicked += this.buttonCounter_Clicked;
        }

        private void buttonCounter_Clicked(object? sender, EventArgs e)
        {
            this.count++;

            if (count == 1)
            {
                this.buttonCounter.Text = $"Clicked {count} time";
            }
            else
            {
                this.buttonCounter.Text = $"Clicked {count} times";
            }

            SemanticScreenReader.Announce(buttonCounter.Text);

            return;
        }
    }

}
