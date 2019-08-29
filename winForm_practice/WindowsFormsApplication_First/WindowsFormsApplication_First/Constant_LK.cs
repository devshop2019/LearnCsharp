using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication_First
{
    public class Constant_LK
    {
        public static string Posistion = "Designator";
        public static string MidX = "Mid X";
        public static string MidY = "Mid Y";
        public static string AngelNew = "New_Angel";
        public static string AngelOld = "Rotation";
        public static string Value = "Comment";
        public static string ValueOld = "ValueOld";
        public static string FootPrint = "Footprint";

        public static string Part = "Part";
        public static string Feeder = "Feeder";
        public static string PickupHight = "PickupHight";
        public static string PickupSpeed = "PickupSpeed";
        public static string PickupDelay = "PickupDelay";
        public static string PasteHight = "PasteHight";
        public static string PasteSpeed = "PasteSpeed";
        public static string PasteDelay = "PasteDelay";
        public static string Visual = "Visual";
        public static string DeltaAngleAtFeeder1 = "DeltaAngleAtFeeder1";
        public static void debug(String format, params object[] args)
        {
            Console.WriteLine(format, args);
        }

    }
}
