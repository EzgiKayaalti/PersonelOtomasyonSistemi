using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinUI
{
    public static class Metotlar
    {
        public static bool BosAlanVarMi(GroupBox grp) 
        {
            foreach (Control item in grp.Controls)
            {
                if(item is TextBox)
                {
                    if (item.Text.Trim() == "")
                        return true;
                }
                else if(item is DateTimePicker)
                {
                    if(((DateTimePicker)item).Value.Date==DateTime.Now.Date)
                        return true;
                }
                else if(item is ComboBox)
                {
                    if (((ComboBox)item).SelectedIndex == -1)
                        return true;
                }
            }
            return false;
        }
    }
}
