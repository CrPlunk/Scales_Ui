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
                    noteE.Draw(this.myCanvas);
                    noteE.setColor();

                }
            }

        }
        PositionalData pos = new PositionalData();
       
        private void Major_Tapped(object sender, TappedRoutedEventArgs e)
        {
            myCanvas.Children.Remove<Ellipse>();
            ScaleBuilder myScale = new ScaleBuilder();
            pos.setCoords();
            int[] Major = { 1, 3, 5, 6, 8, 10, 11 };
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

        

        private void ScalesComboBox_DropDownClosed_1(object sender, object e)
        {
            ScaleBuilder myScale = new ScaleBuilder();
            pos.setCoords();
            int selected = ScalesComboBox.SelectedIndex;
            if (selected == 0)
            {
                myCanvas.Children.Remove<Ellipse>();
                int[] Minor = { 1, 3, 5, 6, 8, 10, 11 };
                myScale.buildScale(Minor);
            }

            else if (selected == 1)
            {
                myCanvas.Children.Remove<Ellipse>();
                int[] Minor = { 1, 3, 4, 6, 8, 10, 11 };
                myScale.buildScale(Minor);
            }
            else if (selected == 2)
            {
                myCanvas.Children.Remove<Ellipse>();
                int[] HarmMajor = { 1, 3, 4, 6, 8, 9, 11 };
                myScale.buildScale(HarmMajor);
            }
            else if (selected == 3)
            {
                myCanvas.Children.Remove<Ellipse>();
                int[] HarmMinor = { 1, 3, 5, 6, 8, 9, 11 };
                myScale.buildScale(HarmMinor);
            }
            else if (selected == 4)
            {
                myCanvas.Children.Remove<Ellipse>();
                int[] HungMajor = { 1, 4, 5, 7, 8, 10, 11 };
                myScale.buildScale(HungMajor);
            }
            else if (selected == 5)
            {
                myCanvas.Children.Remove<Ellipse>();
                int[] HungMinor = { 1, 3, 4, 7, 8, 9, 11 };
                myScale.buildScale(HungMinor);
            }
            else if (selected == 6)
            {
                myCanvas.Children.Remove<Ellipse>();
                int[] NeapoMajor = { 1, 2, 4, 6, 8, 10, 11 };
                myScale.buildScale(NeapoMajor);
            }
            else if (selected == 3)
            {
                myCanvas.Children.Remove<Ellipse>();
                int[] NeapoMinor = { 1, 2, 4, 6, 8, 9, 11 };
                myScale.buildScale(NeapoMinor);
            }
            else if (selected == 3)
            {
                myCanvas.Children.Remove<Ellipse>();
                int[] HarmMajor = { 1, 3, 4, 6, 8, 9, 11 };
                myScale.buildScale(HarmMajor);
            }
            else if (selected == 3)
            {
                myCanvas.Children.Remove<Ellipse>();
                int[] HarmMajor = { 1, 3, 4, 6, 8, 9, 11 };
                myScale.buildScale(HarmMajor);
            }
            else if (selected == 3)
            {
                myCanvas.Children.Remove<Ellipse>();
                int[] HarmMajor = { 1, 3, 4, 6, 8, 9, 11 };
                myScale.buildScale(HarmMajor);
            }
            else if (selected == 3)
            {
                myCanvas.Children.Remove<Ellipse>();
                int[] HarmMajor = { 1, 3, 4, 6, 8, 9, 11 };
                myScale.buildScale(HarmMajor);
            }
            else if (selected == 3)
            {
                myCanvas.Children.Remove<Ellipse>();
                int[] HarmMajor = { 1, 3, 4, 6, 8, 9, 11 };
                myScale.buildScale(HarmMajor);
            }

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
