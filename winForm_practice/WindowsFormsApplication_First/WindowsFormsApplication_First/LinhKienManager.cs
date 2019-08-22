using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Data;

namespace WindowsFormsApplication_First
{
    public class LinhKienManager
    {
        #region Property
        public LinhKienItem LKListImport { get; set;}
        public LinhKienItem LKListExport { get; set; }
        public PartItem PartListImport { get; set; }
        public PartItem PartListExport { get; set; }
        private LinhKienItem LKitems;
        public LinhKienItem LKItems
        {
            get
            {
                return LKitems;
            }

            set
            {
                LKitems = value;
            }
        }

        #endregion

        #region Method
        public LinhKienManager()
        {
            LKListImport = new LinhKienItem();
            LKListExport = new LinhKienItem();
            LKitems = new LinhKienItem();
            PartListImport = new PartItem();
        }

        public void LoadLinhKienToDataGrid(DataGridView dataView_)
        {
            dataView_.DataSource = LKListImport.BindingSourceLK;
        }

        public void LoadDataGridToListLinhKien(DataGridView dataView_, LinhKienItem _listLK)
        {
            // get Column Count
            int numCol = dataView_.ColumnCount;

            for (int index = 0; index < dataView_.RowCount; index++)
            {
                for (int i = 0; i < numCol; i++)
                {
                    if (dataView_.Rows[index].Cells[i].Value != null)
                    {
                        //sw.Write(dataView_.Rows[index].Cells[i].Value.ToString());
                    }
                }

                //sw.Write(sw.NewLine);
            }

        }

        public void WriteCsvToDataGrid(DataGridView dt, string strFilePath)
        {
            
        }

        //

        public void WriteDataGridToTxt(DataGridView dt, string strFilePath)
        {
            using (var sw = new StreamWriter(strFilePath))
            {
                #region xuat txt file
                //Pass the filepath and filename to the StreamWriter Constructor
                //StreamWriter sw = new StreamWriter("C:\\Test.txt");

                ////Write a line of text
                //sw.WriteLine("Hello World!!");

                ////Write a second line of text
                //sw.WriteLine("From the StreamWriter class");

                int columnCount = dt.Columns.Count;

                for (int i = 0; i < columnCount; i++)
                {

                    string kk = dt.Columns[i].HeaderText;
                    sw.Write(kk);

                    if (i < columnCount - 1)
                    {
                        sw.Write("\t");
                    }
                }

                sw.Write(sw.NewLine);

                for (int indexRow = 0; indexRow < dt.Rows.Count; indexRow++)
                {
                    for (int i = 0; i < columnCount; i++)
                    {
                        sw.Write(dt.Rows[indexRow].Cells[i].Value);

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

        public void WriteDataGridToCsv(DataGridView dt, string strFilePath)
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

                for (int index = 0; index < dt.RowCount; index++)
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

        public DataTable ReadCsvFileToLinhKien(string file)
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
                        LKListImport.BindingSourceLK.Clear();

                        //Add columns
                        string[] columns = rows[0].Split(',');
                        for (int j = 0; j < columns.Count(); j++)
                        {
                            dt.Columns.Add(columns[j]);
                        }
                            
                        //Add rows
                        for (int i = 1; i < rows.Count() - 1; i++)
                        {
                            string[] data = rows[i].Split(',');
                            DataRow dr = dt.NewRow();
                            LinhKienData temLinhKien = new LinhKienData();

                            for (int k = 0; k < data.Count(); k++)
                            {
                                #region Lấy data Linh kiện dang Import
                                if (columns[k].IndexOf(Constant_LK.Posistion) > -1)
                                {
                                    temLinhKien.Posistion = data[k];
                                }
                                else if (columns[k].IndexOf(Constant_LK.MidX) > -1)
                                {
                                    temLinhKien.MidX = data[k];
                                }
                                else if (columns[k].IndexOf(Constant_LK.MidY) > -1)
                                {
                                    temLinhKien.MidY = data[k];
                                }
                                else if (columns[k].IndexOf(Constant_LK.AngelOld) > -1)
                                {
                                    temLinhKien.AngelOld = data[k];
                                }
                                else if (columns[k].IndexOf(Constant_LK.Value) > -1)
                                {
                                    temLinhKien.Value = data[k];
                                }
                                #endregion
                                dr[k] = data[k];
                                
                            }

                            LKListImport.BindingSourceLK.Add(temLinhKien);     // Add linh kiện vừa Import
                            dt.Rows.Add(dr);
                        }
                    }
                }
            }
            return dt;
        }

        public DataTable ReadCsvFileToPart(string file)
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
                        PartListImport.BindingSourcePart.Clear();

                        //Add columns
                        string[] columns = rows[0].Split(',');
                        for (int j = 0; j < columns.Count(); j++)
                        {
                            dt.Columns.Add(columns[j]);
                        }

                        //Add rows
                        for (int i = 1; i < rows.Count() - 1; i++)
                        {
                            string[] data = rows[i].Split(',');
                            DataRow dr = dt.NewRow();
                            PartData temPart = new PartData();

                            for (int k = 0; k < data.Count(); k++)
                            {
                                #region Lấy data Linh kiện dang Import
                                if (columns[k].IndexOf(Constant_LK.Part) > -1)
                                {
                                    temPart.Part = data[k];
                                }
                                else if (columns[k].IndexOf(Constant_LK.PickupHight) > -1)
                                {
                                    temPart.PickupHight = data[k];
                                }
                                else if (columns[k].IndexOf(Constant_LK.PickupSpeed) > -1)
                                {
                                    temPart.PickupSpeed = data[k];
                                }
                                else if (columns[k].IndexOf(Constant_LK.PickupDelay) > -1)
                                {
                                    temPart.PickupDelay = data[k];
                                }
                                else if (columns[k].IndexOf(Constant_LK.PasteHight) > -1)
                                {
                                    temPart.PasteHight = data[k];
                                }
                                else if (columns[k].IndexOf(Constant_LK.PasteSpeed) > -1)
                                {
                                    temPart.PasteSpeed = data[k];
                                }
                                else if (columns[k].IndexOf(Constant_LK.PasteDelay) > -1)
                                {
                                    temPart.PasteDelay = data[k];
                                }
                                else if (columns[k].IndexOf(Constant_LK.Visual) > -1)
                                {
                                    temPart.Visual = data[k];
                                }
                                #endregion
                                dr[k] = data[k];

                            }

                            PartListImport.BindingSourcePart.Add(temPart);     // Add linh kiện vừa Import
                            dt.Rows.Add(dr);
                        }
                    }
                }
            }
            return dt;
        }
        #endregion
    }
}
