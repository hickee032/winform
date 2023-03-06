using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winform1219.util
{
    internal class CommUtil
    {
        public static void setRowColor(ListView list,
            Color oddColor, Color evenColor)
        {
            foreach (ListViewItem item in list.Items)
            {
                if (item.Index % 2 == 0) 
                {
                    item.BackColor = oddColor;
                }
                else
                {
                    item.BackColor = evenColor;
                }
            }
        }
    }
}
