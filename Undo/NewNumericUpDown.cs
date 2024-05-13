using System;
using System.Collections.Generic;
using System.Text;

namespace FF3LE.Undo
{
    class NewNumericUpDown : System.Windows.Forms.NumericUpDown
    {
        private int lastValue; public int LastValue { get { return lastValue; } }
        protected override void OnChanged(object source, EventArgs e)
        {
            lastValue = (int)this.Value;
            base.OnChanged(source, e);
        }
    }
}
