using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Runtime.InteropServices;
using System.IO;
using System.Data.SqlClient;

namespace POS_Group5_CMPG223
{
    class Methods
    {
        #region Properties
        public static SqlConnection SQLCon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + Application.StartupPath + "\\" + "POS_Data" + ".mdf;Integrated Security=True;Connect Timeout=30");
        public static SqlConnection SQLCon2 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + Application.StartupPath + "\\" + "POS_Data" + ".mdf;Integrated Security=True;Connect Timeout=30");
        public static String businessName = "Business Name";
        public static int colorScheme = 0;
        public static Color clrIcons = Color.FromArgb(94, 1, 20);
        public static Color clrSelected = Color.FromArgb(94, 1, 20);
        public static Color clrMenu = Color.FromArgb(45, 45, 47);
        public static Color clrForms = Color.FromArgb(62, 62, 66);
        public static void SaveProperties()
        {
            File.WriteAllText(Application.StartupPath + @"\properties.txt", businessName+"#"+colorScheme);
        }
        public static void LoadProperties()
        {
            String propertiesText = File.ReadAllText(Application.StartupPath + @"\properties.txt");
            String[] arrProperties = propertiesText.Split('#');
            businessName = arrProperties[0];
            colorScheme = int.Parse(arrProperties[1]);
            if (arrProperties[1] == "0")
            {
                //Set Colors (Dark Theme)
                clrIcons = Color.FromArgb(94, 1, 20);
                clrSelected = Color.FromArgb(94, 1, 20);
                clrMenu = Color.FromArgb(45, 45, 47);
                clrForms = Color.FromArgb(62, 62, 66);
            }
            else
            {
                //Set Colors (Light Theme)
                clrIcons = Color.FromArgb(103, 122, 146);
                clrSelected = Color.FromArgb(103, 122, 146);
                clrMenu = Color.FromArgb(205, 213, 219);
                clrForms = Color.FromArgb(225, 225, 223);
            }
        }
        #endregion

        #region Color Brightness
        public static Color ChangeColorBrightness(Color color, double correctionFactor)
        {
            /*  
             *  Changes color brightness according to a provided percentage.
             *  color =             Color to be changed.
             *  correctionFactor =  Factor (in percentage).
             */
            //Set Color Variables
            double red = color.R;
            double green = color.G;
            double blue = color.B;

            //CF < 0 Darken
            if (correctionFactor < 0)
            {
                correctionFactor = 1 + correctionFactor;
                red *= correctionFactor;
                green *= correctionFactor;
                blue *= correctionFactor;
            }
            //CF > 0 Brighten
            else
            {
                red = (255 - red) * correctionFactor + red;
                green = (255 - green) * correctionFactor + green;
                blue = (255 - blue) * correctionFactor + blue;
            }

            //Return New Color
            return Color.FromArgb(color.A, (byte)red, (byte)green, (byte)blue);
        }
        #endregion
        #region Determine Front Color
        public static Color DetermineFrontColor(Color backColor)
        {
            double red = backColor.R;
            double green = backColor.G;
            double blue = backColor.B;

            if ((red * 0.299 + green * 0.587 + blue * 0.114) > 186)
            {
                return Color.Black;
            }
            else
            {
                return SystemColors.Control;
            }
        }
        #endregion
        #region Hashing
        public static string Hash(string input)
        {
            SHA256 sha = new SHA256Managed();
            byte[] hash = sha.ComputeHash(Encoding.ASCII.GetBytes(input));
            string output = "";
            foreach (byte b in hash)
            {
                output = output + b.ToString("x2");
            }
            return output;
        }
        #endregion
        #region Drag Function
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        public static void DragCode(Form frm)
        {
            try
            {
                ReleaseCapture();
                SendMessage(frm.Handle, 0x112, 0xf012, 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Drag Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion
    }
}
