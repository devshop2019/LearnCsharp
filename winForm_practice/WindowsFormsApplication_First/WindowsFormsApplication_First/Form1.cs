using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CsvHelper;
using System.IO;
using System.Text.RegularExpressions;

/*
 * OK:
 * https://support.microsoft.com/vi-vn/help/816149/how-to-read-from-and-write-to-a-text-file-by-using-visual-c
 * https://immortalcoder.blogspot.com/2013/02/create-csv-file-from-datatable-in.html
 * https://foxlearn.com/windows-forms/read-csv-file-in-csharp-382.html
 * 
 * 
 * https://www.youtube.com/watch?v=96kHaIUMTEk
 * https://stackoverflow.com/questions/11086942/using-csvhelper-on-file-upload
 * 
 * Chưa test
 * https://immortalcoder.blogspot.com/2013/12/convert-csv-file-to-datatable-in-c.html
 * https://foxlearn.com/windows-forms/read-csv-file-in-csharp-382.html
 * 
 * http://csharp.net-informations.com/datagridview/csharp-datagridview-filter.htm
 * 
 */

namespace WindowsFormsApplication_First
{
    public partial class Form1 : Form
    {
        public LinhKienManager LKManager { get; set; }
        public int testValue { get; set; }

        public Form1()
        {
            InitializeComponent();

            LKManager = new LinhKienManager();
            dataGridView1.DataSource = LKManager.LKListImport.BindingSourceLK;
            dataGridView2.DataSource = LKManager.PartListImport.BindingSourcePart;
            cb_Part.DataSource = LKManager.PartListImport.BindingSourcePart;
            cb_Part.DisplayMember = "Part";
            #region chua chay dc
            //ComBobox_partName.ComboBox.DataSource = LKManager.PartListImport.BindingSourcePart;
            #endregion

            setupContextMenu();
        }

        public void setupContextMenu ()
        {
            //ComBobox_partName.Width = 400;
            contextMenuStrip1.Width = 900;
            var itemTem = new ToolStripButton() { Text = "Change LK", AutoSize = true};
            itemTem.Click += btnContext_Edit_LK_Click;
            contextMenuStrip1.Items.Add(itemTem);

            var btn_deleteRow = new ToolStripButton() { Text = "Delete LK", AutoSize = true };
            btn_deleteRow.Click += DeleteRowLK;
            contextMenuStrip1.Items.Add(btn_deleteRow);
        }

        private void DeleteRowLK(object sender, EventArgs e)
        {
            LKManager.LKListImport.BindingSourceLK.RemoveCurrent();
        }

        private void btnContext_Edit_LK_Click(object sender, EventArgs e)
        {
            cb_Part.SelectedIndex = ComBobox_partName.SelectedIndex;
            LKManager.EditLinhKien();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "TXT|*.txt|CSV|*.csv", ValidateNames = true })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        #region Get Extension file
                        // https://stackoverflow.com/questions/4990910/how-to-get-file-extension-from-save-file-dialog
                        var extension = Path.GetExtension(sfd.FileName);

                        switch (extension.ToLower())
                        {
                            case ".txt":
                                MessageBox.Show(string.Format("txt: {0}", extension.ToLower()));
                                LKManager.WriteLinhKienItemToTxt(LKManager.LKListImport, sfd.FileName);
                                break;
                            case ".csv":
                                // ToDo: Save as PNG
                                //MessageBox.Show(string.Format("csv: {0}", extension.ToLower()));
                                LKManager.WriteLinhKienItemToCsv(LKManager.LKListImport, sfd.FileName);
                                break;
                            default:
                                throw new ArgumentOutOfRangeException(extension);
                        }
                        #endregion

                        #region Save to TXT
                        //LKManager.WriteLinhKienItemToTxt(LKManager.LKListImport, sfd.FileName);
                        #endregion

                    }
                    catch (Exception e44)
                    {
                        Console.WriteLine("Exception: " + e44.Message);
                    }
                    finally
                    {
                        Console.WriteLine("Executing finally block.");
                    }
                }
                    MessageBox.Show("Đã lưu Data", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

            //try
            //{
            //    // Create an instance of StreamReader to read from a file.
            //    // The using statement also closes the StreamReader.
            //    using (StreamReader sr = new StreamReader("TestFile.txt"))
            //    {
            //        string line;
            //        // Read and display lines from the file until the end of 
            //        // the file is reached.
            //        while ((line = sr.ReadLine()) != null)
            //        {
            //            Console.WriteLine(line);
            //        }
            //    }
            //}
            //catch (Exception e)
            //{
            //    // Let the user know what went wrong.
            //    Console.WriteLine("The file could not be read:");
            //    Console.WriteLine(e.Message);
            //}
        

        private void Form1_Load(object sender, EventArgs e)
        {
            //studentBindingSource.DataSource = new List<Student1>();
        }

        
        private void button2_Click(object sender, EventArgs e)
        {
            #region   Btn Read CSV to DataGrid
            //using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "CSV|*.csv", ValidateNames = true })
            //{
            //    if (ofd.ShowDialog() == DialogResult.OK)
            //    {
            //        StreamReader sr = new StreamReader(ofd.FileName);
            //        string[] headers = sr.ReadLine().Split(',');

            //        DataTable dt = new DataTable();

            //        foreach (string header in headers)
            //        {
            //            //dt.Columns.Add(header);
            //            dataGridView1.Columns.Add("abc1", header);

            //        }
            //        while (!sr.EndOfStream)
            //        {
            //            string[] rows = Regex.Split(sr.ReadLine(), ",(?=(?:[^\"]*\"[^\"]*\")*[^\"]*$)");

            //            int indexRow = dataGridView1.Rows.Add();

            //            for (int i = 0; i < headers.Length; i++)
            //            {
            //                //https://www.youtube.com/watch?v=WVLL1xa6Ryo
            //                dataGridView1.Rows[indexRow].Cells[i].Value = rows[i];
            //            }
            //        }
            //    }
            //}
            #endregion

            #region Read CSV LinhKien
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "CSV|*.csv", ValidateNames = true })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    LKManager.ReadCsvFileToLinhKien(ofd.FileName);
                }
            }
            #endregion
        }

        public void CreateCSVFile(DataTable dt, string strFilePath)
        {
            try
            {
                StreamWriter sw = new StreamWriter(strFilePath, false);
                int columnCount = dt.Columns.Count;

                for (int i = 0; i < columnCount; i++)
                {
                    sw.Write(dt.Columns[i]);

                    if (i < columnCount - 1)
                    {
                        sw.Write(",");
                    }
                }

                //sw.Write(sw.NewLine);

                foreach (DataRow dr in dt.Rows)
                {
                    for (int i = 0; i < columnCount; i++)
                    {
                        if (!Convert.IsDBNull(dr[i]))
                        {
                            sw.Write(dr[i].ToString());
                        }

                        if (i < columnCount - 1)
                        {
                            sw.Write(",");
                        }
                    }

                    //sw.Write(sw.NewLine);
                }

                sw.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void CreateCSVFile2(DataGridView dt, string strFilePath)
        {
            try
            {
                StreamWriter sw = new StreamWriter(strFilePath, false);
                int columnCount = dt.ColumnCount;
                //int columnCount = dt.Columns.Count;
                Console.WriteLine("Row count: {0}, Column count: {1}", dt.RowCount, dt.ColumnCount);

                for (int i = 0; i < columnCount; i++)
                {
                    sw.Write(dt.Columns[i].HeaderText);

                    if (i < columnCount - 1)
                    {
                        sw.Write(",");
                    }
                }

                //sw.Write(sw.NewLine);

                /*dt.Rows[1].Cells[2].Value*/;

                for (int index = 0; index <dt.RowCount; index++)
                {
                    for (int i = 0; i < columnCount; i++)
                    {
                        if (dt.Rows[index].Cells[i].Value != null)
                        {
                            sw.Write(dt.Rows[index].Cells[i].Value.ToString());
                        }

                        if (i < columnCount - 1)
                        {
                            sw.Write(",");
                            //Console.WriteLine("Row count: {0}, Column count: {1} data: {2}", dt.RowCount, dt.ColumnCount, dt.Rows[index].Cells[i].Value.ToString());
                        }
                    }

                    sw.Write(sw.NewLine);
                }

                sw.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable ReadCsvFile(string file)
        {
            DataTable dt = new DataTable();
            using (StreamReader streamReader = new StreamReader(file))
            {
                while (!streamReader.EndOfStream)
                {
                    string text = streamReader.ReadToEnd();
                    string[] rows = text.Split('\n');
                    if (rows.Length > 0)
                    {
                        //Add columns
                        string[] columns = rows[0].Split(',');
                        for (int j = 0; j < columns.Count(); j++)
                            dt.Columns.Add(columns[j]);
                        //Add rows
                        for (int i = 1; i < rows.Count() - 1; i++)
                        {
                            string[] data = rows[i].Split(',');
                            DataRow dr = dt.NewRow();
                            for (int k = 0; k < data.Count(); k++)
                                dr[k] = data[k];
                            dt.Rows.Add(dr);
                        }
                    }
                }
            }
            return dt;
        }

        private void btn_ReadPartCsv_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "CSV file|*.csv" })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    //dataGridView2.DataSource = ReadCsvFile(ofd.FileName);
                    LKManager.ReadCsvFileToPart(ofd.FileName);
                }
            }
        }

        private void btn_writeCsvPart_Click(object sender, EventArgs e)
        {
            
            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "CSV|*.csv", ValidateNames = true })
            {
                if(sfd.ShowDialog() == DialogResult.OK)
                {
                    //CreateCSVFile((DataTable)dataGridView2.DataSource, sfd.FileName);
                    //CreateCSVFile((DataTable)dataGridView2.DataSource, "I://ConvertedFile.csv");

                    //CreateCSVFile2(dataGridView2, sfd.FileName);
                    LKManager.WritePartItemToCsv(LKManager.PartListImport,sfd.FileName);
                    MessageBox.Show("Đã lưu Csv 2", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                
            }
        }

        private void dataGridView2_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            Console.WriteLine("Row added: count {0}, index: {1}", e.RowCount,e.RowIndex);

            int count_ = dataGridView2.RowCount;

            //DataTable mydt = (DataTable)dataGridView2.DataSource;

            //MessageBox.Show("count " + Convert.ToString(count_) + "uu " + Convert.ToString(mydt.Rows.Count), "Thông báo add", MessageBoxButtons.OK, MessageBoxIcon.Information);

            ComBobox_partName.Items.Clear();

            foreach (PartData pd in LKManager.PartListImport.BindingSourcePart)
            {
                ComBobox_partName.Items.Add(pd.Part);
            }
        }

        private void dataGridView2_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {
            MessageBox.Show("dataGridView2_UserAddedRow", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
        }

        private void dataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (dataGridView2.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            //{
            //    string dataStr = dataGridView2.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                //Console.WriteLine("Row:{0} Col: {1}, data: {2}", e.RowIndex, e.ColumnIndex, dataStr);
                Constant_LK.debug("Row:{0} Col: {1} dataGridView2 double click", e.RowIndex, e.ColumnIndex);
            //}
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_selectSameName_Click(object sender, EventArgs e)
        {
            bool isSelect = dataGridView1.Rows[1].Cells[1].Selected;

        }

        private void btn_Edit_LK_Click(object sender, EventArgs e)
        {
            LKManager.EditLinhKien();
        }

        private void btnUpdatePart_Click(object sender, EventArgs e)
        {
            LKManager.EditPart();
        }

        private void dataGridView2_DataMemberChanged(object sender, EventArgs e)
        {
            
        }
    }
}
