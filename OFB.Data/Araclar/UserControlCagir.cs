using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace OFB.Data.Araclar
{
    public static class UserControlCagir
    {
        public static void UserControlAdd(Grid grd, UserControl us)
        {
            if (grd.Children.Count > 0)
            {
                grd.Children.Clear();
                grd.Children.Add(us);
            }
            else
            {
                grd.Children.Add(us);
            }
        }
    }
}
