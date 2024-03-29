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

namespace Lab1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void TbxName_GotFocus(object sender, RoutedEventArgs e)
        {
           // tbxName.Text = "";
            tbxName.Clear();
        }

        private void BtnShowMessage_Click(object sender, RoutedEventArgs e)
        {
            //read text from textbox
            string name = tbxName.Text;

            //display small message box
            MessageBox.Show(string.Format($"Hello {name}"));

        }
    }
}
