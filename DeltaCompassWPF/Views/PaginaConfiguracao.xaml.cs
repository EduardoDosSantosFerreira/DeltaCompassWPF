﻿using System;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DeltaCompassWPF.Views
{
    /// <summary>
    /// Interação lógica para PaginaConfiguracao.xam
    /// </summary>
    public partial class PaginaConfiguracao : Page
    {
        public PaginaConfiguracao()
        {
            InitializeComponent();
        }

        private void BtnConfigGeral_MouseEnter(object sender, MouseEventArgs e)
        {
            lblGeral.Foreground = new SolidColorBrush(Colors.DarkGray);
            this.Cursor = Cursors.Hand;
        }

        private void BtnConfigGeral_MouseLeave(object sender, MouseEventArgs e)
        {
            lblGeral.Foreground = new SolidColorBrush(Colors.White);
            this.Cursor = Cursors.Arrow;
        }

        private void BtnConfigPerfil_MouseEnter(Object sender, MouseEventArgs e)
        {
            lblPerfil.Foreground = new SolidColorBrush(Colors.DarkGray);
            this.Cursor = Cursors.Hand;
        }

        private void BtnConfigPerfil_MouseLeave(Object sender, MouseEventArgs e)
        {
            lblPerfil.Foreground = new SolidColorBrush(Colors.White);
            this.Cursor = Cursors.Arrow;
        }

        private void BtnConfigGeral_Click(Object sender, RoutedEventArgs e)
        {
            bordaGeral.Visibility = Visibility.Visible;
            bordaPerfil.Visibility = Visibility.Hidden;
            scrollConfigGeral.Visibility = Visibility.Visible;
            scrollConfigPerfil.Visibility = Visibility.Collapsed;
        }

        private void BtnConfigPerfil_Click(Object sender, RoutedEventArgs e)
        {
            bordaGeral.Visibility = Visibility.Hidden;
            bordaPerfil.Visibility = Visibility.Visible;
            scrollConfigGeral.Visibility = Visibility.Collapsed;
            scrollConfigPerfil.Visibility = Visibility.Visible;
        }

        private void bordaSalvarPerfil_MouseEnter(object sender, MouseEventArgs e)
        {
            bordaSalvarPerfil.BorderBrush = new SolidColorBrush(Color.FromArgb(250, 22, 20, 92));
            btnSalvarPerfil.Background = new SolidColorBrush(Color.FromArgb(250, 22, 20, 92));
            this.Cursor = Cursors.Hand;
        }

        private void bordaSalvarPerfil_MouseLeave(object sender, MouseEventArgs e)
        {
            bordaSalvarPerfil.BorderBrush = new SolidColorBrush(Color.FromArgb(250, 46, 43, 194));
            btnSalvarPerfil.Background = new SolidColorBrush(Color.FromArgb(250, 46, 43, 194));
            this.Cursor = Cursors.Arrow;
        }
    }
}
