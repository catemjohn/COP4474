﻿using System;
using System.Diagnostics;
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
    
    public sealed partial class Faculty : Page
    {
        public Faculty()
        {
            this.InitializeComponent();
            txtBoxFooter.Text = BL_PageContent.CreatedBy;
        }
        private void buttonHome_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(MainPage), null);
        }

        
    }
}
