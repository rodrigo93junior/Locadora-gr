using System.Drawing;
using System.Windows.Forms;

namespace View
{
    namespace Lib
    {
        class LibLabel : Label
        {
            public LibLabel(
                string Text,
                Point Location,
                Size Size
            )
            {
                this.Text = Text;
                this.Location = Location;
                this.Size = Size;
            }
        }
        class LibTituloLabel : Label
        {
            public LibTituloLabel(
                string Text,
                Point Location,
                Size Size
            )
            {
                this.Text = Text;
                this.Location = Location;
                this.Size = Size;
                this.ForeColor = Color.DarkRed;
            }
        }
    }
}