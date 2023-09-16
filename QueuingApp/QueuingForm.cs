using System;
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
    public partial class QueuingForm : Form
    {
        private CashierClass cashier;
        private CashierWindowQueue cashierWindowQueue;
        public QueuingForm()
        {
            InitializeComponent();
            cashier = new CashierClass();
            cashierWindowQueue = new CashierWindowQueue();
        }

        private void btnCashier_Click(object sender, EventArgs e)
        {
            lblQueue.Text = cashier.CashierGeneratedNumber("P - ");
            CashierClass.getNumberInQueue = lblQueue.Text;
            CashierClass.CashierQueue.Enqueue(CashierClass.getNumberInQueue);

            cashierWindowQueue.Show();
        }
    }
}
