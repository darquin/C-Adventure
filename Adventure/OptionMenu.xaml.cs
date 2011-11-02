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
    /// Interaction logic for OptionMenu.xaml
    /// </summary>
    public partial class OptionMenu : Window
    {
        private Game g_Parent;
        private MainWindow m_Parent;
        public OptionMenu(Game ParentGame, MainWindow ParentMain)
        {
            InitializeComponent();
            g_Parent = ParentGame;
            m_Parent = ParentMain;

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void buttonOptionQuitToMain_Click(object sender, RoutedEventArgs e)
        {
            g_Parent.Close();
            m_Parent.Show();
            this.Close();
        }

        private void buttonOptionQuitToDesktop_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void buttonOptionReturnToGame_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
