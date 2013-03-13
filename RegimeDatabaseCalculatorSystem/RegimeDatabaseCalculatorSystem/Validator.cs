using System;/*{*/
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
/*}*/
namespace RegimeDatabaseCalculatorSystem
{
    class Validator		// Shared Class to ensure that all inputs are valid.
    {
        public enum TypeOf {Tinteger, Tdouble, Tdate, Tstring}; // Datatypes to test
#region MedLimits
		// TODO Optional Extend the validator to check that results are within medical limits.
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
#endregion

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

        public int Check(int TypeCode, int EntityCode, string input) // Returns 0=Good; 1=OutOfRange; 2=WrongType
		//Remove entity code if not implemented TODO
        {
            TypeOf Type = TypeVal(EntityCode, input);
            switch (TypeCode)	// Chosen check method depends on the desired datatype
            {
                case 0:                                 // DATATYPE int
                    if (Type.Equals(TypeOf.Tinteger))
                    {
                        if (int.Parse(input) > 0)
                            return 0;		// Valid
                        else return 1;		// <0 Invalid
                    }
                    else return 2;			// Wrong Type Invalid

                case 1:                                 //DATATYPE real
                    if ((Type.Equals(TypeOf.Tdouble))|| (Type.Equals(TypeOf.Tinteger)))
                    {
                        if (double.Parse(input) > 0)
                            return 0;		// Valid
                        else return 1;		// <0 Invalid
                    }
                    else return 2;			// Wrong Type Invalid

                case 2:                                 //DATATYPE date
                    if (Type.Equals(TypeOf.Tdate))
                    {
                        return 0;			// Valid
                    }
                    else return 2;			// Wrong Type Invalid

                case 3:                                 //str
                    return 0;

                default:
                	return 4;
            }
            /* return 0; */
        }

        public void ErrorMessage(int ErrorType) // Provides user feedback when invalid input is submitted
        	// Use the message box as the return type?
        {
            string str;
            switch (ErrorType)
            {
            	case 0: str = "Good";
            		break;
            	case 1: str = "Out of Range Error \nThe Given value is either too big or too small for this field";
            		break;
            	case 2: str = "Input Error \nThe Given value is not of the right type";
            		break;
            	default: str = "WTF";
            		 break;
			}
            if (ErrorType != 0)
				MessageBox.Show(str, "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            /* if (ErrorType == 1) */
            /*     str = "Out of Range Error \nThe Given value is either too big or too small for this field"; */

            /* else if (ErrorType == 2) */
            /*     str = "Input Error \nThe Given value is not of the right type"; */

            /* else if (ErrorType == 0) */
            /* { */
            /*     str = "Good"; */
            /*     return; */
            /* } */
            /* else str = "WTF"; */

            /* MessageBox.Show(str, "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error); */
        }
    }
}
//	:vim :set foldmarker={,}
