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
using System.Windows.Shapes;

using System.Data;
using System.Collections.ObjectModel;
using System.Diagnostics;

namespace WordChainGame_01
{
    /// <summary>
    /// Window_Game.xaml の相互作用ロジック
    /// </summary>
    public partial class Window_Game : Window
    {

        

        Game Proglam = new Game();

        public class WordDatas
        {
            public string Words { get; set; }
            public bool IsChecked { get; set; }
        }

        public Window_Game()
        {
            InitializeComponent();
            //this.Visibility = Visibility.Hidden;
            Proglam.Current_Window = this;
            Proglam.Type_Window = Game.UIs.Game;

            //ObservableCollection<WordDatas> wordDatas = G
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Proglam.Back_To_Start();
        }
    }
}
