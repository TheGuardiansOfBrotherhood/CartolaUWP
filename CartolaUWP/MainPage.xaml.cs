﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI;
using Windows.UI.ViewManagement;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

namespace CartolaUWP
{

    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            contentFrame.Navigate(typeof(Mercado));
        }

        private void HamburgerButton_Click(object sender, RoutedEventArgs e)
        {
            MySplitView.IsPaneOpen = !MySplitView.IsPaneOpen;
        }

        private void Mercado_Click(object sender, RoutedEventArgs e)
        {
            contentFrame.Navigate(typeof(Mercado));
        }

        private void Patrocionadores_Click(object sender, RoutedEventArgs e)
        {
            contentFrame.Navigate(typeof(ListarPatrocinadores));
        }

        private void Campeonato_Click(object sender, RoutedEventArgs e)
        {
            contentFrame.Navigate(typeof(Campeonato));
        }

        private void Jogadores_Click(object sender, RoutedEventArgs e)
        {
            contentFrame.Navigate(typeof(Jogadores));
        }

        private void Clubes_Click(object sender, RoutedEventArgs e)
        {
            contentFrame.Navigate(typeof(ClubesParticipantes));
        }
    }
}
