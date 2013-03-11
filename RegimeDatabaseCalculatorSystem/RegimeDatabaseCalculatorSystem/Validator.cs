using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace RegimeDatabaseCalculatorSystem
{
    class Validator
    {
        public enum TypeOf {Tinteger, Tdouble, Tdate,Tstring };
        public struct ValLimits
        {
            public float MinVal;
            public float MaxVal;
            public ValLimits(float MinVal, float MaxVal)
            {
                this.MinVal = MinVal;
                this.MaxVal = MaxVal;
            }
        }
        public int Check(int TypeCode, int EntityCode, string input) //0=Good; 1=OutOfRange; 2=WrongType
        {
            TypeOf Type = TypeVal(EntityCode, input);
            switch (TypeCode)
            {
                case 0:                                 //int
                    if (Type.Equals(TypeOf.Tinteger))
                    {
                        if (int.Parse(input) > 0)
                            return 0;
                        else return 1;
                    }
                    else return 2;
                case 1:                                 //real
                    if ((Type.Equals(TypeOf.Tdouble))|| (Type.Equals(TypeOf.Tinteger)))
                    {
                        if (double.Parse(input) > 0)
                            return 0;
                        else return 1;
                    }
                    else return 2;
                case 2:                                 //date
                    if (Type.Equals(TypeOf.Tdate))
                    {
                        return 0;
                    }
                    else return 2;
                case 3:                                 //str
                    return 0;
            }
            return 0;
        }

        public TypeOf TypeVal(int EntityCode, string input)
        {
            try
            {
                Convert.ToInt32(input);
                return TypeOf.Tinteger;
            }
            catch { }
            try
            {
                Convert.ToDouble(input);
                return TypeOf.Tdouble;

            }
            catch { }
            try
            {
                Convert.ToDateTime(input);
                return TypeOf.Tdate;
            }
            catch { }
            return TypeOf.Tstring;
        }

        public void ErrorMessage(int ErrorType)
        {
            string str;
            if (ErrorType == 1)
            {
                str = "Out of Range Error \nThe Given value is either too big or too small for this field";
            }
            else if (ErrorType == 2)
            {
                str = "Input Error \nThe Given value is not of the right type";
            }
            else if (ErrorType == 0)
            {
                str = "Good";
                return;
            }
            else str = "WTF";

            MessageBox.Show(str, "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
