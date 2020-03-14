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

namespace WordChainGame_01
{
    /// <summary>
    /// Window_Start.xaml の相互作用ロジック
    /// </summary>
    public partial class Window_Start : Window
    {

        Game Proglam = new Game();

        public Window_Start()
        {
            InitializeComponent();
            
        }

        

        

        private void Clicked(object sender, RoutedEventArgs e)
        {
            Proglam.Go_Game();
        }
    }
}
