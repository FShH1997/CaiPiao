using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaiPiao
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Rule rule_DLT_Red = new Rule(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15,
            16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35 }, 5);
        Rule rule_DLT_Blue = new Rule(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 }, 2);
        Rule rule_SSQ_Red = new Rule(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15,
            16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33 }, 6);
        Rule rule_SSQ_Blue = new Rule(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 }, 1);
        

        private void GetBalls(List<Rule> rules, int num)
        {
            for(int i = 0; i < num; i++)
            {
                for (int j = 0; j < rules.Count; j++)
                {
                    if (j == 0)
                    {
                        ShowResult(GetBallsInRule(rules[j]));
                    }
                    else
                    {
                        ShowResult(" + ", GetBallsInRule(rules[j]));
                    }
                }
                textBox_Result.AppendText(Environment.NewLine);
            }
        }
        /// <summary>
        /// 用指定的规则生成一组彩票号码组合
        /// </summary>
        /// <param name="rule">
        /// Rule类的对象，表示“从几个有限的数字中选取若干个数字”的规则，例如表示双色球中红球的规则
        /// </param>
        /// <returns>
        /// int[]类型的数组，表示选择出来的数字组合
        /// </returns>
        private int[] GetBallsInRule(Rule rule)
        {
            int[] indexOfBalls = new int[rule.GetAmount()]; //选中的数字在rule.nums数组中的下标
            for(int i = 0;i < indexOfBalls.Length; i++)
            {
                indexOfBalls[i] = -1;
            }
            int indexOfBall_Now = 0;
            double[] LuckOfBalls = new double[rule.GetNums().Length];
            int seed = (int)DateTime.Now.Ticks;
            Random random = new Random(seed);
            do
            {
                double sumCheck = LuckOfBalls.Sum();
                do
                {
                flag: int index_Luck = random.Next(LuckOfBalls.Length);
                    foreach(int i in indexOfBalls)
                    {
                        if(i == index_Luck)
                        {
                            goto flag;
                        }
                    }
                    if((LuckOfBalls[index_Luck] += (random.NextDouble() + 0.01)) >= 100)
                    {
                        indexOfBalls[indexOfBall_Now++] = index_Luck;
                        break;
                    }
                    if (sumCheck >= (sumCheck = LuckOfBalls.Sum()))
                    {
                        MessageBox.Show("LuckOfBalls累加检查出错", "？");
                        break;
                    }
                } while (true);
            } while (indexOfBall_Now < indexOfBalls.Length);
            Array.Sort(indexOfBalls);
            int[] Results = new int[indexOfBalls.Length];
            for(int i = 0; i < Results.Length; i++)
            {
                Results[i] = rule.GetNums()[indexOfBalls[i]];
            }
            return Results;
        }
        /// <summary>
        /// 将数字组合在textBox_Result中追加显示
        /// </summary>
        /// <param name="result">
        /// int[]类型的数组，表示选择出来的数字组合
        /// </param>
        private void ShowResult(int[] result)
        {
            for (int i = 0; i < result.Length; i++)
            {
                if (i == 0)
                {
                    textBox_Result.AppendText(result[i].ToString());
                }
                else
                {
                    textBox_Result.AppendText(", " + result[i].ToString());
                }
            }
        }
        /// <summary>
        /// 将数字组合在textBox_Result中追加显示，在数字组合开头添加指定字符串
        /// </summary>
        /// <param name="str_Head">
        /// 在数字组合开头需要显示的字符串
        /// </param>
        /// <param name="result">
        /// int[]类型的数组，表示选择出来的数字组合
        /// </param>
        private void ShowResult(string str_Head, int[] result)
        {
            textBox_Result.AppendText(str_Head);
            for (int i = 0; i < result.Length; i++)
            {
                if (i == 0)
                {
                    textBox_Result.AppendText(result[i].ToString());
                }
                else
                {
                    textBox_Result.AppendText(", " + result[i].ToString());
                }
            }
        }
        /// <summary>
        /// 将数字组合在textBox_Result中追加显示，在数字组合结尾添加指定字符串
        /// </summary>
        /// <param name="result">
        /// int[]类型的数组，表示选择出来的数字组合
        /// </param>
        /// <param name="str_End">
        /// 在数字组合结尾需要显示的字符串
        /// </param>
        private void ShowResult(int[] result, string str_End)
        {
            for (int i = 0; i < result.Length; i++)
            {
                if (i == 0)
                {
                    textBox_Result.AppendText(result[i].ToString());
                }
                else
                {
                    textBox_Result.AppendText(", " + result[i].ToString());
                }
            }
            textBox_Result.AppendText(str_End);
        }
        /// <summary>
        /// 将数字组合在textBox_Result中追加显示，在数字组合开头和结尾添加指定字符串
        /// </summary>
        /// <param name="str_Head">
        /// 在数字组合开头需要显示的字符串
        /// </param>
        /// <param name="result">
        /// int[]类型的数组，表示选择出来的数字组合
        /// </param>
        /// <param name="str_End">
        /// 在数字组合结尾需要显示的字符串
        /// </param>
        private void ShowResult(string str_Head, int[] result, string str_End)
        {
            textBox_Result.AppendText(str_Head);
            for (int i = 0; i < result.Length; i++)
            {
                if (i == 0)
                {
                    textBox_Result.AppendText(result[i].ToString());
                }
                else
                {
                    textBox_Result.AppendText(", " + result[i].ToString());
                }
            }
            textBox_Result.AppendText(str_End);
        }
        /// <summary>
        /// debug
        /// </summary>
        private void button_Debug_Click(object sender, EventArgs e)
        {
            //int[] result = GetBallsInRule(rule_DLT_Red);
            //foreach (int i in result)
            //{
            //    Console.WriteLine(i.ToString());
            //}
            //Console.WriteLine("\n");
            //ShowResult(result);
            //result = GetBallsInRule(rule_DLT_Blue);
            //foreach (int i in result)
            //{
            //    Console.WriteLine(i.ToString());
            //}
            //Console.WriteLine("\n");
            //ShowResult(result);

        }
        /// <summary>
        /// 不重要
        /// </summary>
        private void radioButton_Rule0_Click(object sender, EventArgs e)
        {
            MessageBox.Show("敬请期待", "~");
        }
        /// <summary>
        /// 使textBox_Result的大小随窗口大小变化而变化
        /// </summary>
        private void Form1_Resize(object sender, EventArgs e)
        {
            textBox_Result.Size = new Size(this.Size.Width - 350, this.Size.Height - 100);
        }
        /// <summary>
        /// 按下按钮后的执行函数，实现随机生成指定数量的对应规则的数字组合，并显示在textBox_Result中
        /// </summary>
        private void button_BIU_Click(object sender, EventArgs e)
        {
            if(checkBox_Clear.Checked)
            {
                textBox_Result.Clear();
            }
            if(radioButton_Rule_DLT.Checked)
            {
                List<Rule> rules_DLT = new List<Rule>();
                rules_DLT.Add(rule_DLT_Red);
                rules_DLT.Add(rule_DLT_Blue);
                GetBalls(rules_DLT, (int)numericUpDown_nums.Value);
            }
            else if (radioButton_Rule_SSQ.Checked)
            {
                List<Rule> rules_SSQ = new List<Rule>();
                rules_SSQ.Add(rule_SSQ_Red);
                rules_SSQ.Add(rule_SSQ_Blue);
                GetBalls(rules_SSQ, (int)numericUpDown_nums.Value);
            }
            else
            {
                MessageBox.Show("你咋点出来的？？？", "？？？");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
    /// <summary>
    /// Rule类表示彩票规则，建议以List<Rule>形式使用
    /// 成员int[] nums表示数字范围
    /// 成员int amount表示范围内需要选取的数字数量
    /// 例如nums = {1, 2, 3, 4, 5}; amount = 2时，表示从1至5中选取2个数
    /// 以List<Rule>的形式可表示例如大乐透“1-35内选5个数，1-12内选2个数”这类规则
    /// </summary>
    /// 
    internal partial class Rule
    {
        private int[] nums = new int[1];
        private int amount = 1;

        public Rule(int[] newNums, int newAmount)
        {
            this.nums = newNums;
            this.amount = newAmount;
        }

        public int[] GetNums()
        {
            return this.nums;
        }

        public int GetAmount()
        {
            return this.amount;
        }
    }
}
