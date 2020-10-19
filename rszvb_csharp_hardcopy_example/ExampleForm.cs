using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using InstrumentDrivers;
using System.IO;

namespace rszvb_hardcopy_example
{
    public partial class RSZVB_Hardcopy_Example : Form
    {
        private rszvb m_instrument = null;

        public RSZVB_Hardcopy_Example()
        {
            InitializeComponent();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void OpenButton_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                textBox1.Text = saveFileDialog1.FileName;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            string tempFilePath = "";

            try
            {
                UseWaitCursor = true;
                System.Windows.Forms.Cursor.Current = Cursors.WaitCursor;

                /* initialize driver */
                if (m_instrument == null)
                    m_instrument = new rszvb(ResourceDescriptor.Text, IDQuery.Checked, ResetDevice.Checked);
                else if (ResetDevice.Checked)
                    m_instrument.reset();

                /* switch device display on/off */
                m_instrument.SetDisplayUpdate(Convert.ToInt32(DisplayEnable.Checked));

                /* select temporary file location */
                tempFilePath = "C:\\temp\\output.wmf";

                /* configure hardcopy save file */
                /* configure hardcopy options */
                /* save screen image to file */
                m_instrument.PrinttoFile(tempFilePath, rszvbConstants.Emf, rszvbConstants.HcopyAll, true, true, true);

                if (File.Exists(textBox1.Text) == false)
                {
                    if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                        textBox1.Text = saveFileDialog1.FileName;
                    else
                        return;
                }

                /* copy file from instrument to controller */ 
                m_instrument.readToFile(tempFilePath, textBox1.Text);

                /* delete temporary file */
                m_instrument.FileManager(rszvbConstants.FileManDelete, tempFilePath, "");

            }
            catch (System.Runtime.InteropServices.ExternalException ex)
            {
                String message;

                message = "Instrument Status Error: " + ex.Message + Environment.NewLine;
                message += "Instrument Error Code: " + ex.ErrorCode.ToString("X");
                MessageBox.Show(message);
            }
            finally
            {
                System.Windows.Forms.Cursor.Current = Cursors.Default;
                UseWaitCursor = false;
                m_instrument.Dispose();
                m_instrument = null;
            }
        }
    }
}