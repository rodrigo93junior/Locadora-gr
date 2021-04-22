using System.Drawing;
using System.Windows.Forms;

namespace View
{
    namespace LbComboBox
    {
        class LbComboBox : ComboBox
        {
            public LbComboBox(
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