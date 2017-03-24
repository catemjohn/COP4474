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
using Windows.UI.Popups;


// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace App1
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
           // textBoxTitle.TextAlignment = TextAlignment.Center;

            BL_PageContent.CreatedBy = "Created By: Catherine Solganik";
            txtBoxFooter.Text = BL_PageContent.CreatedBy;




        }
        //Button link to the courses page
        private void buttonCourses_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(CourseList), null);
        }
        //Button link to the faculty information page
        private void buttonFaculty_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Faculty), null);
        }
        //Button link to the Program Information Page
        private void buttonProgram_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(ProgramInfo), null);
        }
        //Button Link to the module 4 page
        private void buttonModule4_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Module4), null);
        }
        //Button Link to the User auth page
        private void buttonUserAuth_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(UserAuth), null);
        }

    }
}