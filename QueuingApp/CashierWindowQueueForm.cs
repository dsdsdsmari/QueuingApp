using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace QueuingApp
{
    public partial class CashierWindowQueue : Form
    {
        private FrmServing frmServing;
        public CashierWindowQueue()
        {
            InitializeComponent();

            System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
            timer.Interval = 1000; // 1000 milliseconds, which is 1 second
            timer.Tick += new EventHandler(timer1_thick_Tick);
            timer.Start();

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            // Refresh the ListView
            DisplayCashierQueue(CashierClass.CashierQueue);
        }


        public void DisplayCashierQueue(IEnumerable<object> CashierList)
        {
            listCashierQueue.Items.Clear();
            foreach (object obj in CashierList)
            {
                ListViewItem item = new ListViewItem(obj.ToString());
                listCashierQueue.Items.Add(item);
            }
        }


        private void btnNext_Click(object sender, EventArgs e)
        {
            if (frmServing == null || frmServing.IsDisposed)
            {
                frmServing = new FrmServing();
                frmServing.Show();
            }

            if (CashierClass.CashierQueue.Count != 0)
            {
                if (CashierClass.CashierQueue.Contains(CashierClass.CashierQueue.Peek()))
                {

                    string cas = CashierClass.CashierQueue.Peek();
                    frmServing.lblServingNum.Text = CashierClass.CashierQueue.Peek();

                    CashierClass.CashierQueue.Dequeue();
                }
            }
            else
            {
                MessageBox.Show("No more numbers in the queue.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void timer1_thick_Tick(object sender, EventArgs e)
        {
            DisplayCashierQueue(CashierClass.CashierQueue);
        }
    }
}
