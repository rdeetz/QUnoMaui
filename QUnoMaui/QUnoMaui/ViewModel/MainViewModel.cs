// <copyright file="ViewModel.cs" company="Mooville">
//   Copyright © 2024 Roger Deetz. All rights reserved.
// </copyright>

namespace Mooville.QUno.Maui.ViewModel
{
    using Mooville.QUno.ViewModel;

    public class MainViewModel : ViewModelBase
    {
        private bool isGameInProgress;

        public MainViewModel()
        {
            this.isGameInProgress = false;
        }

        public bool IsGameInProgress
        {
            get
            {
                return this.isGameInProgress;
            }

            set
            {
                this.isGameInProgress = value;
                this.OnPropertyChanged(nameof(this.IsGameInProgress));
            }
        }
    }
}
