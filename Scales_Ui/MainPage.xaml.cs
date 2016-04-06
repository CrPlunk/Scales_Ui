using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Shapes;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Scales_Ui
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    enum keys  {C = 1, Cc = 2, D = 3, Ds = 4, E = 5, F= 6, fs = 7, G = 8 , Gs= 9, A = 10, As = 11, B = 12, e = 11, f = 0, }
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            
        }
        
        private void button_Tapped(object sender, TappedRoutedEventArgs e)
        {
            ScaleBuilder myScale = new ScaleBuilder();
            PositionalData pos = new PositionalData();
            pos.setCoords();
            int[] Major = { 1, 3, 5, 6, 8, 10, 11 };
           // int[] Blues = { 1, 4, 6, 8, 11 };
            
            myScale.buildScale(Major);
            // 7,0,9,4,2,7
            // Keyf = 5 for blues?
            // keyf = 0 for Major?
            /*
               int[] finale = pos.ShiftLeft(myScale.ScaleX, 2);
               int[] finalB = pos.ShiftLeft(myScale.ScaleX, 9);
               int[] finalD = pos.ShiftLeft(myScale.ScaleX, 0);
               int[] finalG = pos.ShiftLeft(myScale.ScaleX, 6);
               int[] finalA = pos.ShiftLeft(myScale.ScaleX, 4);
               int[] finalE = pos.ShiftLeft(myScale.ScaleX, 2);
            */
            int KeyF = 0;
            int[] finale = pos.ShiftRight(myScale.ScaleX, KeyF + 7);
            int[] finalB = pos.ShiftRight(myScale.ScaleX, KeyF + 0);
            int[] finalD = pos.ShiftRight(myScale.ScaleX, KeyF + 4);
            int[] finalG = pos.ShiftRight(myScale.ScaleX, KeyF + 9);
            int[] finalA = pos.ShiftRight(myScale.ScaleX, KeyF + 2);
            int[] finalE = pos.ShiftRight(myScale.ScaleX, KeyF + 7);
        

            for (int i = 0; i < finale.Length; i++)

                
            {
                if (finale[i] == 0) { }
                else
                {

                    DrawNotes noteE = new DrawNotes();
                    int Estring = pos._E[i, 0];
                    int Efret = pos._E[i, 1];
                    noteE.SetLocation(Estring, Efret);
                    noteE.Draw(this.Scale);
                    noteE.setColor();

                }
            }
            for (int i = 0; i < finalB.Length; i++)
            {
                if(finalB[i] == 0 ) { }
                else
                {
                    

                            DrawNotes noteB = new DrawNotes();
                            int Estring = pos._B[i, 0];
                            int Efret = pos._B[i, 1];
                            noteB.SetLocation(Estring, Efret);
                            noteB.Draw(this.Scale);
                            noteB.setColor();

                        
                    
                }
            }
            for (int i = 0; i < finalD.Length; i++)
            {
                if (finalD[i] == 0) { }
                else
                {


                    DrawNotes noteD = new DrawNotes();
                    int Estring = pos._D[i, 0];
                    int Efret = pos._D[i, 1];
                    noteD.SetLocation(Estring, Efret);
                    noteD.Draw(this.Scale);
                    noteD.setColor();



                }
            }
            for (int i = 0; i < finalG.Length; i++)
            {
                if (finalG[i] == 0) { }
                else
                {


                    DrawNotes noteG = new DrawNotes();
                    int Estring = pos._G[i, 0];
                    int Efret = pos._G[i, 1];
                    noteG.SetLocation(Estring, Efret);
                    noteG.Draw(this.Scale);
                    noteG.setColor();



                }
            }
            for (int i = 0; i < finalA.Length; i++)
            {
                if (finalA[i] == 0) { }
                else
                {


                    DrawNotes noteA = new DrawNotes();
                    int Estring = pos._A[i, 0];
                    int Efret = pos._A[i, 1];
                    noteA.SetLocation(Estring, Efret);
                    noteA.Draw(this.Scale);
                    noteA.setColor();



                }
            }
            for (int i = 0; i < finalE.Length; i++)
            {
                if (finalE[i] == 0) { }
                else
                {


                    DrawNotes noteE = new DrawNotes();
                    int Estring = pos._LowE[i, 0];
                    int Efret = pos._LowE[i, 1];
                    noteE.SetLocation(Estring, Efret);
                    noteE.Draw(this.Scale);
                    noteE.setColor();



                }
            }




        }
    }
}
