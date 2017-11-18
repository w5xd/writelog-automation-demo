/* This form demonstrates ways WriteLog's Entry Window automation might be used.
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WriteLogClrTypes;

namespace WriteLogAutomationDemo
{
    public partial class QsoEntryDemo : Form
    {
        private IWriteL m_WriteLogDocument;
        private ISingleEntry m_SingleEntry;

        // constructor--get the IQsoCollection from the IWriteL interface
        public QsoEntryDemo(WriteLogClrTypes.IWriteL wl)
        {
            m_WriteLogDocument = wl;
            InitializeComponent();
        }

        private void QsoEntryDemo_Load(object sender, EventArgs e)
        {
            comboBoxMode.SelectedIndex = 2; // Start on CW, just for fun.

            DialogResult res = MessageBox.Show(
                Parent,
                "Use Radio 1 Entry Window? (Yes)\nNo creates hidden Entry Window",
                "WriteLog Automation Demo", 
                MessageBoxButtons.YesNoCancel);

            if (res == DialogResult.Yes)
                m_SingleEntry = m_WriteLogDocument.GetEntry(0); // This is Radio #1
             else if (res == DialogResult.No)
                m_SingleEntry = m_WriteLogDocument.CreateEntry(); // Creates a hidden entry window
            else
            {
                Close();
                return;
            }

            FillFromEntry();
        }

        /*
         * Take our user's entries and push them into WriteLog's Entry Window
         */
        private bool UpdateEntryWindow()
        {
            m_SingleEntry.Callsign = textBoxCALL.Text;
            double freq = 0;
            try
            {
                freq = double.Parse(textBoxKHz.Text);
            }
            catch
            {   // got to enter something that parses out to a floating point number
                freq = 0;
            }
            if (freq == 0)
            {
                MessageBox.Show("Enter Frequency in KHz");
                textBoxKHz.Focus();
                return false;
            }
            // If this Entry Window is connected to a real live radio, it gets set.
            m_SingleEntry.SetLogFrequencyEx((short)(comboBoxMode.SelectedIndex+1), freq, freq, (short)0);
            return true;
        }

        private void buttonLogQSO_Click(object sender, EventArgs e)
        {
            if (UpdateEntryWindow())
                m_SingleEntry.EnterQso();
        }

        private void buttonCheckDupe_Click(object sender, EventArgs e)
        {
            if (!UpdateEntryWindow())
                return;
            int res = m_SingleEntry.Dupe();
            if (res == 0)
                MessageBox.Show("Is not a dupe.", "WriteLog Dupe Check");
            else
                MessageBox.Show("Is a dupe.", "WriteLog Dupe Check");
        }

        // Take WriteLog's Entry Window state and populate our dialog items.
        void FillFromEntry()
        {
            String s = m_SingleEntry.GetFieldN(0); // zero gets the CALL, wherever it is
            textBoxCALL.Text = s;

            short Mode = 0; double RxFreqKhz = 0; double TxFreqKhz = 0; short Split = 0;
            m_SingleEntry.GetLogFrequency(ref Mode, ref RxFreqKhz, ref TxFreqKhz, ref Split);

            // Frequency of Entry Window to our form items
            comboBoxMode.SelectedIndex = Mode - 1; // GetLogFrequency Mode is one-based.
            textBoxKHz.Text = RxFreqKhz.ToString();
        }

        private void buttonGetAll_Click(object sender, EventArgs e)
        {
            FillFromEntry();

            // The field numbers GetFieldN are the same as in the IQsoCollection, 
            // EXCEPT IQsoCollection starts at zero and GetFieldN starts at one.
 
            String msg = "";
            for (short i = 1; ; i++) // start at one. Matches zeroth entry in IQsoCollection.GetColumnAdifNames
            {
                if (m_SingleEntry.GetFieldWidth(i) == 0) // no width means does not exist.
                    break;
                if (msg.Length > 0)
                    msg += "\n";
                String f = m_SingleEntry.GetFieldN(i);
                String adif = m_SingleEntry.GetAdifNameN(i);
                msg += adif + ": " + f;
             }
            MessageBox.Show(msg, "WriteLog QSO Entry Fields");
        }

      }
}
