using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication_First
{
    public class LinhKienItem
    {
        public BindingSource BindingSourceLK { get; set; }
        public LinhKienItem()
        {
            BindingSourceLK = new BindingSource();
            BindingSourceLK.DataSource = typeof(LinhKienData);
        }
    }
}
