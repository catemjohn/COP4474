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
    public sealed partial class ProgramInfo : Page
    {
        public ProgramInfo()
        {
            this.InitializeComponent();
            txtBoxDegreeCredits.Text = "Total Bachelor's Degree Credits" + "\r\n" + "\r\n" + "Upper Division General Education Credits: 24" + "\r\n" + "\r\n" + "Upper Division Major and Core Credits: 66" +
                "\r\n" + "\r\n" + "Total Upper Division Credits: 90" + "\r\n"+ "\r\n" + "Total BS Degree Credits: 180" + "\r\n" + "\r\n" + "Rasmussen College Accreditation: " + "\r\n" +
                "Accredited by the Higher Learning Commission" + "\r\n" + "hlcommission.org" + "\r\n" + "Phone: 800-621-7440";

            txtBoxFooter.Text = BL_PageContent.CreatedBy;
        }
        private void buttonHome_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(MainPage), null);
        }

        
    }
}
