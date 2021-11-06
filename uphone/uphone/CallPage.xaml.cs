using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace uphone
{
    public partial class CallPage : ContentPage
    {
        public CallPage()
        {
            InitializeComponent();

            ///////////////////////////////////////////////

            Button onButton = new Button
            {
                Text = "ON"
            };
            onButton.Clicked += (sender, e) =>
            {

            };

            Button offButton = new Button
            {
                Text = "OFF"
            };
            offButton.Clicked += (sender, e) =>
            {

            };

            Button exitButton = new Button
            {
                Text = "EXIT"
            };
            exitButton.Clicked += (sender, e) =>
            {
                Environment.Exit(1);
            };

            ///////////////////////////////////////////////

            Editor proxyHostNameEditor = new Editor
            {

            };

            Button registerButton = new Button
            {
                Text = "REGISTER"
            };
            registerButton.Clicked += (sender, e) =>
            {

            };

            Button contactButton = new Button
            {
                Text = "CONTACT"
            };
            contactButton.Clicked += (sender, e) =>
            {

            };

            ///////////////////////////////////////////////

            Editor remoteHostNameEditor = new Editor
            {

            };

            Button callButton = new Button
            {
                Text = "CALL"
            };
            callButton.Clicked += (sender, e) =>
            {

            };

            Button byeButton = new Button
            {
                Text = "BYE"
            };
            byeButton.Clicked += (sender, e) =>
            {

            };

            StackLayout stackLayout = new StackLayout { Spacing = 10, Padding = new Thickness(10, 10, 10, 10) };

            Grid onOffExitButtonsGrid = new Grid
            {
                ColumnSpacing = 10
            };
            onOffExitButtonsGrid.Children.Add(onButton, 0, 0);
            onOffExitButtonsGrid.Children.Add(offButton, 1, 0);
            onOffExitButtonsGrid.Children.Add(exitButton, 2, 0);
            stackLayout.Children.Add(onOffExitButtonsGrid);

            stackLayout.Children.Add(proxyHostNameEditor);
            Grid registerGrid = new Grid
            {
                ColumnSpacing = 10
            };
            registerGrid.Children.Add(registerButton, 0, 0);
            registerGrid.Children.Add(contactButton, 1, 0);
            stackLayout.Children.Add(registerGrid);

            stackLayout.Children.Add(remoteHostNameEditor);
            Grid callByeGrid = new Grid
            {
                ColumnSpacing = 10
            };
            callByeGrid.Children.Add(callButton, 0, 0);
            callByeGrid.Children.Add(byeButton, 1, 0);
            stackLayout.Children.Add(callByeGrid);

            ///////////////////////////////////////////////
            // DTMF

            Button oneButton = new Button
            {
                Text = "1",
                FontSize = 30,
                TextColor = Color.Black,
                BackgroundColor = Color.White,
                BorderWidth = 30
            };
            oneButton.Clicked += (sender, e) =>
            {

            };

            Button twoButton = new Button
            {
                Text = "2",
                FontSize = 30,
                TextColor = Color.Black,
                BackgroundColor = Color.White,
                BorderWidth = 30
            };
            twoButton.Clicked += (sender, e) =>
            {

            };

            Button threeButton = new Button
            {
                Text = "3",
                FontSize = 30,
                TextColor = Color.Black,
                BackgroundColor = Color.White,
                BorderWidth = 30
            };
            threeButton.Clicked += (sender, e) =>
            {

            };

            Button fourButton = new Button
            {
                Text = "4",
                FontSize = 30,
                TextColor = Color.Black,
                BackgroundColor = Color.White,
                BorderWidth = 30
            };
            fourButton.Clicked += (sender, e) =>
            {

            };

            Button fiveButton = new Button
            {
                Text = "5",
                FontSize = 30,
                TextColor = Color.Black,
                BackgroundColor = Color.White,
                BorderWidth = 30
            };
            fiveButton.Clicked += (sender, e) =>
            {

            };

            Button sixButton = new Button
            {
                Text = "6",
                FontSize = 30,
                TextColor = Color.Black,
                BackgroundColor = Color.White,
                BorderWidth = 30
            };
            sixButton.Clicked += (sender, e) =>
            {

            };

            Button sevenButton = new Button
            {
                Text = "7",
                FontSize = 30,
                TextColor = Color.Black,
                BackgroundColor = Color.White,
                BorderWidth = 30
            };
            sevenButton.Clicked += (sender, e) =>
            {

            };

            Button eightButton = new Button
            {
                Text = "8",
                FontSize = 30,
                TextColor = Color.Black,
                BackgroundColor = Color.White,
                BorderWidth = 30
            };
            eightButton.Clicked += (sender, e) =>
            {

            };

            Button nineButton = new Button
            {
                Text = "9",
                FontSize = 30,
                TextColor = Color.Black,
                BackgroundColor = Color.White,
                BorderWidth = 30
            };
            nineButton.Clicked += (sender, e) =>
            {

            };

            Button starButton = new Button
            {
                Text = "*",
                FontSize = 30,
                TextColor = Color.Black,
                BackgroundColor = Color.White,
                BorderWidth = 30
            };
            starButton.Clicked += (sender, e) =>
            {

            };

            Button zeroButton = new Button
            {
                Text = "0",
                FontSize = 30,
                TextColor = Color.Black,
                BackgroundColor = Color.White,
                BorderWidth = 30
            };
            zeroButton.Clicked += (sender, e) =>
            {

            };

            Button shopButton = new Button
            {
                Text = "#",
                FontSize = 30,
                TextColor = Color.Black,
                BackgroundColor = Color.White,
                BorderWidth = 30
            };
            shopButton.Clicked += (sender, e) =>
            {

            };
            ///////////////////////////////////////////////

            //StackLayout stackLayout = new StackLayout { Spacing = 10, Padding = new Thickness(10, 10, 10, 10) };

            //stackLayout.Children.Add(mdnLabel);

            Grid dtmfGrid = new Grid
            {
                Padding = 40,
                RowSpacing = 10,
                ColumnSpacing = 10,
                VerticalOptions = LayoutOptions.FillAndExpand,
                HorizontalOptions = LayoutOptions.Center
            };

            dtmfGrid.RowDefinitions.Add(new RowDefinition { Height = GridLength.Star });
            dtmfGrid.RowDefinitions.Add(new RowDefinition { Height = GridLength.Star });
            dtmfGrid.RowDefinitions.Add(new RowDefinition { Height = GridLength.Star });
            dtmfGrid.RowDefinitions.Add(new RowDefinition { Height = GridLength.Star });

            dtmfGrid.ColumnDefinitions.Add(new ColumnDefinition { Width = GridLength.Star });
            dtmfGrid.ColumnDefinitions.Add(new ColumnDefinition { Width = GridLength.Star });
            dtmfGrid.ColumnDefinitions.Add(new ColumnDefinition { Width = GridLength.Star });

            dtmfGrid.Children.Add(oneButton, 0, 0);
            dtmfGrid.Children.Add(twoButton, 1, 0);
            dtmfGrid.Children.Add(threeButton, 2, 0);

            dtmfGrid.Children.Add(fourButton, 0, 1);
            dtmfGrid.Children.Add(fiveButton, 1, 1);
            dtmfGrid.Children.Add(sixButton, 2, 1);

            dtmfGrid.Children.Add(sevenButton, 0, 2);
            dtmfGrid.Children.Add(eightButton, 1, 2);
            dtmfGrid.Children.Add(nineButton, 2, 2);

            dtmfGrid.Children.Add(starButton, 0, 3);
            dtmfGrid.Children.Add(zeroButton, 1, 3);
            dtmfGrid.Children.Add(shopButton, 2, 3);

            stackLayout.Children.Add(dtmfGrid);

            ///////////////////////////////////////////////

            Content = stackLayout;
        }
    }
}
