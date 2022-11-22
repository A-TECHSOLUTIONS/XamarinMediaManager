using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediaManager;
using MediaManager.Forms;
using Xamarin.Forms;

namespace FormsDemo
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void PlayClicked(object sender, EventArgs e)
        {
            try
            {
                await CrossMediaManager.Current.Play("https://samplelib.com/lib/preview/mp3/sample-3s.mp3");
            } 
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private void PlayVideo_Clicked(object sender, EventArgs e)
        {
            try
            {
                CrossMediaManager.Current.Play("http://clips.vorwaerts-gmbh.de/big_buck_bunny.mp4");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}
