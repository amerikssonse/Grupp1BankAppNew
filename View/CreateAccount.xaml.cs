﻿using System;
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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Grupp1BankApp.View
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class CreateAccount : Page
    {
        public CreateAccount()
        {
            this.InitializeComponent();
            Random rand = new Random();
            AccountNumber.Text = rand.Next(1, 100000).ToString();
            SsnNumber.Text = MainPage.ChoosenCustomer.SSN;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            BankLogic.AddCreditAccount(AccountNumber.Text, MainPage.ChoosenCustomer);
            var _Frame = Window.Current.Content as Frame;
            _Frame.Navigate(typeof(MainPage));
        }
    }
}
