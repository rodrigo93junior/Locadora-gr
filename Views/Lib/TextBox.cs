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
    }
}