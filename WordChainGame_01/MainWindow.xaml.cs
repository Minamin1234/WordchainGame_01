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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WordChainGame_01
{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        //Game GameProglams = new Game();
        //Window_Start UI_Start = new Window_Start();
        //Window_Game UI_Game = new Window_Game();


        public void Clicked(object sender, RoutedEventArgs e)
        {
            Button Clicked_Button = (Button)sender;
            Console.WriteLine(Clicked_Button.Name);





            switch (Clicked_Button.Name)
            {
                case "Start":
                    {
                        //Change_UI(UIs.Start);
                        break;
                    }

                default:
                    {

                        break;
                    }
            }


        }


    }
}
