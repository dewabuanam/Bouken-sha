using Bouken_sha.Utils;
using Bouken_sha.View;
using System;
using Windows.ApplicationModel.Core;
using Windows.UI;
using Windows.UI.ViewManagement;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace Bouken_sha
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class AppShell : Page
    {
        public AppShell()
        {
            this.InitializeComponent();

            Loaded += (sender, args) =>
            {
                NavView.SelectedItem = HomePage;
            };

            // Set up custom title bar.
            var coreTitleBar = CoreApplication.GetCurrentView().TitleBar;
            coreTitleBar.ExtendViewIntoTitleBar = true;
            // Set XAML element as a draggable region.
            Window.Current.SetTitleBar(AppTitleBar);

            var titleBar = ApplicationView.GetForCurrentView().TitleBar;
            titleBar.ButtonBackgroundColor = Colors.Transparent;
            titleBar.ButtonInactiveBackgroundColor = Colors.Transparent;
            titleBar.ButtonForegroundColor = Colors.Black;
            AppTitle.Text = Windows.ApplicationModel.Package.Current.DisplayName;
        }
        public Frame AppFrame => frame;

        private void NavigationView_ItemInvoked(Microsoft.UI.Xaml.Controls.NavigationView sender, Microsoft.UI.Xaml.Controls.NavigationViewItemInvokedEventArgs args)
        {
            string id = args.InvokedItemContainer.Name;
            Type pageType;
            if (args.IsSettingsInvoked)
                pageType = PageRepository.Instance.GetPage("SettingPage");
            else
                pageType = PageRepository.Instance.GetPage(id);
            if (pageType == null || pageType == AppFrame.CurrentSourcePageType)
                return;
            AppFrame.Navigate(pageType);
        }

        private void NavigationView_BackRequested(Microsoft.UI.Xaml.Controls.NavigationView sender, Microsoft.UI.Xaml.Controls.NavigationViewBackRequestedEventArgs args)
        {
            if (AppFrame.CanGoBack)
            {
                AppFrame.GoBack();
            }
        }

        private void OnNavigatingToPage(object sender, Windows.UI.Xaml.Navigation.NavigatingCancelEventArgs e)
        {
            if (e.NavigationMode == NavigationMode.Back)
            {
                if (e.SourcePageType == typeof(HomePage))
                {
                    NavView.SelectedItem = HomePage;
                }
                else if (e.SourcePageType == typeof(LibraryPage))
                {
                    NavView.SelectedItem = LibraryPage;
                }
            }
        }
    }
}
