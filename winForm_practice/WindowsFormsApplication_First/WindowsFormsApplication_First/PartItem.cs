using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication_First
{
    public class PartItem
    {
        public BindingSource BindingSourcePart { get; set; }
        public PartItem()
        {
            BindingSourcePart = new BindingSource();
            BindingSourcePart.DataSource = typeof(PartData);
        }
    }
}
