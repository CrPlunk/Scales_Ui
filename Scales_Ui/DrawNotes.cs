using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI;
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
    class DrawNotes
    {
        int xloc = 0, yloc = 0;
        int size = 15;
        
        protected Ellipse note = null;

        public DrawNotes()
        {
            
        }
        public void SetLocation(int xCoord, int yCoord)
        {
            this.xloc = xCoord;
            this.yloc = yCoord;
        }
        public void Draw(Canvas canvas)
        {
            this.note = new Ellipse();
            this.note.Height = this.size;
            this.note.Width = this.size;
            Canvas.SetTop(this.note, this.xloc);  //TODO: loop through Scale if 0 do nothing, if 1 call HIGHE[0,0] if 3 call HighE[2,2] convert these to Method setlocation before and drawMethods
            Canvas.SetLeft(this.note, this.yloc);
            canvas.Children.Add(this.note);
            
        }
        public void setColor()
        {
            SolidColorBrush brush = new SolidColorBrush(Colors.Black);
            this.note.Fill = brush;
        }


    }
}
