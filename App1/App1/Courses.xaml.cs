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
    public sealed partial class Courses : Page
    {
        public Courses()
        {

            this.InitializeComponent();
            txtBoxFooter.Text = BL_PageContent.CreatedBy;

        }

        //Back Button  
        private void button_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(CourseList), null);
        }
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {

            base.OnNavigatedTo(e);
            string course = e.Parameter as String;
            //if (NavigationContext.QueryString.ContainsKey("parameter"))


            if (course == "COP3488C")
            {

                //Output Course Name, Number, and Description
                BL_PageContent.COP3488();
                textBox1.Text = BL_PageContent.VarOutput;

            }
            if (course == "CTS3302")
            {
                BL_PageContent.CTS3302();
                textBox1.Text = BL_PageContent.VarOutput;


            }
            if (course == "CIS3917")
            {
                BL_PageContent.CIS3917();
                textBox1.Text = BL_PageContent.VarOutput;

            }
            if (course == "CIS3801")
            {
                BL_PageContent.CIS3801();
                textBox1.Text = BL_PageContent.VarOutput;

            }
            if (course == "CIS4655")
            {
                BL_PageContent.CIS4655();
                textBox1.Text = BL_PageContent.VarOutput;

            }
            if (course == "CDA3315")
            {
                BL_PageContent.CDA3315();
                textBox1.Text = BL_PageContent.VarOutput;

            }
            if (course == "CDA3428")
            {
                BL_PageContent.CDA3428();
                textBox1.Text = BL_PageContent.VarOutput;

            }
            if (course == "CTS4623")
            {
                BL_PageContent.CTS4623();
                textBox1.Text = BL_PageContent.VarOutput;

            }
            if (course == "CTS3265")
            {
                BL_PageContent.CTS3265();
                textBox1.Text = BL_PageContent.VarOutput;

            }
            if (course == "COP4474")
            {
                BL_PageContent.COP4474();
                textBox1.Text = BL_PageContent.VarOutput;

            }
            if (course == "COP4777")
            {
                BL_PageContent.COP4777();
                textBox1.Text = BL_PageContent.VarOutput;

            }
            if (course == "CIS4836")
            {
                BL_PageContent.CIS4836();
                textBox1.Text = BL_PageContent.VarOutput;

            }
            if (course == "CIS4793")
            {
                BL_PageContent.CIS4793();
                textBox1.Text = BL_PageContent.VarOutput;

            }
            if (course == "CTS4557")
            {
                BL_PageContent.CTS4557();
                textBox1.Text = BL_PageContent.VarOutput;

            }
            if (course == "MAN3504")
            {
                BL_PageContent.MAN3504();
                textBox1.Text = BL_PageContent.VarOutput;

            }
            if (course == "GEB3422")
            {
                BL_PageContent.GEB3422();
                textBox1.Text = BL_PageContent.VarOutput;

            }
            if (course == "CIS4910")
            {
                BL_PageContent.CIS4910();
                textBox1.Text = BL_PageContent.VarOutput;

            }
            if (course == "COP3362")
            {
                BL_PageContent.COP3362();
                textBox1.Text = BL_PageContent.VarOutput;

            }
            if (course == "COP4309")
            {
                BL_PageContent.COP4309();
                textBox1.Text = BL_PageContent.VarOutput;

            }
            if (course == "COP4683")
            {
                BL_PageContent.COP4683();
                textBox1.Text = BL_PageContent.VarOutput;

            }

        }
    }
}
