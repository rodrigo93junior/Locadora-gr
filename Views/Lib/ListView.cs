using System.Drawing;
using System.Windows.Forms;

namespace View
{
    namespace Lib
    {
        class LibListView : ListView
        {
            public LibListView(
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