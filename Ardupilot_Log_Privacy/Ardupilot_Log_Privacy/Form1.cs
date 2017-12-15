using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ardupilot_Log_Privacy
{
    public partial class frmMain : Form
    {
        string pathR = string.Empty;
        string pathW = string.Empty;
        
        double offset;
        StreamWriter sw;
        StreamReader sr;

        public frmMain()
        {
            InitializeComponent();
            tbxOffset.Text = "1";
        }

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            ofdLog.Filter = "log (*.log) |*.log";
            if (ofdLog.ShowDialog() == DialogResult.OK)
            {
                pathR = ofdLog.FileName;
                lblPath.Text = pathR;
                
                try
                {
                    sr = new StreamReader(new FileStream(pathR, FileMode.Open));
                }
                catch (IOException ex)
                {
                    MessageBox.Show(ex.Message + "\n Cannot open file.");
                    sr.Close();
                    return;
                }
            }
        }
        
        private void btnConvert_Click(object sender, EventArgs e)
        {
            string[] p = pathR.Split('.');
            pathW = p[0] + "_Private.log";
            sw = new StreamWriter(pathW, true);
            string line;
            while ((line = sr.ReadLine()) != null)
            {
                if (line.StartsWith("GPS"))
                {
                    sw.WriteLine(changePos(line, 7, offset));
                }
                else if (line.StartsWith("POS"))
                {
                    sw.WriteLine(changePos(line, 2, offset));
                }
                else if (line.StartsWith("AHR2"))
                {
                    sw.WriteLine(changePos(line, 6, offset));
                }
                else if (line.StartsWith("TERR"))
                {
                    sw.WriteLine(changePos(line, 3, offset));
                }
                else
                    sw.WriteLine(line);
            }
            sw.Close();
            MessageBox.Show("done");
        }

        private void btnCreateParam_Click(object sender, EventArgs e)
        {
            string[] p = pathR.Split('.');
            pathW = p[0] + ".param";
            sw = new StreamWriter(pathW, true);
            string line;
            string[] param = new string[778];
            int counter = 0;
            while ((line = sr.ReadLine()) != null)
            {
                if (line.StartsWith("PARM"))
                {
                    string[] temp = line.Split(',');
                    param[counter] = temp[2].Trim() + "," + temp[3].Trim();
                    counter++;
                }
            }
            Array.Sort(param);
            for(int i = 0; i < param.Length; i++)
            {
                if(param[i] != null)
                sw.WriteLine(param[i]);
            }
            sw.Close();
            MessageBox.Show("done");
        }

        private void tbxOffset_TextChanged(object sender, EventArgs e)
        {
            double.TryParse(tbxOffset.Text.Replace('.', ','), out offset);
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            sr.Close();
            sw.Close();
        }

        private string changePos(string message, int pos, double offset)
        {
            string[] temp = message.Split(',');
            string newLine = "";
            double location = 0;

            for (int i = 0; i <= temp.Length - 1; i++)
            {
                if (i == temp.Length - 1)
                    newLine += temp[i];
                else if (i == pos)
                {
                    double.TryParse(temp[i].Replace('.', ','), out location);
                    if (location != 0)
                        newLine += " " + (location + offset).ToString("F7", CultureInfo.InvariantCulture) + ", ";
                    else
                        newLine += temp[i] + ",";
                }
                else if (i == pos +1)
                {
                    double.TryParse(temp[i].Replace('.', ','), out location);
                    if (location != 0)
                        newLine += (location + offset).ToString("F7", CultureInfo.InvariantCulture) + ",";
                    else
                        newLine += temp[i] + ",";
                }
                else
                    newLine += temp[i] + ",";
            }
            if(cbxLog.Checked && location != 0)
            {
                tbxLog.AppendText(message + "\n");
                tbxLog.AppendText("=>" + newLine + "\n");
            }
            return newLine;
        }

    }
}
