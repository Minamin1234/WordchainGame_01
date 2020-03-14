using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WordChainGame_01
{
    public class Game
    {

        public bool IsCalled = false;

        public void GetAssignedUIs(UIs Target_UI)
        {
            switch (Target_UI)
            {
                case UIs.Start:
                    {
                        UI_Start = new Window_Start();
                        break;
                    }

                case UIs.Game:
                    {
                        UI_Game = new Window_Game();
                        break;
                    }

                case UIs.None:
                    {
                        break;
                    }

                default:
                    {
                        break;
                    }
            }

        }

        public Game()
        {
        }



        //Assign UIs
        public Window_Start UI_Start = null;
        public Window_Game UI_Game = null;


        public enum Open_Close
        {
            Open,
            Close,
        }

        public enum UIs
        {
            None,
            Start,
            Game,
        }

        public UIs Type_Window = UIs.Start;
        public Window Current_Window = null;


        

        public void Change_UI(UIs Change_To)
        {
            switch (Change_To)
            {
                case UIs.None:
                    {
                        break;
                    }

                case UIs.Start:
                    {
                        if (Type_Window != UIs.Start)
                        {
                            GetAssignedUIs(UIs.Start);
                            UI_Start.Visibility = Visibility.Visible;
                            Current_Window.Visibility = Visibility.Hidden;
                            Current_Window = UI_Start;
                            Type_Window = UIs.Start;
                        }
                        else
                        {

                        }
                        break;
                    }

                case UIs.Game:
                    {
                        if (Type_Window != UIs.Game)
                        {
                            GetAssignedUIs(UIs.Game);
                            UI_Game.Show();
                            UI_Game.Visibility = Visibility.Visible;
                            Current_Window.Visibility = Visibility.Hidden;
                            Current_Window = UI_Game;
                            Type_Window = UIs.Game;
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

        public void Go_Game()
        {
            Change_UI(UIs.Game);
        }

        public void Back_To_Start()
        {
            Change_UI(UIs.Start);
        }

        public void A()
        {
            MessageBox.Show("Called");
        }
    }
}
