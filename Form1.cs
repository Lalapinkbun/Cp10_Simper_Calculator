using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practice_10_3
{
    public partial class Form1 : Form
    {
        public double numB1;
        public double numB2;
        public double numBfinal;
        public Form1()
        {
            InitializeComponent();
        }

        private void ResultMsg(DialogResult result)
        {
            return;
        }

        private void btnWhat_Click(object sender, EventArgs e)
        {
            MessageBox.Show("这是第十章第三题的实作题");
            MessageBox.Show("题目要求制作一个简易计算机");
        }

        private void btnMath_Click(object sender, EventArgs e)
        {
            String message1 = "注意";
            MessageBoxButtons btnYesCancel = MessageBoxButtons.OKCancel;
            MessageBoxIcon iconWarn = MessageBoxIcon.Warning;
            DialogResult result;
            if (txtMath1.Text == "")
            {
                //MessageBox.Show("请输入至少一个数字（数值一）");
                result = MessageBox.Show("请输入至少一位数的数字（数值一）", message1, btnYesCancel, iconWarn);
                ResultMsg(result);
                
            }
            else
                numB1 = Convert.ToDouble(txtMath1.Text);
            if (txtMath2.Text == "")
            {
                //MessageBox.Show("请输入至少一个数字（数值二）");
                result = MessageBox.Show("请输入至少一位数的数字（数值二）", message1, btnYesCancel, iconWarn);
                ResultMsg(result);
            }
            else
                numB2 = Convert.ToDouble(txtMath2.Text);

            if (btnPlus.Checked == true)
            {
                numBfinal = numB1 + numB2;
                MessageBox.Show("两数相加为：" + numBfinal);
            }
            else if (btnMinus.Checked == true)
            {
                numBfinal = numB1 - numB2;
                MessageBox.Show("两数相减为：" + numBfinal);
            }
            else if (btnMultiply.Checked == true)
            {
                numBfinal = numB1 * numB2;
                MessageBox.Show("两数相乘为：" + numBfinal);
            }
            else if (btnDivide.Checked == true)
            {
                numBfinal = numB1 / numB2;
                MessageBox.Show("两数相除为：" + numBfinal);
            }
            else
            {
                //MessageBox.Show("请至少选择一个运算符号");
                result = MessageBox.Show("请至少选择一个运算符号", message1, btnYesCancel, iconWarn);
                ResultMsg(result);
            }
        }
    }
}
