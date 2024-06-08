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

namespace DeltaCompassWPF.Views.UserControls
{
    public partial class ControlNotificacao : UserControl
    {
        public ControlNotificacao()
        {
            InitializeComponent();
        }

        public string Message
        {
            get => txtNotificacao.Text;
            set => txtNotificacao.Text = value;
        }

        private void Image_MouseDown(object sender, MouseButtonEventArgs e)
        {
            var parent = this.Parent as Panel;
            parent?.Children.Remove(this);
        }
    }
}