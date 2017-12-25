using Prism.Unity;
using Xamarin.Forms;
using Xamarin_Strcuture.Views.Screens;

namespace Xamarin_Strcuture
{
    public partial class App : PrismApplication
    {

        public App(IPlatformInitializer initializer = null) : base(initializer) { }

        protected override void OnInitialized()
        {
            InitializeComponent();
            NavigationService.NavigateAsync("login");
        }

        protected override void RegisterTypes()
        {
            Container.RegisterTypeForNavigation<LoginSreen>("login");
        }
    }
}
