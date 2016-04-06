using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Scales_Ui
{
    
    class ScaleBuilder 
    {
        int[] Octave = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
        
        private int[] _scaleX;
        public int[] ScaleX { get { return this._scaleX; } set { this._scaleX = value; } }
       
        public ScaleBuilder()
        {
            this._scaleX = new int[Octave.Length];
        }
        public void buildScale(int[] notes)  
        {
            int[] oct = this.Octave;
            int j = 0;
            for (int i = 0; i < notes.Length; i++)
            {
                for (int k = j ; k < oct.Length; k++)
                {
                    if (oct[k] == notes[i])
                    {
                        this._scaleX[k] = notes[i];
                        j++;
                        break;
                    }
                    else
                    {
                        this._scaleX[k] = 0;
                        j++;
                        i--;
                        break;
                    }

                }
            }
        }
     
        

    }
    

}

