﻿using DeltaCompassWPF.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace DeltaCompassWPF.Views
{
    /// <summary>
    /// Lógica interna para JanelaLogin.xaml
    /// </summary>
    public partial class JanelaLogin : Window
    {
        public JanelaLogin()
        {
            InitializeComponent();
            var viewModel = new LoginViewModel();
            DataContext = viewModel;

            if(viewModel.CloseAction == null)
            {
                viewModel.CloseAction = new Action(this.Close);
            }
        }

        private void janela_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

        private void btnFechar_MouseEnter(object sender, MouseEventArgs e)
        {
            btnFechar.Fill = new SolidColorBrush(Color.FromArgb(255, 46, 43, 194));
        }

        private void btnFechar_MouseLeave(object sender, MouseEventArgs e)
        {
            btnFechar.Fill = new SolidColorBrush(Color.FromArgb(255, 16, 16, 16));
        }

        private void btnFechar_MouseDown(object sender, MouseEventArgs e)
        {
            Close();
        }

        private void txtLogin_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (txtLogin.Text != "")
                placeLogin.Visibility = Visibility.Collapsed;
            else
                placeLogin.Visibility = Visibility.Visible;
        }

        private void bordaEntrar_MouseEnter(object sender, MouseEventArgs e)
        {
            btnConfirmar.Background = new SolidColorBrush(Color.FromArgb(250, 22, 20, 92));
            this.Cursor = Cursors.Hand;
        }

        private void bordaEntrar_MouseLeave(object sender, MouseEventArgs e)
        {
            btnConfirmar.Background = new SolidColorBrush(Color.FromArgb(250, 46, 43, 194));
            this.Cursor = Cursors.Arrow;
        }
    }
}
