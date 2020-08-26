using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Oefening26082020
{
    public partial class Oefening4 : Form
    {
        public Oefening4()
        {
            InitializeComponent();
        }

        private void btnKlik_Click(object sender, EventArgs e)
        {
            try
            {
                string number = nudNumber.Value.ToString();
                number = Convert.ToDouble(number).ToString();

                if (number == "0")
                {
                    lblDisplay.Text = "Zero";
                }
                else
                {
                    lblDisplay.Text = ConvertToWords(number);
                }
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private static String ConvertToWords(String numb)
        {
            String val, wholeNo = numb;
            val = String.Format("{0}", ConvertWholeNumber(wholeNo).Trim());
            return val;
        }

        private static String ConvertWholeNumber(String Number)
        {
            string word = "";
            try
            {
                bool isDone = false;
                double dblAmt = (Convert.ToDouble(Number));
                if (dblAmt > 0)
                {                    
                    int numDigits = Number.Length;
                    int pos = 0;
                    String place = "";
                    switch (numDigits)
                    {
                        //ones' range
                        case 1: 
                            word = Ones(Number);
                            isDone = true;
                            break;
                        //tens' range
                        case 2:    
                            word = Tens(Number);
                            isDone = true;
                            break;
                        //hundreds' range   
                        case 3:                             
                            pos = (numDigits % 3) + 1;
                            place = "honderd";
                            break;
                        //thousands' range    
                        case 4:
                        case 5:
                        case 6:
                            pos = (numDigits % 4) + 1;
                            place = "duizend ";
                            break;
                        //millions' range    
                        case 7:
                        case 8:
                        case 9:
                            pos = (numDigits % 7) + 1;
                            place = " miljoen ";
                            break;
                        //Billions's range    
                        case 10:
                        case 11:
                        case 12:
                            pos = (numDigits % 10) + 1;
                            place = " miljard ";
                            break;
                        default:
                            isDone = true;
                            break;
                    }
                    if (!isDone)
                    {
                        if (Number.Substring(0, pos) != "0" && Number.Substring(pos) != "0")
                        {
                            string honderd = ConvertWholeNumber(Number.Substring(0, pos));
                            if (honderd == "één" && place == "honderd")
                            {
                                word = place + ConvertWholeNumber(Number.Substring(pos));
                            }
                            else
                            {
                                word = ConvertWholeNumber(Number.Substring(0, pos)) + place + ConvertWholeNumber(Number.Substring(pos));
                            }
                            
                        }
                        else
                        {
                            word = ConvertWholeNumber(Number.Substring(0, pos)) + ConvertWholeNumber(Number.Substring(pos));
                        }  
                    }

                    if (word != "honderd" && word.Trim().Equals(place.Trim()))
                    {
                        word = "";
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return word.Trim();
        }

        private static String Ones(String Number)
        {
            int input = Convert.ToInt32(Number);
            String name = "";
            switch (input)
            {

                case 1:
                    name = "één";
                    break;
                case 2:
                    name = "twee";
                    break;
                case 3:
                    name = "drie";
                    break;
                case 4:
                    name = "vier";
                    break;
                case 5:
                    name = "vijf";
                    break;
                case 6:
                    name = "zes";
                    break;
                case 7:
                    name = "zeven";
                    break;
                case 8:
                    name = "acht";
                    break;
                case 9:
                    name = "negen";
                    break;
            }
            return name;
        }

        private static String Tens(String Number)
        {
            int input = Convert.ToInt32(Number);
            String name = null;
            switch (input)
            {
                case 10:
                    name = "tien";
                    break;
                case 11:
                    name = "elf";
                    break;
                case 12:
                    name = "twaalf";
                    break;
                case 13:
                    name = "dertien";
                    break;
                case 14:
                    name = "veertien";
                    break;
                case 15:
                    name = "vijftien";
                    break;
                case 16:
                    name = "zestien";
                    break;
                case 17:
                    name = "zeventien";
                    break;
                case 18:
                    name = "achttien";
                    break;
                case 19:
                    name = "negentien";
                    break;
                case 20:
                    name = "twintig";
                    break;
                case 30:
                    name = "dertig";
                    break;
                case 40:
                    name = "veertig";
                    break;
                case 50:
                    name = "vijftig";
                    break;
                case 60:
                    name = "zestig";
                    break;
                case 70:
                    name = "zeventig";
                    break;
                case 80:
                    name = "tachtig";
                    break;
                case 90:
                    name = "negentig";
                    break;
                default:
                    if (input > 0)
                    {
                        string endsE;
                        //string temp = Tens(Number.Substring(0, 1) + "0");
                        if (Tens(Number.Substring(0, 1) + "0") == null)
                        {
                            endsE = Ones(Number.Substring(1)).EndsWith("e") ? "ën" + Ones(Number.Substring(1)) : "en" + Ones(Number.Substring(1));
                            name = endsE + Tens(Number.Substring(0, 1) + "0");
                        }
                        else
                        {
                            endsE = Ones(Number.Substring(1)).EndsWith("e") ? Ones(Number.Substring(1)) + "ën" : Ones(Number.Substring(1)) + "en";
                            name = endsE + Tens(Number.Substring(0, 1) + "0");
                        }
                    }
                    break;
            }
            return name;
        }
    }
}
