using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using System.Net.Http;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=391641

namespace App2
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();

            this.NavigationCacheMode = NavigationCacheMode.Required;

            

            for (int x = 0; x <= 5; x++)
            {
                Button bn = new Button();
                bn.Background = new SolidColorBrush(Color.FromArgb(255, 219, 219, 219));
                bn.Tag = x;
                bn.HorizontalAlignment = HorizontalAlignment.Stretch;
                bn.HorizontalContentAlignment = HorizontalAlignment.Left;
                Thickness margin = bn.Margin;
                margin.Left = 10;
                margin.Right = 10;
                margin.Top = -5;
                margin.Bottom = -5;
                bn.Margin = margin;
                bn.Height = 90;
                bn.Foreground = new SolidColorBrush(Color.FromArgb(255, 67, 67, 67));
                bn.Content = "Select me "+ x;
                bn.Click += (s, e) =>
                {
                    Button thes = (Button)s;
                    textBlock.Text = "Hi " + thes.Tag;
                    thes.Background = new SolidColorBrush(Color.FromArgb(255, 219, 219, 219));
                };
                Thickness th = new Thickness();
                th.Bottom = 0;
                th.Left = 0;
                th.Right = 0;
                th.Top = 0;
                bn.BorderThickness = th;
                
                spTerminalBox.Children.Add(bn);
                spTerminalBox.UpdateLayout();
            }
        }



        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.
        /// This parameter is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            // TODO: Prepare page for display here.

            // TODO: If your application contains multiple pages, ensure that you are
            // handling the hardware Back button by registering for the
            // Windows.Phone.UI.Input.HardwareButtons.BackPressed event.
            // If you are using the NavigationHelper provided by some templates,
            // this event is handled for you.
        }

        private void textBlock1_SelectionChanged(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button theButton = (Button)sender;
            textBlock.Text = "Hi " + theButton.Tag;
        }
    }
}
