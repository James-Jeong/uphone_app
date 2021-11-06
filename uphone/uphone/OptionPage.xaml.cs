using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace uphone
{
    public partial class OptionPage : ContentPage
    {
        public OptionPage()
        {
            InitializeComponent();

            ///////////////////////////////////////////////

            Label clientModeLabel = new Label
            {
                Text = "ClientMode"
            };
            Switch clientModeSwitch = new Switch { OnColor = Color.Orange, ThumbColor = Color.Green };
            clientModeSwitch.Toggled += (sender, e) =>
            {

            };

            Label proxyUseLabel = new Label
            {
                Text = "UseProxy"
            };
            Switch proxyUseSwitch = new Switch { OnColor = Color.Orange, ThumbColor = Color.Green };
            proxyUseSwitch.Toggled += (sender, e) =>
            {

            };

            Label proxyModeLabel = new Label
            {
                Text = "ProxyMode"
            };
            Switch proxyModeSwitch = new Switch { OnColor = Color.Orange, ThumbColor = Color.Green };
            proxyModeSwitch.Toggled += (sender, e) =>
            {

            };

            Label autoAcceptLabel = new Label
            {
                Text = "Auto-Accept"
            };
            Switch autoAcceptSwitch = new Switch { OnColor = Color.Orange, ThumbColor = Color.Green };
            autoAcceptSwitch.Toggled += (sender, e) =>
            {

            };

            Label hostNameLabel = new Label
            {
                Text = "Host-Name"
            };
            Editor hostNameEditor = new Editor
            {

            };

            Label fromSipIpLabel = new Label
            {
                Text = "From-SIP-IP"
            };
            Editor fromSipIpEditor = new Editor
            {

            };

            Label fromSipPortLabel = new Label
            {
                Text = "From-SIP-Port"
            };
            Editor fromSipPortEditor = new Editor
            {

            };

            Label recordPathLabel = new Label
            {
                Text = "Record-Path"
            };
            Editor recordPathEditor = new Editor
            {
                
            };

            Label audioCodecPickerLabel = new Label
            {
                Text = "Audio-Codec"
            };
            var codecList = new List<string>();
            codecList.Add("ALAW");
            codecList.Add("ULAW");
            codecList.Add("AMR-NB");
            codecList.Add("AMR-WB");
            codecList.Add("EVS");

            var audioCodecPicker = new Picker
            {
                Title = "Select a codec",
                TitleColor = Color.Red,
                VerticalOptions = LayoutOptions.CenterAndExpand
            };
            audioCodecPicker.ItemsSource = codecList;

            foreach (string codecName in codecList) {
                audioCodecPicker.Items.Add(codecName);
            }

            BoxView boxView = new BoxView
            {
                WidthRequest = 150,
                HeightRequest = 150,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.CenterAndExpand
            };

            audioCodecPicker.SelectedIndexChanged += (sender, args) => {
                if (audioCodecPicker.SelectedIndex == -1) {
                    boxView.Color = Color.Default;
                } else {
                    string colorName = audioCodecPicker.Items[audioCodecPicker.SelectedIndex];
                    //boxView.Color = codecList[colorName];
                }
            };

            ///////////////////////////////////////////////

            StackLayout stackLayout = new StackLayout { Spacing = 10, Padding = new Thickness(10, 10, 10, 10) };

            Grid clientModeGrid = new Grid
            {
                ColumnSpacing = 10
            };
            clientModeGrid.Children.Add(clientModeLabel, 0, 0);
            clientModeGrid.Children.Add(clientModeSwitch, 1, 0);
            stackLayout.Children.Add(clientModeGrid);

            Grid proxyUseGrid = new Grid
            {
                ColumnSpacing = 10
            };
            proxyUseGrid.Children.Add(proxyUseLabel, 0, 0);
            proxyUseGrid.Children.Add(proxyUseSwitch, 1, 0);
            stackLayout.Children.Add(proxyUseGrid);

            Grid proxyModeGrid = new Grid
            {
                ColumnSpacing = 10
            };
            proxyModeGrid.Children.Add(proxyModeLabel, 0, 0);
            proxyModeGrid.Children.Add(proxyModeSwitch, 1, 0);
            stackLayout.Children.Add(proxyModeGrid);

            Grid audoAcceptGrid = new Grid
            {
                ColumnSpacing = 10
            };
            audoAcceptGrid.Children.Add(autoAcceptLabel, 0, 0);
            audoAcceptGrid.Children.Add(autoAcceptSwitch, 1, 0);
            stackLayout.Children.Add(audoAcceptGrid);

            Grid hostNameGrid = new Grid
            {
                ColumnSpacing = 10
            };
            hostNameGrid.Children.Add(hostNameLabel, 0, 0);
            hostNameGrid.Children.Add(hostNameEditor, 1, 0);
            stackLayout.Children.Add(hostNameGrid);

            Grid fromSipIpGrid = new Grid
            {
                ColumnSpacing = 10
            };
            fromSipIpGrid.Children.Add(fromSipIpLabel, 0, 0);
            fromSipIpGrid.Children.Add(fromSipIpEditor, 1, 0);
            stackLayout.Children.Add(fromSipIpGrid);

            Grid fromSipPortGrid = new Grid
            {
                ColumnSpacing = 10
            };
            fromSipPortGrid.Children.Add(fromSipIpLabel, 0, 0);
            fromSipPortGrid.Children.Add(fromSipPortEditor, 1, 0);
            stackLayout.Children.Add(fromSipPortGrid);

            Grid recordPathGrid = new Grid
            {
                ColumnSpacing = 10
            };
            recordPathGrid.Children.Add(recordPathLabel, 0, 0);
            recordPathGrid.Children.Add(recordPathEditor, 1, 0);
            stackLayout.Children.Add(recordPathGrid);

            Grid audioCodecPickerGrid = new Grid
            {
                ColumnSpacing = 10
            };
            audioCodecPickerGrid.Children.Add(audioCodecPickerLabel, 0, 0);
            audioCodecPickerGrid.Children.Add(audioCodecPicker, 1, 0);
            stackLayout.Children.Add(audioCodecPickerGrid);

            ///////////////////////////////////////////////

            Content = stackLayout;
        }
    }
}
