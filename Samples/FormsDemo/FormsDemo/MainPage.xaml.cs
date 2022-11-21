using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediaManager;
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
    }
}
