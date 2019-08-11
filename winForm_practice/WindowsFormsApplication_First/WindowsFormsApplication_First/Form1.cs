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
        public Form1()
        {
            InitializeComponent();
        }

        #region CreateCSV https://immortalcoder.blogspot.com/2013/02/create-csv-file-from-datatable-in.html
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

                sw.Write(sw.NewLine);

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

                    sw.Write(sw.NewLine);
                }

                sw.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "TXT|*.txt", ValidateNames = true })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (var sw = new StreamWriter(sfd.FileName))
                        {
                            #region 1. Link Youtube

                            //var writer = new CsvWriter(sw);
                            //writer.WriteHeader(typeof(Student));

                            //foreach (Student s in studentBindingSource.DataSource as List<Student>)
                            //{
                            //    writer.WriteRecord(s);
                            //}

                            #endregion

                            #region xuat csv file
                            //try
                            //{
                            //    //StreamWriter sw = new StreamWriter(sw, false);
                            //        //int columnCount = dt.Columns.Count;
                            //    int columnCount = dataGridView1.Columns.Count;

                            //    for (int i = 0; i < columnCount; i++)
                            //    {
                            //        sw.Write(i);

                            //        if (i < columnCount - 1)
                            //        {
                            //            sw.Write(",");
                            //        }
                            //    }

                            //    sw.Write(sw.NewLine);

                            //    //foreach (DataRow dr in dt.Rows)
                            //    for(int indexRow = 0; indexRow < dataGridView1.Rows.Count ; indexRow++)
                            //    {
                            //        for (int i = 0; i < columnCount; i++)
                            //        {

                            //            //if (!Convert.IsDBNull(dr[i]))
                            //            //{

                            //                //sw.Write(dr[i].ToString());

                            //                sw.Write(dataGridView1.Rows[indexRow].Cells[i].Value);
                            //            //}

                            //            if (i < columnCount - 1)
                            //            {
                            //                sw.Write(",");
                            //            }
                            //        }

                            //        sw.Write(sw.NewLine);
                            //    }

                            //    sw.Close();
                            //}
                            //catch (Exception ex)
                            //{
                            //    throw ex;
                            //}

                            #endregion

                            #region xuat txt file
                            //Pass the filepath and filename to the StreamWriter Constructor
                            //StreamWriter sw = new StreamWriter("C:\\Test.txt");

                            ////Write a line of text
                            //sw.WriteLine("Hello World!!");

                            ////Write a second line of text
                            //sw.WriteLine("From the StreamWriter class");

                            int columnCount = dataGridView1.Columns.Count;

                            for (int i = 0; i < columnCount; i++)
                            {
                                
                                string kk = dataGridView1.Columns[i].HeaderText;
                                sw.Write(kk);

                                if (i < columnCount - 1)
                                {
                                    sw.Write("\t");
                                }
                            }

                            sw.Write(sw.NewLine);
                            
                            for (int indexRow = 0; indexRow < dataGridView1.Rows.Count; indexRow++)
                            {
                                for (int i = 0; i < columnCount; i++)
                                {
                                    sw.Write(dataGridView1.Rows[indexRow].Cells[i].Value);

                                    if (i < columnCount - 1)
                                    {
                                        sw.Write("\t");
                                    }
                                }

                                sw.Write(sw.NewLine);
                            }

                            //Close the file
                            sw.Close();
                            #endregion
                        }
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
            studentBindingSource.DataSource = new List<Student>();
        }

        // Btn Read CSV to DataGrid
        private void button2_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "CSV|*.csv", ValidateNames = true})
            {
                if(ofd.ShowDialog() == DialogResult.OK)
                {

                    #region 1. Link youtube
                    //var sr = new StreamReader(new FileStream(ofd.FileName, FileMode.Open));
                    //var csv = new CsvReader(sr);
                    //csv.Read();
                    //studentBindingSource.DataSource = csv.GetRecord<Student>();
                    #endregion

                    StreamReader sr = new StreamReader(ofd.FileName);
                    string[] headers = sr.ReadLine().Split(',');

                    DataTable dt = new DataTable();
                    
                    foreach (string header in headers)
                    {
                        //dt.Columns.Add(header);
                        dataGridView1.Columns.Add("abc1",header);

                    }
                    while (!sr.EndOfStream)
                    {
                        string[] rows = Regex.Split(sr.ReadLine(), ",(?=(?:[^\"]*\"[^\"]*\")*[^\"]*$)");

                        int indexRow = dataGridView1.Rows.Add();

                        for (int i = 0; i < headers.Length; i++)
                        {
                            //https://www.youtube.com/watch?v=WVLL1xa6Ryo
                            dataGridView1.Rows[indexRow].Cells[i].Value = rows[i];
                        }

                    }


                }
            }
        }


        //public static DataTable ConvertCSVtoDataTable(string strFilePath)
        //{
        //    StreamReader sr = new StreamReader(strFilePath);
        //    string[] headers = sr.ReadLine().Split(',');
        //    DataTable dt = new DataTable();
        //    foreach (string header in headers)
        //    {
        //        dt.Columns.Add(header);
        //    }
        //    while (!sr.EndOfStream)
        //    {
        //        string[] rows = Regex.Split(sr.ReadLine(), ",(?=(?:[^\"]*\"[^\"]*\")*[^\"]*$)");
        //        DataRow dr = dt.NewRow();
        //        for (int i = 0; i < headers.Length; i++)
        //        {
        //            dr[i] = rows[i];
        //        }
        //        dt.Rows.Add(dr);
        //    }
        //    return dt;
        //}
    }
}
