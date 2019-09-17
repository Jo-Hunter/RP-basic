using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The User Control item template is documented at https://go.microsoft.com/fwlink/?LinkId=234236

namespace App2
{
    public sealed partial class MyUserControl1 : UserControl
    {
        public MyUserControl1()
        {
            this.InitializeComponent();
            Windows.UI.ViewManagement.ApplicationView.GetForCurrentView().VisibleBoundsChanged += MyUserControl1_VisibleBoundsChanged;
        }

        private void MyUserControl1_VisibleBoundsChanged(Windows.UI.ViewManagement.ApplicationView sensor, object args)
        {

            var Width = Windows.UI.ViewManagement.ApplicationView.GetForCurrentView().VisibleBounds.Width;
            if (Width >= 500)
            {
                RelativePanel.SetRightOf(boxtest, texttest);
                RelativePanel.SetBelow(testButon, texttest);


            }
            else
            {
                
                RelativePanel.SetRightOf(boxtest, texttest);
                RelativePanel.SetBelow(testButon, texttest);
                RelativePanel.SetAlignBottomWith(boxtest, texttest);
            }


        }
    }
}
