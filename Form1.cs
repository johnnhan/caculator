using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculate
{
    public partial class Form1 : Form
    {
        private double num1;
        private double num2;
        private int curOper;  // 1代表+，2代表-，3代表*，4代表/
        private bool operStatus;  // 操作符状态，当上一个输入是操作符时为真
        private bool equalStatus;  // 等号状态，当上一个输入是=时为真

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            num1 = 0;
            num2 = 0;
            curOper = 0;
            operStatus = false;
            equalStatus = false;
        }

        private void number0_Click(object sender, EventArgs e)
        {
            handleValue(((Button)sender).Text);
        }

        private void number1_Click(object sender, EventArgs e)
        {
            handleValue(((Button)sender).Text);
        }

        private void number2_Click(object sender, EventArgs e)
        {
            handleValue(((Button)sender).Text);
        }

        private void number3_Click(object sender, EventArgs e)
        {
            handleValue(((Button)sender).Text);
        }

        private void number4_Click(object sender, EventArgs e)
        {
            handleValue(((Button)sender).Text);
        }

        private void number5_Click(object sender, EventArgs e)
        {
            handleValue(((Button)sender).Text);
        }

        private void number6_Click(object sender, EventArgs e)
        {
            handleValue(((Button)sender).Text);
        }

        private void number7_Click(object sender, EventArgs e)
        {
            handleValue(((Button)sender).Text);
        }

        private void number8_Click(object sender, EventArgs e)
        {
            handleValue(((Button)sender).Text);
        }

        private void number9_Click(object sender, EventArgs e)
        {
            handleValue(((Button)sender).Text);
        }

        private void neg_Click(object sender, EventArgs e)
        {
            if (value.Text == "" || equalStatus || operStatus) value.Text = "-";
            else if (value.Text == "-") value.Text = "";

            if (equalStatus) curOper = 0;  // 如果上次一输入是=，再输入数字时相当于重新开始计算，curOper初始化
            operStatus = false;  // 只要按了-/+运算符状态就为false
            equalStatus = false;  // 只要按了-/+等号状态就为false
        }

        private void ac_Click(object sender, EventArgs e)
        {
            value.Text = "";
            Form1_Load(null, null);
        }

        private void point_Click(object sender, EventArgs e)
        {
            if (equalStatus || operStatus || conTainPoint() || valueIsNull() || tooLong()) return;
            value.Text += ".";
        }

        private void del_Click(object sender, EventArgs e)
        {
            string t = value.Text;
            if (t.Length == 0 || equalStatus || operStatus) return;
            value.Text = t.Substring(0, t.Length - 1);
        }

        private void plus_Click(object sender, EventArgs e)
        {
            handleOper(1);
        }

        private void sub_Click(object sender, EventArgs e)
        {
            handleOper(2);
        }

        private void mul_Click(object sender, EventArgs e)
        {
            handleOper(3);
        }

        private void div_Click(object sender, EventArgs e)
        {
            handleOper(4);
        }

        private void equal_Click(object sender, EventArgs e)
        {
            if (sender != null && (operStatus || endWithPoint() || valueIsNull())) return;  // 按了运算符以及数字以后不能直接按=

            if (equalStatus) num1 = double.Parse(value.Text);  // 上一个操作符是=时num1重新复制num2不变
            else num2 = double.Parse(value.Text);  // 上一个操作符不是=时num1在运算符函数中赋值num2重新赋值

            string temp = "";
            switch (curOper) {
                case 1:
                    temp = (num1 + num2).ToString();
                    break;
                case 2:
                    temp = (num1 - num2).ToString();
                    break;
                case 3:
                    temp = (num1 * num2).ToString();
                    break;
                case 4:
                    temp = (num1 / num2).ToString();
                    break;
            }
            value.Text = temp.Length > 14 ? temp.Substring(0, 14) : temp;

            if (sender != null) equalStatus = true;
        }

        public void handleValue(String num)
        {
            // 上一次按键为运算符或=的时候重新输入新数字，否则视为继续输入当前数字
            if (!operStatus && !equalStatus)
            {
                if (tooLong()) return;
                value.Text += num;
            }
            else value.Text = num;

            if (equalStatus) curOper = 0;  // 如果上次一输入是=，再输入数字时相当于重新开始计算，curOper初始化
            operStatus = false;  // 只要按了数字运算符状态就为false
            equalStatus = false;  // 只要按了数字等号状态就为false
        }

        public void handleOper(int operNum) {
            if (endWithPoint() || valueIsNull()) return;  // 输入的数字以.结尾则不允许输入运算符

            if (!operStatus)
            {  // 判断一下是否连续按下运算符
                if (curOper != 0 && !equalStatus) equal_Click(null, null);  // 不是第一次计算的时候，需要求值
                num1 = double.Parse(value.Text);  // 不论是否第一次计算，都要给num1赋值
            }

            operStatus = true;  //运算符状态变为真
            equalStatus = false;  // 等号状态变为假
            curOper = operNum;  // 当前运算符变更
        }

        public bool endWithPoint() {
            return value.Text.EndsWith(".");
        }

        public bool conTainPoint() {
            return value.Text.Contains(".");
        }

        public bool valueIsNull() {
            return value.Text == "";
        }

        public bool tooLong() {
            return value.Text.Length >= 14;
        }
    }
}
