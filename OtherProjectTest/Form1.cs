using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OtherProjectTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Text = "策略模式";
        }
        double TotalMoney = 0;
        private void btnOK_Click(object sender, EventArgs e)
        {
            double totalPrice = 0;
            CashContext cashcontext = new CashContext(this.cmbcalc.SelectedItem.ToString());
            totalPrice = cashcontext.ContextStrategy(Convert.ToDouble(this.txtNumber.Text)*Convert.ToDouble(this.txtUnitPrice.Text));
            TotalMoney = TotalMoney + totalPrice;
            this.txtDis.Text += string.Format("单价:{0},数量:{1}\t{2} 合计:{3}\r\n"
                , this.txtUnitPrice.Text, this.txtNumber.Text,
                  this.cmbcalc.SelectedItem.ToString(), totalPrice.ToString());

            this.lblTotal.Text = TotalMoney.ToString();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < this.Controls.Count; i++)
            {
                object control = this.Controls[i];
                if (control is TextBox)
                {
                    TextBox txt = control as TextBox;
                    txt.Text = "";
                }
                if (control is ComboBox) {
                    ComboBox cmb = control as ComboBox;
                    cmb.SelectedIndex = 0;
                }
            }
            this.lblTotal.Text = "";
        }
    }
}
