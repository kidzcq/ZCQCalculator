using System.Linq.Expressions;

namespace 计算器的简单实现
{
    public partial class 简易计算器 : Form
    {
        //定义一个表达式变量
        public static string GlobalExpression = "";
        public 简易计算器()
        {
            InitializeComponent();
        }
        //按键事件
        public void AppendNumber(string num)
        {
            //判断输入的是不是数字或者小数点
            string vaildStr = ".,0,1,2,3,4,5,6,7,8,9";
            //IndexOf返回当前字符在字符串中的位置（索引）
            if (vaildStr.IndexOf(num) > -1)
            {
                //索引大于-1表示存在，说明是数字
                //全局表达式变量累计赋值
                GlobalExpression += num;

            }
            else
            {
                //说明是符号
                //如果默认没有输入数字，点击加减乘除则不走解析逻辑
                if (!string.IsNullOrEmpty(GlobalExpression))
                {
                    //不为空走运算逻辑
                    //非数字，判断最后一位
                    string lastStr = GlobalExpression.Substring(GlobalExpression.Length - 1, 1);
                    if (vaildStr.IndexOf(lastStr) > -1)
                    {
                        //如果最后一个数字，则进行运算逻辑
                        GlobalExpression = Operation(num);
                    }
                    {

                    }
                }
            }
            Expression.Text = GlobalExpression;

        }

        public string Operation(string num)
        {
            //运算逻辑 
            char[] arr = new char[] { '+', '-', '*', '/', '%' };
            foreach (var item in arr)
            {
                numberOpre(item);
            }
            if (num != "=")
            {
                GlobalExpression += num;
            }
            return GlobalExpression;
        }

        // 运算逻辑

        public void numberOpre(char Symbol)
        {
            if (GlobalExpression.Contains(Symbol))
            {

                string[] temps = GlobalExpression.Split(new char[] { Symbol }, StringSplitOptions.RemoveEmptyEntries);
                if (temps.Length > 1)
                {
                    switch (Symbol)
                    {
                        case '+':
                            GlobalExpression = (Convert.ToDecimal(temps[0]) + Convert.ToDecimal(temps[1])).ToString();
                            break;
                        case '-':
                            GlobalExpression = (Convert.ToDecimal(temps[0]) - Convert.ToDecimal(temps[1])).ToString();
                            break;
                        case '*':
                            GlobalExpression = (Convert.ToDecimal(temps[0]) * Convert.ToDecimal(temps[1])).ToString();

                            break;
                        case '/':
                            GlobalExpression = (Convert.ToDecimal(temps[0]) / Convert.ToDecimal(temps[1])).ToString();

                            break;
                        case '%':
                            GlobalExpression = (Convert.ToDecimal(temps[0]) % Convert.ToDecimal(temps[1])).ToString();

                            break;
                    }
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            AppendNumber("1");
        }

        //清空输入内容
        private void button10_Click(object sender, EventArgs e)
        {
            GlobalExpression = "";
            Expression.Text = "";
        }
        //减法运算
        private void button15_Click_1(object sender, EventArgs e)
        {
            AppendNumber("-");
        }
        //乘法运算
        private void button13_Click(object sender, EventArgs e)
        {
            AppendNumber("*");
        }


        private void button2_Click_1(object sender, EventArgs e)
        {
            AppendNumber("2");
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            AppendNumber("3");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AppendNumber("4");
        }

        private void button5_Click_2(object sender, EventArgs e)
        {
            AppendNumber("5");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            AppendNumber("6");
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            AppendNumber("7");
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            AppendNumber("8");
        }

        private void button9_Click_2(object sender, EventArgs e)
        {
            AppendNumber("9");
        }

        private void add_Click(object sender, EventArgs e)
        {
            AppendNumber("+");
        }
        //除法运算
        private void dividedBy_Click(object sender, EventArgs e)
        {
            AppendNumber("/");
        }

        private void button11_Click_1(object sender, EventArgs e)
        {
            AppendNumber(".");
        }

        private void button10_Click_2(object sender, EventArgs e)
        {
            AppendNumber("0");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            AppendNumber("=");
        }

        private void button13_Click_1(object sender, EventArgs e)
        {
            AppendNumber("%");
        }
    }
}
