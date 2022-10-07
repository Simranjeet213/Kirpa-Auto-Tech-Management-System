using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KATMS.Validation
{
    public class Validator
    {
        public static bool IsValidId(TextBox txtInput, int size)
        {
            //int tempId = 0;
            //if (txtInput.TextLength != size || (!int.TryParse(txtInput.Text, out tempId)))
            //{
            //    MessageBox.Show("Student Id must have 7 number digits", "Invalid Student ID");
            //    txtInput.Clear();
            //    txtInput.Focus();
            //}
            bool isValid = true;

            if (txtInput.Text.Length != size)
                isValid = false;
            else
            {
                for (int i = 0; i < txtInput.Text.Length; i++)
                {
                    if (!(txtInput.Text[i] >= 48 && txtInput.Text[i] <= 57))
                    {
                        isValid = false;
                    }
                }
            }

            return isValid;

        }


        public static bool IsPresent(TextBox txtInput)
        {
            if (txtInput.Text == "")
            {
                return false;
            }
            return true;
        }

        public static bool IsPresent(String txtInput)
        {
            if (txtInput == "")
            {
                return false;
            }
            return true;
        }


        public static bool IsValidName(TextBox txtInput)
        {
            bool valid = true;

            //for(
            //    int i = 0; i < txtInput.Text.Length; i++)
            //{
            //    if (char.IsDigit(txtInput.Text[i]) && (!char.IsWhiteSpace(txtInput.Text[i])))
            //    {
            //        valid = false;
            //        break;
            //    }
            //}

            string text = txtInput.Text.ToUpper();
            for (int i = 0; i < txtInput.Text.Length; i++)
            {
                if (!(text[i] >= 65 && text[i] <= 90))
                {
                    valid = false;
                    break;
                }
            }
            return valid;

        }
    }
}
