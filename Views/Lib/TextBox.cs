using System.Drawing;
using System.Windows.Forms;

namespace View
{
    namespace Lib
    {
        class LibTextBox : TextBox
        {
            public LibTextBox(
                Point Location,
                Size Size
            )
            {
                this.Location = Location;
                this.Size = Size;
            }
        }
        class LibMaskedTextBox : MaskedTextBox
        {
            public LibMaskedTextBox(
                Point Location,
                Size Size,
                string Mask
            )
            {
                this.Location = Location;
                this.Size = Size;
                this.Mask = Mask;
            }
        }
    }
}