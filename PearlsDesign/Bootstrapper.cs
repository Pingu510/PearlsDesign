using System.Windows;
using Caliburn.Micro;
using PearlsDesign.ViewModels;

namespace PearlsDesign
{
    /// <summary>
    /// Application Starting point
    /// </summary>
    class Bootstrapper : BootstrapperBase
    {
        public Bootstrapper()
        {
            Initialize();
        }

        protected override void OnStartup(object sender, StartupEventArgs e)
        {
            DisplayRootViewFor<ShellViewModel>();
        }
    }
}
