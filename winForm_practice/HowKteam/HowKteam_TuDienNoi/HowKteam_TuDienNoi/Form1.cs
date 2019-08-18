using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HowKteam_TuDienNoi
{
    public partial class Form1 : Form
    {
        DictionaryManager dictionary;
        public Form1()
        {
            InitializeComponent();
            cb_Word.DisplayMember = "Key";
            dictionary = new DictionaryManager();
            dictionary.LoadDataToCombobox(cb_Word);

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if ( MessageBox.Show("Bạn có chắc muốn thoát?","Thông báo",MessageBoxButtons.OKCancel) != DialogResult.OK)
            {
                e.Cancel = true;
                return;
            }

            dictionary.Serialize();
        }

        private void cb_Word_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb = sender as ComboBox;

            if (cb.DataSource == null)
            {
                return;
            }

            DictionaryData data = cb.SelectedItem as DictionaryData;

            txb_Meaning.Text = data.Meaning;
            txb_explaning.Text = data.Explaination;

        }
    }
}
