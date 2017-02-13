/* This is a demonstration of how one might automation WriteLog.
 * 
 * 
 * 
 * The demo doesn't make WriteLog do anything particularly useful, but it does
 * show how to make a program interact with WriteLog in a couple of scenarios.
 * 
 * To get this project to compile the first time, right click on the Visual Studio Solution Explorer References
 *    Add Reference...
 *    Switch to the "Browse" tab
 *    Browse to and add from WriteLog's installed Programs folder, the file:
 *          WriteLogClrTypes.dll
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using WriteLogClrTypes; // must Add Reference WriteLogClrTypes.dll for this to work.

namespace WriteLogAutomationDemo
{
    public partial class MainForm : Form
    {
        private WriteLogClrTypes.IWriteL m_WriteLogDocument;
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // First try to attach to a running instance of WriteLog
            try
            {
                Object o = Marshal.GetActiveObject("WriteLog.Document");
                m_WriteLogDocument = (IWriteL)o;
            }
            catch
            {
            }

           /* WriteLog, by the way, has some system-wide state to be aware of when
            * programming it:
            * 
            * A) EACH instance of WriteLog, when launched registers itself as the one-and-only
            * instance that subsequent calls of GetActiveObject retrieve.
            * 
            * B) EACH instance of WriteLog checks to see if it is the ONLY instance running.
            * Only in the case it is the ONLY does it attempt to initialize the stuff in
            * its Setup/Ports dialog (i.e. interfaces to radios via COM ports.)
            */

            /* This sequence is unduly complicated because its a demo. 
            * For a "real" WriteLog automation server, it is unlikely it would need to do all 
            * the three cases demo'd here:
             * a) connect to running WriteLog
             * b) have WriteLog show its main window and open a .WL file chosen by the user via WriteLog
             * c) choose a .wl file in this server and have WriteLog open it without showing anything onscreen
             */
            String isRunning = "";
            if (m_WriteLogDocument != null)
            {
                if (MessageBox.Show(
                    "WriteLog is running. Do automation on that running WriteLog?", 
                    "WriteLog Automation Demo", MessageBoxButtons.YesNo) == DialogResult.No)
                    m_WriteLogDocument = null;
            }
            else
                isRunning = "WriteLog is not running. ";
            if (m_WriteLogDocument == null)
            {

                if (MessageBox.Show(isRunning + "Start WriteLog now?", 
                    "WriteLog Automation demo", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {

                    m_WriteLogDocument = new WriteLogDocument() as IWriteL;
                    // at this point, the running WriteLog instance has now shown any windows. If we
                    // delete our reference to, that WriteLog will exit
                    bool HaveWriteLogShowItsFileOpenBrowser = false;
                    if (HaveWriteLogShowItsFileOpenBrowser)
                    {
                        // FileUserOpen brings up WriteLog's File/Open dialog. 
                        m_WriteLogDocument.FileUserOpen(); // once WriteLog's main screen is shown, the user has to exit it
                    }
                    else
                    {
                        // or we (the automation server) browse to the file 
                        OpenFileDialog fd = new OpenFileDialog();
                        fd.Title = "Browse to .wl file";
                        fd.Filter = "WriteLog files (*.wl)|*.wl";
                        if (fd.ShowDialog() == DialogResult.OK)
                        {
                            // and WriteLog opens it in a hidden window
                            m_WriteLogDocument.FileOpen(fd.FileName, 1);
                        }
                        else
                            m_WriteLogDocument = null;
                    }
                }
             }
            if (m_WriteLogDocument == null)
                Close();
            else  // We have connected to some WriteLog instance, so show our Form on the screen now.
                textBoxCWMemF2.Text = m_WriteLogDocument.GetFKeyMsgCw(0); // demo changing F-key memories
        }

        private void buttonDemoQsoCollection_Click(object sender, EventArgs e)
        {
            QsoCollectionForm f = new QsoCollectionForm(m_WriteLogDocument);
            f.StartPosition = FormStartPosition.CenterParent;
            f.ShowDialog(this);
        }

        private void buttonQsoEntry_Click(object sender, EventArgs e)
        {
            QsoEntryDemo f = new QsoEntryDemo(m_WriteLogDocument);
            f.StartPosition = FormStartPosition.CenterParent;
            f.ShowDialog(this);
        }

        private void buttonUpdateCWMemory_Click(object sender, EventArgs e)
        {
            m_WriteLogDocument.SetFKeyMsgCw(0, textBoxCWMemF2.Text);
            textBoxCWMemF2.Text = m_WriteLogDocument.GetFKeyMsgCw(0);
        }

    }

    // class WriteLogDocument is a magic incantation to get .NET Com interop to create a fresh WriteLog instance.
    [ComImport]
    [Guid("C91374A0-16A7-11D1-8419-00400534A64D") /*The GUID is from the WriteLog typelib. */]
    class WriteLogDocument { }
}
