using System.Drawing;
using System.Windows.Forms;

namespace Views
{
    namespace Lib
    {
        class Listagem : ListView
        {
            public Listagem(
                Point Location,
                Size Size
            )
            {
                this.Size = Size;
                this.Location = Location;
            }
        }
    }
}