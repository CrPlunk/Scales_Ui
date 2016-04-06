using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Shapes;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

namespace Scales_Ui
{
    class PositionalData
    {

        
        int[,] Bstring = new int[12, 2];
        int[,] Dstring = new int[12, 2];
        int[,] Gstring = new int[12, 2];
        int[,] Astring = new int[12, 2];
        int[,] Estring = new int[12, 2];
        int[,] lowE = new int[12, 2];
        public int[,] _B { get { return this.Bstring; } }
        public int[,] _D { get { return this.Dstring; } }
        public int[,] _G { get { return this.Gstring; } }
        public int[,] _A { get { return this.Astring; } }
        public int[,] _E { get { return this.Estring; } }
        public int[,] _LowE { get { return this.lowE; } }
        public void setCoords()
        {
            int x = 13;
            int y = 50;
            for (int i = 0; i <= 11; i++)
            {
                this.Estring[i, 0] = x ;
                this.Estring[i, 1] = y;

                this.Bstring[i, 0] = x + 30;
                this.Bstring[i, 1] = y;

                this.Dstring[i, 0] = x  + 60;
                this.Dstring[i, 1] = y;

                this.Gstring[i, 0] = x + 90;
                this.Gstring[i, 1] = y;

                this.Astring[i, 0] = x + 120;
                this.Astring[i, 1] = y;

                this.lowE[i, 0] = x + 150;
                this.lowE[i, 1] = y;
                y += 70;

            }
        }
        public int[] ShiftRight(int[] arr, int shiftBy)
        {
            if (shiftBy == 0)
            {
                return arr;
            }
            var target = new int[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                target[(i + 1) % target.Length] = arr[i];
            }
            return ShiftRight(target, shiftBy - 1);
        }
        public int[] ShiftLeft(int[] arr, int shiftBy)
        {
            if (shiftBy == 0)
            {
                return arr;
            }
            var target = new int[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                target[i] = arr[(i + 1) % target.Length];
            }
            return ShiftRight(target, shiftBy - 1);
        }



    }
}
