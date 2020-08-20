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

        public LinhKienData markPoint_set { get; set; }
        public LinhKienItem LKListImport { get; set; }
        public LinhKienItem LKListExport { get; set; }
        public PartItem PartListImport { get; set; }
        public PartItem PartListExport { get; set; }
        public HashSet<string> ListValue = new HashSet<string>();
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
            markPoint_set = new LinhKienData();
        }

        public void setMarkPoint_LKdata()
        {
            LinhKienData temData = (LinhKienData)LKListImport.BindingSourceLK.Current;
            markPoint_set = temData;
            //markPoint_set.Value = Constant_LK.VALUE_DEFAULT;
        }

        public void LoadLinhKienToDataGrid(DataGridView dataView_)
        {
            dataView_.DataSource = LKListImport.BindingSourceLK;
        }

        public void EditLinhKien()
        {
            //Sửa thuộc tính của dòng đang chọn
            //((Class1)class1BindingSource.Current).ThuocTinh2 = "sửa";
            string temNamePart = ((PartData)PartListImport.BindingSourcePart.Current).Part;
            string temNameLinhKien = ((LinhKienData)LKListImport.BindingSourceLK.Current).ValueOld;

            int temDeltaAngle = Convert.ToInt32(((PartData)PartListImport.BindingSourcePart.Current).DeltaAngleAtFeeder1);
            string strFeederid = ((PartData)PartListImport.BindingSourcePart.Current).Feeder;
            int temFeederID = strFeederid!=""?Convert.ToInt32(strFeederid) :0;
            int temSideFeeder1ID_MaX = 26;

            byte temMiror = ((PartData)PartListImport.BindingSourcePart.Current).FoodPrintInfo.Mirror;

            foreach (LinhKienData temLK in LKListImport.BindingSourceLK)
            {
                if (temLK.ValueOld == temNameLinhKien)
                {
                    temLK.Value = temNamePart;
                    temLK.AngelNew = (Convert.ToInt32(temLK.AngelOld) + temDeltaAngle).ToString();

                    //int angle = Convert.ToInt32(temLK.AngelOld) + temDeltaAngle;
                    int angle = temDeltaAngle - Convert.ToInt32(temLK.AngelOld);

                    if (temFeederID > temSideFeeder1ID_MaX)
                    {
                        angle = 180 + angle;
                    }

                    if (angle > 180) angle = angle - 360;

                    if ((angle == -360) || (angle == 360)) angle = 0;
                    else if (angle < -180) angle = 360 + angle;
                    //else if (angle < -360) angle = 360 + angle;
                    else if (angle == -180) angle = 180;

                    if (temMiror == Constant_LK.FootPrint_Miror)
                    {
                        if ((angle == -180) || (angle == 180)) angle = 0;
                    }

                    temLK.AngelNew = angle.ToString();
                }
            }
                
            // Display DataGridView
            LKListImport.BindingSourceLK.ResetBindings(true);
        }
        public void EditPart()
        {
            foreach (PartData temPart in PartListImport.BindingSourcePart)
            {
                string temNameLinhKien = temPart.Part;
                int temDeltaAngle = Convert.ToInt32(temPart.DeltaAngleAtFeeder1);
                int temFeederID = temPart.Feeder != ""?Convert.ToInt32(temPart.Feeder):0;
                int temSideFeeder1ID_MaX = 26;
                //byte temMiror = ((PartData)PartListImport.BindingSourcePart.Current).FoodPrintInfo.Mirror;
                byte temMiror = temPart.FoodPrintInfo.Mirror;

                foreach (LinhKienData temLK in LKListImport.BindingSourceLK)
                {
                    if (temLK.Value == temNameLinhKien)
                    {
                        //int angle = Convert.ToInt32(temLK.AngelOld) + temDeltaAngle;

                        int angle = temDeltaAngle - Convert.ToInt32(temLK.AngelOld);

                        if (temFeederID > temSideFeeder1ID_MaX)
                        {
                            angle = 180 + angle;
                        }

                        if (angle > 180) angle = angle - 360;

                        if ((angle == -360) || (angle == 360)) angle = 0;
                        else if (angle < -180) angle = 360 + angle;
                        //else if (angle < -360) angle = 360 + angle;
                        else if (angle == -180) angle = 180;

                        if (temMiror == Constant_LK.FootPrint_Miror)
                        {
                            if ((angle == -180) || (angle == 180)) angle = 0;
                        }

                        temLK.AngelNew = angle.ToString();
                    }
                }
            }

            LKListImport.BindingSourceLK.ResetBindings(true);
        }

        public void WriteCsvToDataGrid(DataGridView dt, string strFilePath)
        {
            
        }

        //

        public void WriteDataGridToTxt(DataGridView dt, string strFilePath)
        {
            using (var sw = new StreamWriter(strFilePath))
            {
                #region xuat txt file chuẩn Kayo
                int columnCount = dt.Columns.Count;

                for (int i = 0; i < columnCount; i++)
                {

                    string kk = dt.Columns[i].HeaderText;
                    sw.Write(kk);

                    if (i < columnCount - 1)
                    {
                        sw.Write(" ");
                    }
                }

                sw.Write(sw.NewLine);

                for (int indexRow = 0; indexRow < dt.Rows.Count; indexRow++)
                {
                    for (int i = 0; i < columnCount; i++)
                    {
                        var temDataStr = dt.Rows[indexRow].Cells[i].Value.ToString().TrimEnd();
                        //if (temDataStr != "")
                        //{
                            //sw.Write(temDataStr);
                            sw.Write(dt.Rows[indexRow].Cells[i].ToString().Trim());
                        //}
                        //else
                        //{
                        //    sw.Write("N/A");
                        //}


                        if (i < columnCount - 1)
                        {
                            sw.Write(" ");
                        }
                    }
                    sw.Write(sw.NewLine);
                }
                //Close the file
                sw.Close();
                #endregion
            }
        }

        public void WriteLinhKienItemToTxt(LinhKienItem dt, string strFilePath)
        {
            using (var sw = new StreamWriter(strFilePath))
            {
                #region xuat txt file chuẩn Kayo
                LinhKienData temLK1 = new LinhKienData();

                sw.Write(temLK1.GetHeaderStringTo_TXT());

                //foreach (LinhKienData temLK in LKListImport.BindingSourceLK)
                foreach (LinhKienData temLK in dt.BindingSourceLK)
                {
                    sw.Write(temLK.GetStringTo_TXT());

                }
                sw.Close();
                #endregion
            }
        }

        public void WriteKeyWordLinhKienItemToTxt(LinhKienItem listLK, string strFilePath)
        {
            using (var sw = new StreamWriter(strFilePath))
            {
                #region xuat txt file chuẩn Kayo
                sw.Write(ExportLinhKienToKeyWord(listLK));
                sw.Close();
                #endregion
            }
        }

        public void WriteLinhKienItemToCsv(LinhKienItem dt, string strFilePath)
        {
            using (var sw = new StreamWriter(strFilePath))
            {
                #region xuat csv file
                
                LinhKienData temLK1 = new LinhKienData();

                sw.Write(temLK1.GetHeaderStringTo_Csv());

                foreach (LinhKienData temLK in dt.BindingSourceLK)
                {
                    sw.Write(temLK.GetStringTo_CSV());
                }

                sw.Close();
                #endregion
            }
        }

        public void Duplicate_Part_Data()
        {
            PartData temPartdata = new PartData((PartData)PartListImport.BindingSourcePart.Current);
            PartListImport.BindingSourcePart.Add(temPartdata);
            PartListImport.BindingSourcePart.ResetBindings(true);
        }

        public void WritePartItemToCsv(PartItem dt, string strFilePath)
        {
            using (var sw = new StreamWriter(strFilePath))
            {
                #region xuat csv file

                PartData temPart1 = new PartData();

                sw.Write(temPart1.GetHeaderStringTo_Csv());

                foreach (PartData temPart in PartListImport.BindingSourcePart)
                {
                    sw.Write(temPart.GetStringTo_CSV());
                }

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
                                string temData = data[k];
                                if (data[k].IndexOf("\r") >-1)
                                {
                                    temData = data[k].Remove(data[k].IndexOf('\r'));
                                }

                                if (columns[k].IndexOf(Constant_LK.Posistion) > -1)
                                {
                                    temLinhKien.Posistion = temData;
                                }
                                else if (columns[k].IndexOf(Constant_LK.MidX) > -1)
                                {
                                    temLinhKien.MidX = temData;
                                }
                                else if (columns[k].IndexOf(Constant_LK.MidY) > -1)
                                {
                                    temLinhKien.MidY = temData;
                                }
                                else if (columns[k].IndexOf(Constant_LK.AngelOld) > -1)
                                {
                                    temLinhKien.AngelOld = temData;
                                }
                                else if (columns[k].IndexOf(Constant_LK.Value) > -1)
                                {
                                    temLinhKien.Value = temData;
                                    if (temLinhKien.ValueOld == "NoValueOld")
                                    {
                                        temLinhKien.ValueOld = temData;
                                    }
                                    //temLinhKien.FootPrint = temData;
                                }
                                else if (columns[k].IndexOf(Constant_LK.ValueOld) > -1)
                                {
                                    temLinhKien.ValueOld = temData;
                                }
                                #endregion
                                dr[k] = temData;
                                
                            }

                            LKListImport.BindingSourceLK.Add(temLinhKien);     // Add linh kiện vừa Import
                            //LKListImport.BindingSourceLK.Sort = "ValueOld ASC, Posistion DESC";
                            //LKListImport.BindingSourceLK.Sort = "MidX DESC, Posistion DESC";
                            //LKListImport.BindingSourceLK.Sort = "ValueOld ASC";
                            dt.Rows.Add(dr);
                        }
                    }
                }
            }
            markPoint_set.Posistion = Constant_LK.POS_DEFAULT; // Reset markPoint_set

            //MessageBox.Show(string.Format("Sort status: {0}", LKListImport.BindingSourceLK.SupportsAdvancedSorting));
            //LKListImport.BindingSourceLK.Sort = "ValueOld ASC";
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

                            for (int k = 0; k < columns.Count(); k++)
                            {
                                #region Lấy data Linh kiện dang Import
                                string temData = data[k];
                                if (data[k].IndexOf("\r") > -1)
                                {
                                    temData = data[k].Remove(data[k].IndexOf('\r'));
                                }

                                if (columns[k].IndexOf(Constant_LK.Part) > -1)
                                {
                                    temPart.Part = temData;
                                }
                                else if (columns[k] == Constant_LK.Feeder)
                                {
                                    temPart.Feeder = temData;
                                }
                                else if (columns[k].IndexOf(Constant_LK.PickupHight) > -1)
                                {
                                    temPart.PickupHight = temData;
                                }
                                else if (columns[k].IndexOf(Constant_LK.PickupSpeed) > -1)
                                {
                                    temPart.PickupSpeed = temData;
                                }
                                else if (columns[k].IndexOf(Constant_LK.PickupDelay) > -1)
                                {
                                    temPart.PickupDelay = temData;
                                }
                                else if (columns[k].IndexOf(Constant_LK.PasteHight) > -1)
                                {
                                    temPart.PasteHight = temData;
                                }
                                else if (columns[k].IndexOf(Constant_LK.PasteSpeed) > -1)
                                {
                                    temPart.PasteSpeed = temData;
                                }
                                else if (columns[k].IndexOf(Constant_LK.PasteDelay) > -1)
                                {
                                    temPart.PasteDelay = temData;
                                }
                                else if (columns[k].IndexOf(Constant_LK.Visual) > -1)
                                {
                                    temPart.Visual = temData;
                                }
                                else if (columns[k].IndexOf(Constant_LK.DeltaAngleAtFeeder1) > -1)
                                {
                                    temPart.DeltaAngleAtFeeder1 = temData;
                                }
                                else if (columns[k].IndexOf(Constant_LK.FootPrintName) > -1)
                                {
                                    temPart.FootPrintName = temData;
                                }
                                else if (columns[k].IndexOf(Constant_LK.FootPrintValue) > -1)
                                {
                                    if (temData.IndexOf(Constant_LK.END_SYMBOL_FOOTPRINT_DEFAULT) == -1)
                                        temPart.FootPrintValue = temData + "]"; // kxn n12/12/2019
                                    else temPart.FootPrintValue = temData;
                                    temPart.FoodPrintInfo.getValueFromString(temData);
                                }
                                #endregion
                                dr[k] = temData;

                            }

                            PartListImport.BindingSourcePart.Add(temPart);     // Add linh kiện vừa Import
                            dt.Rows.Add(dr);
                        }
                    }
                }
            }
            return dt;
        }

        public void ExportLinhKienToPanelLine(LinhKienItem dt ,float _longX, float _longY, int _numberX, int _numberY)
        {
            if (dt.BindingSourceLK.Count < 1)
            {
                return;
            }

            LKListExport.BindingSourceLK.Clear();

            int temCount = 0;

            for (int cf_y = 0; cf_y < _numberY; cf_y++)
            {
                for (int cf_x = 0; cf_x < _numberX; cf_x++)
                {
                    temCount++;

                    foreach (LinhKienData temLKData in dt.BindingSourceLK)
                    {
                        // remote mm
                        LinhKienData temDataExport = new LinhKienData(temLKData);

                        float temMidX = Convert.ToSingle(temLKData.MidX.Remove(temLKData.MidX.IndexOf("mm")));
                        float temMidY = Convert.ToSingle(temLKData.MidY.Remove(temLKData.MidY.IndexOf("mm")));

                        temMidX = temMidX + _longX * cf_x;
                        temMidY = temMidY - _longY * cf_y;  // n30/11/2019  Y phải nhỏ dần
                        //temMidY = temMidY + _longY * cf_y;

                        temDataExport.Posistion = string.Format("{0}_{1}", temCount, temLKData.Posistion);
                        //temDataExport.Posistion = string.Format("{0}_{1}", temLKData.Posistion, temCount);
                        //temDataExport.AngelNew = temLKData.AngelNew;
                        //temDataExport.AngelOld = temLKData.AngelOld;
                        //temDataExport.Value = temLKData.Value;
                        //temDataExport.ValueOld = temLKData.ValueOld;
                        temDataExport.MidX = string.Format("{0}mm", temMidX);
                        temDataExport.MidY = string.Format("{0}mm", temMidY);


                        LKListExport.BindingSourceLK.Add(temDataExport);

                    }
                }
            }
            LKListExport.BindingSourceLK.ResetBindings(true);
        }

        public void ExportLinhKienToPanelLine_2(LinhKienItem dt, float _longX, float _longY, int _numberX, int _numberY)
        {
            if (dt.BindingSourceLK.Count < 1)
            {
                return;
            }

            if (markPoint_set.Posistion == Constant_LK.POS_DEFAULT)
            {
                MessageBox.Show("Vui lòng set Mark point", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            LKListExport.BindingSourceLK.Clear();

            #region Add Markpoint import & Markpoint Array

            for (int cf_y = 0; cf_y < _numberY; cf_y++)
            {
                for (int cf_x = 0; cf_x < _numberX; cf_x++)
                {
                    if ((cf_x == 0 && cf_y == 0) ||
                        (cf_x == (_numberX - 1) && cf_y == 0) ||
                        (cf_x == 0 && cf_y == (_numberY - 1)) ||
                        (cf_x == (_numberX - 1) && cf_y == (_numberY - 1)))
                    {
                        LinhKienData temLKData = markPoint_set;

                        // remote mm
                        LinhKienData temDataExport = new LinhKienData(temLKData);

                        float temMidX = Convert.ToSingle(temLKData.MidX.Remove(temLKData.MidX.IndexOf("mm")));
                        float temMidY = Convert.ToSingle(temLKData.MidY.Remove(temLKData.MidY.IndexOf("mm")));

                        temMidX = temMidX + _longX * cf_x;
                        temMidY = temMidY - _longY * cf_y;  // n30/11/2019  Y phải nhỏ dần
                                                            //temMidY = temMidY + _longY * cf_y;

                        string temName = "";
                        if ((cf_x == 0) && (cf_y == 0))
                        {
                            temName = string.Format("MarkPoint{0}_{1}", "UP", "L");
                        }
                        else if ((cf_x == (_numberX - 1)) && (cf_y == 0))
                        {
                            temName = string.Format("MarkPoint{0}_{1}", "UP", "R");
                        }
                        else if ((cf_x == 0) && (cf_y == (_numberY - 1)))
                        {
                            temName = string.Format("MarkPoint{0}_{1}", "DOWN", "L");
                        }
                        else if ((cf_x == (_numberX - 1)) && (cf_y == (_numberY - 1)))
                        {
                            temName = string.Format("MarkPoint{0}_{1}", "DOWN", "R");
                        }
                        else;

                            temDataExport.Posistion = string.Format("{0}_{1}", temName, temLKData.Posistion);
                        temDataExport.MidX = string.Format("{0}mm", temMidX);
                        temDataExport.MidY = string.Format("{0}mm", temMidY);
                        temDataExport.Value = Constant_LK.VALUE_DEFAULT;


                        LKListExport.BindingSourceLK.Add(temDataExport);
                    }

                    
                }
            }

            #endregion Add Markpoint import & Markpoint Array

            int temCount = 0;

            //for (int cf_y = 0; cf_y < _numberY; cf_y++)
            //{
            //    for (int cf_x = 0; cf_x < _numberX; cf_x++)
            //    {
            //        temCount++;

                    foreach (LinhKienData temLKData in dt.BindingSourceLK)
                    {
                        // remote mm
                        LinhKienData temDataExport = new LinhKienData(temLKData);

                        //float temMidX = Convert.ToSingle(temLKData.MidX.Remove(temLKData.MidX.IndexOf("mm")));
                        //float temMidY = Convert.ToSingle(temLKData.MidY.Remove(temLKData.MidY.IndexOf("mm")));

                        //temMidX = temMidX + _longX * cf_x;
                        //temMidY = temMidY - _longY * cf_y;  // n30/11/2019  Y phải nhỏ dần
                        //temMidY = temMidY + _longY * cf_y;

                        //temDataExport.Posistion = string.Format("{0}_{1}", temCount, temLKData.Posistion);
                        
                        //temDataExport.MidX = string.Format("{0}mm", temMidX);
                        //temDataExport.MidY = string.Format("{0}mm", temMidY);


                        LKListExport.BindingSourceLK.Add(temDataExport);

                    }
            //    }
            //}
            LKListExport.BindingSourceLK.ResetBindings(true);
        }


        public string ExportLinhKienToKeyWord(LinhKienItem listLK)
        {
            string temExportString = "";
            ListValue.Clear();
            foreach (LinhKienData temLKdata in listLK.BindingSourceLK)
            {
                ListValue.Add(temLKdata.Value);
            }

            foreach (string temValueLK in ListValue)
            {
                foreach (LinhKienData temLKdata in listLK.BindingSourceLK)
                {
                    if (temValueLK == temLKdata.Value)
                    {
                        temExportString += string.Format("{0},", temLKdata.Posistion);
                    }
                }
                temExportString += string.Format("\r\n======>{0}<======\r\n\r\n", temValueLK);
            }

            return temExportString;
        }

        #endregion
    }
}
