using Bouken_sha.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bouken_sha.Utils
{
    public sealed class PageRepository
    {
        private PageRepository()
        {
            _pages = new Dictionary<string, Type>();
            _pages.Add(nameof(HomePage), typeof(HomePage));
            _pages.Add(nameof(LibraryPage), typeof(LibraryPage));
            _pages.Add(nameof(BackupRestorePage), typeof(BackupRestorePage));
            _pages.Add(nameof(DownloadPage), typeof(DownloadPage));
            _pages.Add(nameof(ExtensionPage), typeof(ExtensionPage));
            _pages.Add(nameof(HistoryPage), typeof(ExtensionPage));
            _pages.Add(nameof(NewsUpdatePage), typeof(ExtensionPage));
            _pages.Add(nameof(SettingPage), typeof(SettingPage));
        }
        private static PageRepository _instance = null;
        public static PageRepository Instance
        {
            get { return _instance ?? (_instance = new PageRepository()); }
        }
        private Dictionary<string, Type> _pages;
        public Type GetPage(string identifier) 
        { 
            if (_pages.TryGetValue(identifier, out var page))
                return _pages[identifier];  
            return null;
        }
    }
}
