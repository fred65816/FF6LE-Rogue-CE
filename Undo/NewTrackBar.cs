using System;
using System.Collections.Generic;
using System.Text;

namespace FF3LE.Undo
{
    class NewTrackBar : System.Windows.Forms.TrackBar
    {
        private int lastValue = 0; public int LastValue { get { return lastValue; } set { lastValue = value; } }
    }
}
