using System.Drawing;
using System.Windows.Forms;

namespace View
{
    namespace Lib
    {
        class LibButton : Button
        {
            public LibButton(
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
    }
}