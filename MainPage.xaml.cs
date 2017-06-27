using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Collections.Specialized;
using System.Net;
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
using System.Net.Http;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace T109
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private void sendPost(string path, string setTo)
        {
            var client = new HttpClient();

            var pairs = new List<KeyValuePair<string, string>>
                {
                new KeyValuePair<string, string>("value", setTo),
                };

            var content = new FormUrlEncodedContent(pairs);

            var response = client.PostAsync(path, content).Result;

            if (response.IsSuccessStatusCode)
            {


            }
        }
    public MainPage()
        {
            this.InitializeComponent();
        }

        private void ToggleSwitchT_OnToggled1(object sender, RoutedEventArgs e)
        {
            var toggleSwitch = sender as ToggleSwitch;
            if (toggleSwitch == null) return;

            if (toggleSwitch.IsOn)
            {
                sendPost("http://www.sklenarstvohrinova.sk/test/babett/button1.php", "1");
            }
            else
            {
                sendPost("http://www.sklenarstvohrinova.sk/test/babett/button1.php", "0");
            }
        }

        private void ToggleSwitchT_OnToggled2(object sender, RoutedEventArgs e)
        {
            var toggleSwitch = sender as ToggleSwitch;
            if (toggleSwitch == null) return;

            if (toggleSwitch.IsOn)
            {
                sendPost("http://www.sklenarstvohrinova.sk/test/babett/button2.php", "1");
            }
            else
            {
                sendPost("http://www.sklenarstvohrinova.sk/test/babett/button2.php", "0");
            }
        }

        private void ToggleSwitchT_OnToggled3(object sender, RoutedEventArgs e)
        {
            var toggleSwitch = sender as ToggleSwitch;
            if (toggleSwitch == null) return;

            if (toggleSwitch.IsOn)
            {
                sendPost("http://www.sklenarstvohrinova.sk/test/babett/button3.php", "1");
            }
            else
            {
                sendPost("http://www.sklenarstvohrinova.sk/test/babett/button3.php", "0");
            }
        }

        private void ToggleSwitchT_OnToggled4(object sender, RoutedEventArgs e)
        {
            var toggleSwitch = sender as ToggleSwitch;
            if (toggleSwitch == null) return;

            if (toggleSwitch.IsOn)
            {
                sendPost("http://www.sklenarstvohrinova.sk/test/babett/button4.php", "1");
            }
            else
            {
                sendPost("http://www.sklenarstvohrinova.sk/test/babett/button4.php", "0");
            }
        }




    }
}
