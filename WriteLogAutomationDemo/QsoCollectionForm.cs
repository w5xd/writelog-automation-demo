/* This form demonstrates ways WriteLog's QSO collection might be used.
 * 
 * The interfaces used here were first supported in WriteLog version 12.15, March, 2017
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
using WriteLogClrTypes;

namespace WriteLogAutomationDemo
{
    [ComVisible(true)]
    public partial class QsoCollectionForm : Form
    {
        delegate void UpdateQsoDel(uint QsoIndex); // type needed for callback

        // This line won't compile if your WriteLogClrTypes is older than WriteLog version 12.15
        private WriteLogClrTypes.IQsoCollection m_QsoCollection;

        private uint m_callIndex; // array index of the CALL field in the QSO. Usually zero. Not in ARRL SS

        // constructor--get the IQsoCollection from the IWriteL interface
        public QsoCollectionForm(WriteLogClrTypes.IWriteL wl)
        {
            InitializeComponent();
            m_QsoCollection = (IQsoCollection)wl.GetQsoCollection(); // will throw on earlier versions of WriteLog without this interface.
        }

        private void QsoCollectionForm_Load(object sender, EventArgs e)
        {
            // Hunt down the CALL column in the QSO exchange
            string[] AdifColumns = m_QsoCollection.GetColumnAdifNames();
            m_callIndex = 0;
            foreach (string adifTitle in AdifColumns)
                if (adifTitle == "CALL")
                    break;
                else
                    m_callIndex++;
            // what if there isn't one? ...WriteLog forces there to be one, but if we
            // don't find it, we'll crash on the callback.

            // initialize the count label
            labelQsoCount.Text = String.Format("{0}", m_QsoCollection.QsoCount);

            // have WriteLog call us when it changes a QSO
            // The callback happens on a different thread
            // TODO: there is probably some .net attribute that would put the COM proxy on our own thread
            // but BeginInvoke, even though it is ugle, works fine.
            m_QsoCollection.AddNotifyCallback(this);
        }

        [ComVisible(true), DispId(1)] // DispId of 1 is from the WriteLogClrTypes. Its what WL uses for its QSO callback.
        public void CrossThreadQsoUpdate(uint QsoIndex)
        {
            BeginInvoke(new UpdateQsoDel(QsoUpdate), QsoIndex);   // get onto the Form's thread
        }

        /* WriteLog calls here when: 
            A QSO is added.
            A QSO is edited.
            Certain modifications (like deleting a QSO) cause WriteLog to update ALL QSO's in the log, one at a time.
         */
        private void QsoUpdate(uint QsoIndex)
        {
            labelQsoCount.Text = String.Format("{0}", m_QsoCollection.QsoCount);

            // GetQsoFieldsByIndex retrieves the entire state of the logged/edited QSO
            String AdifDate, AdifTime, AdifMode, DupeStatus;
            int SerialSent;
            double TxMhz, RxMhz;
            // For this demo, we pick off only the m_callIndex array entry
            labelCALL.Text = m_QsoCollection.GetQsoFieldsByIndex(QsoIndex, out AdifDate,
                out AdifTime, out SerialSent, out DupeStatus, out AdifMode, out TxMhz, out RxMhz)[m_callIndex];
        }

        private void QsoCollectionForm_FormClosing(object sender, FormClosingEventArgs e)
        {   // prevent further notifications to our (closed) form.
            m_QsoCollection.CancelNotifyCallback(this);
        }
    }

}
