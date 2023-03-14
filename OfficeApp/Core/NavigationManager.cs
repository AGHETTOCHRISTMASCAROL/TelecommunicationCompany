using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace OfficeApp.Core
{
    internal static class NavigationManager
    {
        private static Frame _currentFrame;

        public static Frame CurrentFrame
        {
            get { return _currentFrame; }
            set { _currentFrame = value; }
        }

        public static void Navigation(Page page)
        {
            if (CurrentFrame != null)
            {
                CurrentFrame.Navigate(page);
            }
        }
    }
}
