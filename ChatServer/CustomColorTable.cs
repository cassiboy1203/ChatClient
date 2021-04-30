using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatServer
{
    class CustomColorTable : ProfessionalColorTable
    {
        public override Color MenuBorder
        {
            get
            {
                return Color.FromArgb(32, 34, 37);
            }
        }

        public override Color MenuItemSelected
        {
            get
            {
                return Color.FromArgb(114, 137, 218);
            }
        }

        public override Color MenuItemBorder
        {
            get
            {
                return Color.FromArgb(114, 137, 218); 
            }
        }
    }
}
