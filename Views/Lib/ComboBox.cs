using System.Drawing;
using System.Windows.Forms;

namespace View
{
    namespace Lib
    {
        class LibComboBox : ComboBox
        {
            public LibComboBox(
                Point Location,
                Size Size
            )
            {
                this.Location = Location;
                this.Size = Size;
            }
        }
        class LibNumeric : NumericUpDown
        {
            public LibNumeric(
                Point Location,
                Size Size,
                int Value,
                int Maximum,
                int Minimum
            )
            {
                this.Location = Location;
                this.Size = Size;
                this.Value = Value;
                this.Maximum = Maximum;
                this.Minimum = Minimum;
            }
        }
    }
}