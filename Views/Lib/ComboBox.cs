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
    }
}