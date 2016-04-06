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
    enum keys  {C = 1, Cc = 2, D = 3, Ds = 4, E = 5, F= 6, fs = 7, G = 8 , Gs= 9, A = 10, As = 11, B = 12, e = 11, f = 0, }  // used for refrence
                                                                                                                             // 7,0,9,4,2,7 ?? 7,0,4,9,2,7
                                                                                                                             // Keyf = 5 for blues?
                                                                                                                             // keyf = 0 for Major?
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            
        }
        public void AddNotes(int[] ToDrawString, int[,] Coords)
        {
            for (int i = 0; i < ToDrawString.Length; i++)


            {
                if (ToDrawString[i] == 0) { }
                else
                {

                    DrawNotes noteE = new DrawNotes();
                    int StringCoord = Coords[i, 0];
                    int FretCoord = Coords[i, 1];
                    noteE.SetLocation(StringCoord, FretCoord);
                    noteE.Draw(this.Scale);
                    noteE.setColor();

                }
            }

        }


        private void button_Tapped(object sender, TappedRoutedEventArgs e)
        {
            ScaleBuilder myScale = new ScaleBuilder();
            PositionalData pos = new PositionalData();
            pos.setCoords();
            int[] Major = { 1, 3, 5, 6, 8, 10, 11 };
         // int[] Blues = { 1, 4, 6, 8, 11 };
            
            myScale.buildScale(Major);
          
   
            int KeyF = 0;  // used to transpose keys
            int[] finale = pos.ShiftRight(myScale.ScaleX, KeyF + 7);
            int[] finalB = pos.ShiftRight(myScale.ScaleX, KeyF + 0);
            int[] finalD = pos.ShiftRight(myScale.ScaleX, KeyF + 4);
            int[] finalG = pos.ShiftRight(myScale.ScaleX, KeyF + 9);
            int[] finalA = pos.ShiftRight(myScale.ScaleX, KeyF + 2);
            int[] finalE = pos.ShiftRight(myScale.ScaleX, KeyF + 7);
    
            AddNotes(finale, pos._E);
            AddNotes(finalB, pos._B);
            AddNotes(finalD, pos._D);
            AddNotes(finalG, pos._G);
            AddNotes(finalA, pos._A);
            AddNotes(finalE, pos._LowE);





        }
    }
}
