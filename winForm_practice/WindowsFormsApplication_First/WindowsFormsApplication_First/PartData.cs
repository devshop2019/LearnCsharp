using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication_First
{
    public class PartData
    {
        public string Part { get; set; }
        public string Feeder { get; set; }
        public string PickupHight { get; set; }
        public string PickupSpeed { get; set; }
        public string PickupDelay { get; set; }
        public string PasteHight { get; set; }
        public string PasteSpeed { get; set; }
        public string PasteDelay { get; set; }
        public string Visual { get; set; }
        public string DeltaAngleAtFeeder1 { get; set; }
        public string FootPrintName { get; set; }
        public string FootPrintValue { get; set; }
        public FootPrintData FoodPrintInfo { get; set; }

        public PartData()
        {
            FoodPrintInfo = new FootPrintData();
        }

        public PartData(PartData _data_part_)
        {
            FoodPrintInfo = new FootPrintData();
            FoodPrintInfo.AngeAtFeeder1 = _data_part_.FoodPrintInfo.AngeAtFeeder1;
            FoodPrintInfo.AngeInLayout = _data_part_.FoodPrintInfo.AngeInLayout;
            FoodPrintInfo.Height = _data_part_.FoodPrintInfo.Height;
            FoodPrintInfo.Long = _data_part_.FoodPrintInfo.Long;
            FoodPrintInfo.Mirror = _data_part_.FoodPrintInfo.Mirror;
            FoodPrintInfo.Name = _data_part_.FoodPrintInfo.Name;
            FoodPrintInfo.Width = _data_part_.FoodPrintInfo.Width;

            Part = _data_part_.Part;
            Feeder = _data_part_.Feeder;
            PickupHight = _data_part_.PickupHight;
            PickupSpeed = _data_part_.PickupSpeed;
            PickupDelay = _data_part_.PickupDelay;
            PasteHight = _data_part_.PasteHight;
            PasteSpeed = _data_part_.PasteSpeed;
            PasteDelay = _data_part_.PasteDelay;
            Visual = _data_part_.Visual;
            DeltaAngleAtFeeder1 = _data_part_.DeltaAngleAtFeeder1;
            FootPrintName = _data_part_.FootPrintName;
            FootPrintValue = _data_part_.FootPrintValue;

        }

        public void SetPartData(PartData _data_part_)
        {
            FoodPrintInfo.AngeAtFeeder1 = _data_part_.FoodPrintInfo.AngeAtFeeder1;
            FoodPrintInfo.AngeInLayout = _data_part_.FoodPrintInfo.AngeInLayout;
            FoodPrintInfo.Height = _data_part_.FoodPrintInfo.Height;
            FoodPrintInfo.Long = _data_part_.FoodPrintInfo.Long;
            FoodPrintInfo.Mirror = _data_part_.FoodPrintInfo.Mirror;
            FoodPrintInfo.Name = _data_part_.FoodPrintInfo.Name;
            FoodPrintInfo.Width = _data_part_.FoodPrintInfo.Width;

            Part = _data_part_.Part;
            Feeder = _data_part_.Feeder;
            PickupHight = _data_part_.PickupHight;
            PickupSpeed = _data_part_.PickupSpeed;
            PickupDelay = _data_part_.PickupDelay;
            PasteHight = _data_part_.PasteHight;
            PasteSpeed = _data_part_.PasteSpeed;
            PasteDelay = _data_part_.PasteDelay;
            Visual = _data_part_.Visual;
            DeltaAngleAtFeeder1 = _data_part_.DeltaAngleAtFeeder1;
            FootPrintName = _data_part_.FootPrintName;
            FootPrintValue = _data_part_.FootPrintValue;
        }

        public string GetHeaderStringTo_Csv()
        {
            string SplitStr = ",";
            string temstr = Constant_LK.Part; temstr += SplitStr;
            temstr += Constant_LK.Feeder; temstr += SplitStr;
            temstr += Constant_LK.PickupHight; temstr += SplitStr;
            temstr += Constant_LK.PickupSpeed; temstr += SplitStr;
            temstr += Constant_LK.PickupDelay; temstr += SplitStr;

            temstr += Constant_LK.PasteHight; temstr += SplitStr;
            temstr += Constant_LK.PasteSpeed; temstr += SplitStr;
            temstr += Constant_LK.PasteDelay; temstr += SplitStr;

            temstr += Constant_LK.Visual; temstr += SplitStr;
            temstr += Constant_LK.DeltaAngleAtFeeder1; temstr += SplitStr;
            temstr += Constant_LK.FootPrintName; temstr += SplitStr;
            temstr += Constant_LK.FootPrintValue + "\r\n";

            return temstr;
        }

        public string GetStringTo_CSV()
        {
            string SplitStr = ",";
            string temstr = Part; temstr += SplitStr;
            temstr += Feeder; temstr += SplitStr;

            temstr += PickupHight; temstr += SplitStr;
            temstr += PickupSpeed; temstr += SplitStr;
            temstr += PickupDelay; temstr += SplitStr;

            temstr += PasteHight; temstr += SplitStr;
            temstr += PasteSpeed; temstr += SplitStr;
            temstr += PasteDelay; temstr += SplitStr;

            temstr += Visual; temstr += SplitStr;
            temstr += DeltaAngleAtFeeder1; temstr += SplitStr;
            temstr += FootPrintName; temstr += SplitStr;
            temstr += FootPrintValue + "\r\n";
            return temstr;
        }
    }
}
