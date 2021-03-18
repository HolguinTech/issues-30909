using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SignalRWithXamarin {
    public partial class MainPage : ContentPage {
        public MainPage() {
            InitializeComponent();

            var signalR = new SignalR.SignalRXamarinTest();
            var task = Task.Run(async () => await signalR.InitializeAsync());
            task.Wait();
        }
    }
}
