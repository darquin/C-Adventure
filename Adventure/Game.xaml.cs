using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Adventure
{
    /// <summary>
    /// Interaction logic for Game.xaml
    /// </summary>
    public partial class Game : Window
    {
        private MainWindow m_Parent;
        public Game(MainWindow ParentMain)
        {
            InitializeComponent();
            m_Parent = ParentMain;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void buttonGameToOption_Click(object sender, RoutedEventArgs e)
        {
            var OptionWindow = new OptionMenu(this, this.m_Parent);
            OptionWindow.Show();
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            m_Parent.Show();
        }
    }
}
