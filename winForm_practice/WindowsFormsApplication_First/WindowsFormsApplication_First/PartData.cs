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
            temstr += Constant_LK.DeltaAngleAtFeeder1 + "\r\n";

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
            temstr += DeltaAngleAtFeeder1 + "\r\n";
            return temstr;
        }
    }
}
