using Avalonia.Controls;
using System;
using System.Collections.Generic;

namespace Noteflow.views
{
    public partial class MainWindow : Window
    {
      
        public MainWindow()
        {
            InitializeComponent();
            greetingButton.Content = "Goodbye Cruel World!";
        }
    
    }
}