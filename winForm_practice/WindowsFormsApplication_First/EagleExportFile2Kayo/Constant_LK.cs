﻿using System;
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
        public static string FootPrintName = "FootPrintName";
        public static string FootPrintValue = "FootPrintValue";


        public static int FootPrint_Left = 0;
        public static int FootPrint_Bot = 90;
        public static int FootPrint_Right = 180;
        public static int FootPrint_Top = 270;

        public static byte FootPrint_Miror = 1;
        public static byte FootPrint_NoMiror = 0;

        public static string POS_DEFAULT = "NoPos";
        public static string VALUE_DEFAULT = "NoVal";
        public static string END_SYMBOL_FOOTPRINT_DEFAULT = "]";

        public static void debug(String format, params object[] args)
        {
            Console.WriteLine(format, args);
        }

    }
}
