﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication_First
{
    public class LinhKienData
    {
        public string Posistion { get; set; }
        public string MidX { get; set; }
        public string MidY { get; set; }
        public string AngelNew { get; set; }
        public string AngelOld { get; set; }
        public string Value { get; set; }
        public string ValueOld { get; set; }
        //public string NoozleId { get; set; }
        public string FootPrint { get; set; }
        
        public LinhKienData()
        {
            Posistion = Constant_LK.POS_DEFAULT;
            MidX = "1000mm";
            MidY = "1000mm";
            AngelNew = "NA";
            AngelOld = "NA";
            Value = Constant_LK.VALUE_DEFAULT;
            ValueOld = "NoValueOld";
            FootPrint = "NoFoot";
        }

        public LinhKienData(LinhKienData data_)
        {
            Posistion = data_.Posistion;
            MidX = data_.MidX;
            MidY = data_.MidY;
            AngelNew = data_.AngelNew;
            AngelOld = data_.AngelOld;
            Value = data_.Value;
            ValueOld = data_.ValueOld;
            FootPrint = data_.FootPrint;
        }

        public string GetString()
        {
            string SplitStr = " ";
            string temstr = Posistion; temstr += SplitStr;
            temstr += MidX; temstr += SplitStr;
            temstr += MidY; temstr += SplitStr;
            //temstr += (AngelNew=="")?AngelOld:AngelNew; temstr += SplitStr;
            temstr += AngelNew; temstr += SplitStr;
            temstr += AngelOld; temstr += SplitStr;
            temstr += Value; temstr += SplitStr;
            return temstr;
        }

        public string GetStringTo_TXT()
        {
            string SplitStr = " ";
            string temstr = Posistion; temstr += SplitStr;
            temstr += MidX; temstr += SplitStr;
            temstr += MidY; temstr += SplitStr;
            //temstr += (AngelNew=="")?AngelOld:AngelNew; temstr += SplitStr;
            temstr += AngelNew; temstr += SplitStr;
            temstr += AngelOld; temstr += SplitStr;
            temstr += Value; temstr += SplitStr;
            temstr += ValueOld; temstr += "\r\n";
            return temstr;
        }

        public string GetStringTo_Kayo_TXT()
        {
            string SplitStr = " ";
            string temstr = Posistion;          temstr += SplitStr;
            temstr += MidX;                     temstr += SplitStr;
            temstr += MidY;                     temstr += SplitStr;
            temstr += AngelNew;                 temstr += SplitStr;
            temstr += Value;                 temstr += "\r\n";
            return temstr;
        }

        public string GetString(string _splitStr_)
        {
            string SplitStr = _splitStr_;
            string temstr = Posistion; temstr += SplitStr;
            temstr += MidX; temstr += SplitStr;
            temstr += MidY; temstr += SplitStr;
            //temstr += (AngelNew == "") ? AngelOld : AngelNew; temstr += SplitStr;
            temstr += AngelNew; temstr += SplitStr;
            temstr += AngelOld; temstr += SplitStr;
            temstr += Value;// temstr += SplitStr;
            return temstr;
        }

        public string GetStringTo_CSV()
        {
            string SplitStr = ",";
            string temstr = Posistion; temstr += SplitStr;
            temstr += MidX; temstr += SplitStr;
            temstr += MidY; temstr += SplitStr;
            temstr += AngelNew; temstr += SplitStr;
            temstr += AngelOld; temstr += SplitStr;
            temstr += Value; temstr += SplitStr;
            temstr += ValueOld + "\r\n";
            return temstr;
        }

        public string GetHeaderString()
        {
            string SplitStr = " ";
            string temstr = Constant_LK.Posistion; temstr += SplitStr;
            temstr += Constant_LK.MidX; temstr += SplitStr;
            temstr += Constant_LK.MidY; temstr += SplitStr;
            temstr += Constant_LK.AngelNew; temstr += SplitStr;
            temstr += Constant_LK.AngelOld; temstr += SplitStr;
            temstr += Constant_LK.Value + "\n";

            return temstr;
        }

        public string GetHeaderStringTo_TXT()
        {
            string SplitStr = " ";
            string temstr = Constant_LK.Posistion; temstr += SplitStr;
            temstr += Constant_LK.MidX; temstr += SplitStr;
            temstr += Constant_LK.MidY; temstr += SplitStr;
            temstr += Constant_LK.AngelNew; temstr += SplitStr;
            temstr += Constant_LK.AngelOld; temstr += SplitStr;
            temstr += Constant_LK.Value; temstr += SplitStr;
            temstr += Constant_LK.ValueOld + "\r\n";

            return temstr;
        }

        public string GetHeaderStringTo_Kayo_TXT()
        {
            string SplitStr = " ";
            string temstr = Constant_LK.Posistion; temstr += SplitStr;
            temstr += Constant_LK.MidX; temstr += SplitStr;
            temstr += Constant_LK.MidY; temstr += SplitStr;
            temstr += Constant_LK.AngelNew; temstr += SplitStr;
            temstr += Constant_LK.Value + "\r\n";

            return temstr;
        }

        public string GetHeaderString(string _splitStr_)
        {
            string SplitStr = _splitStr_;
            string temstr = Constant_LK.Posistion; temstr += SplitStr;
            temstr += Constant_LK.MidX; temstr += SplitStr;
            temstr += Constant_LK.MidY; temstr += SplitStr;
            temstr += Constant_LK.AngelNew; temstr += SplitStr;
            temstr += Constant_LK.AngelOld; temstr += SplitStr;
            temstr += Constant_LK.Value;

            return temstr;
        }

        public string GetHeaderStringTo_Csv()
        {
            string SplitStr = ",";
            string temstr = Constant_LK.Posistion; temstr += SplitStr;
            temstr += Constant_LK.MidX; temstr += SplitStr;
            temstr += Constant_LK.MidY; temstr += SplitStr;
            temstr += Constant_LK.AngelNew; temstr += SplitStr;
            temstr += Constant_LK.AngelOld; temstr += SplitStr;
            temstr += Constant_LK.Value; temstr += SplitStr;
            temstr += Constant_LK.ValueOld + "\r\n";

            return temstr;
        }
    }
}
