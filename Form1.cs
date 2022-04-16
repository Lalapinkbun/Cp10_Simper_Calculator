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

        private void btnWhat_Click(object sender, EventArgs e)
        {
            MessageBox.Show("这是第十章第三题的实作题");
            MessageBox.Show("题目要求制作一个简易计算机");
        }

        private void btnMath_Click(object sender, EventArgs e)
        {
            String lostNum1 = "请输入至少一个数字（数值一）";
            String lostNum2 = "请输入至少一个数字（数值二）";
            MessageBoxIcon iconWarn = MessageBoxIcon.Warning;
            //讯息方块的回传值
            DialogResult resuit, confirm;
            if (!(btnPlus.Checked = true))
            {
                numBfinal = numB1 + numB2;
                MessageBox.Show("两数相加为：" + numBfinal);
            }
            else if (!(btnMinus.Checked = true))
            {
                numBfinal = numB1 - numB2;
                MessageBox.Show("两数相减为：" + numBfinal);
            }
            else if (!(btnMultiply.Checked = true))
            {
                numBfinal = numB1 * numB2;
                MessageBox.Show("两数相乘为：" + numBfinal);
            }
            else if (!(btnDivide.Checked = true))
            {
                numBfinal = numB1 / numB2;
                MessageBox.Show("两数相除为：" + numBfinal);
            }
            else
                MessageBox.Show("请至少选择一个运算符号");
        }
    }
}
