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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace App1
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class CourseList : Page
    {
        public CourseList()
        {
            this.InitializeComponent();
            txtBoxFooter.Text = BL_PageContent.CreatedBy;
        }
        //variable used to determine which course was selected
        string parameter;
        private void btnCOP3488_Click(object sender, RoutedEventArgs e)
        {
            parameter = "COP3488C";
            Frame.Navigate(typeof(Courses), parameter);


        }
        private void btnCTS3302_Click(object sender, RoutedEventArgs e)
        {
            parameter = "CTS3302";
            Frame.Navigate(typeof(Courses), parameter);

        }
        private void btnCIS3917_Click(object sender, RoutedEventArgs e)
        {
            parameter = "CIS3917";
            Frame.Navigate(typeof(Courses), parameter);

        }
        

        private void buttonHome_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(MainPage), null);
        }

        private void btnCIS3801_Click(object sender, RoutedEventArgs e)
        {
            parameter = "CIS3801";
            Frame.Navigate(typeof(Courses), parameter);
        }
        private void btnCIS4655_Click(object sender, RoutedEventArgs e)
        {
            parameter = "CIS4655";
            Frame.Navigate(typeof(Courses), parameter);
        }

        private void btnCDA3315_Click(object sender, RoutedEventArgs e)
        {
            parameter = "CDA3315";
            Frame.Navigate(typeof(Courses), parameter);
        }

        private void btnCDA3428_Click(object sender, RoutedEventArgs e)
        {
            parameter = "CDA3428";
            Frame.Navigate(typeof(Courses), parameter);
        }

        private void btnCTS4623_Click(object sender, RoutedEventArgs e)
        {
            parameter = "CTS4623";
            Frame.Navigate(typeof(Courses), parameter);
        }

        private void btnCTS3265_Click(object sender, RoutedEventArgs e)
        {
            parameter = "CTS3265";
            Frame.Navigate(typeof(Courses), parameter);
        }

        private void btnCOP4474_Click(object sender, RoutedEventArgs e)
        {
            parameter = "COP4474";
            Frame.Navigate(typeof(Courses), parameter);
        }

        private void btnCOP4777_Click(object sender, RoutedEventArgs e)
        {
            parameter = "COP4777";
            Frame.Navigate(typeof(Courses), parameter);
        }

        private void btnCIS4836_Click(object sender, RoutedEventArgs e)
        {
            parameter = "CIS4836";
            Frame.Navigate(typeof(Courses), parameter);
        }

        private void btnCIS4793_Click(object sender, RoutedEventArgs e)
        {
            parameter = "CIS4793";
            Frame.Navigate(typeof(Courses), parameter);
        }

        private void btnCTS4557_Click(object sender, RoutedEventArgs e)
        {
            parameter = "CTS4557";
            Frame.Navigate(typeof(Courses), parameter);
        }

        private void btnMAN3504_Click(object sender, RoutedEventArgs e)
        {
            parameter = "MAN3504";
            Frame.Navigate(typeof(Courses), parameter);
        }

        private void btnGEB3422_Click(object sender, RoutedEventArgs e)
        {
            parameter = "GEB3422";
            Frame.Navigate(typeof(Courses), parameter);
        }

        private void btnCIS4910_Click(object sender, RoutedEventArgs e)
        {
            parameter = "CIS4910";
            Frame.Navigate(typeof(Courses), parameter);
        }

        private void btnCOP3362_Click(object sender, RoutedEventArgs e)
        {
            parameter = "COP3362";
            Frame.Navigate(typeof(Courses), parameter);
        }

        private void btnCOP4309_Click(object sender, RoutedEventArgs e)
        {
            parameter = "COP4309";
            Frame.Navigate(typeof(Courses), parameter);
        }

        private void btnCOP4683_Click(object sender, RoutedEventArgs e)
        {
            parameter = "COP4683";
            Frame.Navigate(typeof(Courses), parameter);
        }
    }
}
