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



        enum Open_Close
        {
            Open,
            Close,
        }
        //Open_Close Current_Open_Close = Open_Close.Open;

        enum UIs
        {
            None,
            Start,
            Game,
        }

        UIs Current_UI = UIs.Start;

        Window Current_Window = null;




        void Change_UI(UIs Change_To ,Open_Close Open_Close)
        {
            switch (Change_To)
            {
                case UIs.None:
                    {
                        break;
                    }

                case UIs.Start:
                    {
                        if(Current_UI != UIs.Start)
                        {
                            Window_Start UI_Start = new Window_Start();
                            if (Current_UI != UIs.None)
                            {
                                UI_Start.Visibility = Visibility.Visible;
                            }
                            else
                            {
                                UI_Start.Show();
                            }
                            Current_UI = UIs.Start;
                            Current_Window = UI_Start;
                            

                        }
                        break;
                    }

                case UIs.Game:
                    {
                        if(Current_UI != UIs.Game)
                        {
                            
                        }
                        else
                        {

                        }
                        break;
                    }

                default:
                    {
                        break;
                    }
            }
        }

        private void Clicked(object sender, RoutedEventArgs e)
        {
            Button Clicked_Button = (Button)sender;
            Console.WriteLine(Clicked_Button.Name);
            
            
        }
    }
}
