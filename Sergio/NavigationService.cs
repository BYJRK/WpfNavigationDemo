using Sergio.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace Sergio
{
    public class NavigationService
    {
        private readonly Frame? mainFrame;

        public NavigationService(Frame frame)
        {
            mainFrame = frame;
            mainFrame.LoadCompleted += MainFrame_LoadCompleted;
        }

        private void MainFrame_LoadCompleted(object sender, NavigationEventArgs e)
        {
            if (e.ExtraData is not Dictionary<string, object?> extraData)
                return;

            if ((mainFrame?.Content as FrameworkElement)?.DataContext is not ViewModelBase vm)
                return;

            foreach (var item in extraData)
            {
                vm.GetType().GetProperty(item.Key)?.SetValue(vm, item.Value);
            }
        }

        private readonly Dictionary<Type, Type> mapping =
            new()
            {
                [typeof(LoginViewModel)] = typeof(Login),
                [typeof(HomeViewModel)] = typeof(Home)
            };

        private Type? FindView<VM>()
        {
            return Assembly
                .GetAssembly(typeof(VM))
                ?.GetTypes()
                .FirstOrDefault(t => t.Name == typeof(VM).Name.Replace("ViewModel", ""));
        }

        public void Navigate<VM>()
            where VM : ViewModelBase
        {
            Navigate<VM>(null);
        }

        public void Navigate<VM>(Dictionary<string, object?>? extraData)
            where VM : ViewModelBase
        {
            var viewType = FindView<VM>();
            if (viewType is null)
                return;

            var page = App.Current.Services.GetService(viewType) as Page;
            mainFrame?.Navigate(page, extraData);
        }
    }
}
