using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
动态画分形树。
2017-4-3 11:52:24
个人觉得本程序比较完善地满足了老师的题意。
用枝干长度作为递归终止条件，当长小于一个值时结束递归。
实现了将两棵子树的生长点处于不同位置（81、82、86、87行）
可以修改角度、长度，可以选择颜色（51、95、140~142行）
颜色、粗细、是否随机 也有了（86、87、134行）
在输入框给了默认值以及输入范围提示；
以及加入了异常处理去处理输入不合规则的情况。
还可以拓展的情况有：加上叶子（在递归到最后一层时执行画叶子函数就可以）、
按层分色、不止是2个枝条（例如改为4个）等。
    */

namespace drawFractalTrees {
    public partial class Form1 : Form {
        public Form1 () {
            this.AutoScaleBaseSize = new Size(6, 14);
            //this.ClientSize = new Size(680, 480);
            //this.Paint += new PaintEventHandler(this.Form1_Paint);
            InitializeComponent();

        }
        
        //这边是默认的一些值
        private double treeLen = 120;
        private float pWid = 6;
        private double totalAngle = 60;
        private double rightAngle = 32;
        double th1;
        double th2;
        double rightAtnt = 0.6;//right attenuation右边枝条的长度衰减
        double leftAtnt = 0.7;// left attenuation
        double key = 0.75;//位置系数
        private Color pColors = Color.FromArgb(222, 184, 135);

        //画分形树的递归部分
        void drawFractalsTree (double x0, 
            double y0, double leng, double th, float pWid, Graphics grp) {
            //输入的变量分别为：x0:初始点x坐标  y0:初始点y坐标
            //leng:长度   th:角度   pWid:笔宽度
            Random ran = new Random();
            float widChange = ran.Next(65, 91) / 100.0f;
            if (leng <= 4 | pWid<=0.6) return;
            pColors = TreesColDialog.Color;
            /*
            if (leng < 42) //用来实现不同地方颜色不同的
                pColors = Color.FromArgb(0,255,127);
            else
                pColors =Color.FromArgb(222, 184, 135);
            */
            
            if (ranBchAng.Checked) {//两个枝条的夹角随机时
                totalAngle = ran.Next(20, 101);
                rightAngle = ran.Next(15, (int)totalAngle );
                if (ranBchLen.Checked & ranKey.Checked) {
                    pColors = Color.FromArgb(ran.Next(0, 256), ran.Next(0, 256), ran.Next(0, 256));
                }//颜色全部随机选取
            }
            else {
                totalAngle = Convert.ToDouble(BranchAngle.Text);
                rightAngle =totalAngle/2.0-ran.Next(0,4);
                //rightAngle = ran.Next(12, (int)totalAngle - 1);
            }
            th1 = rightAngle * Math.PI / 180.0;
            th2 = (totalAngle - rightAngle) * Math.PI / 180.0;

            if (ranKey.Checked)
                key = ran.Next(60, 101) / 100.0;
            else
                key = Convert.ToDouble(LenKey.Text);

            double x1 = x0 + leng * Math.Cos(th);
            double y1 = y0 + leng * Math.Sin(th);
            double x2=x0+ leng * Math.Cos(th)*key;
            double y2 = y0 + leng * Math.Sin(th)*key;

            drawLine(x0, y0, x1, y1,pWid,pColors,grp);

            drawFractalsTree(x1, y1, rightAtnt * leng, th + th1, widChange*pWid, grp);
            drawFractalsTree( x2, y2, leftAtnt * leng, th - th2, widChange*pWid, grp);
        }
        void drawLine (double x0, double y0, double x1, double y1,float pWid,Color pCol, Graphics grph) {
            //pWid 笔的宽度
            //gras.DrawLine(new Pen(pCol,pWid),(int)x0, (int)y0, (int)x1, (int)y1);
            grph.DrawLine(new Pen(pCol, pWid), (int)x0, (int)y0, (int)x1, (int)y1);
        }

        private void ColBtn_Click (object sender, EventArgs e) {
            //选择颜色的按钮
            TreesColDialog.CustomColors = new int[] { 6916092, 15195440, 16107657, 1836924, 3758726, 12566463, 7526079, 7405793, 6945974, 241502 };
            TreesColDialog.ShowHelp = true;
            TreesColDialog.ShowDialog();
        }

        private void drawFaTree_Click (object sender, EventArgs e) {//画分形树按钮
            Graphics grp = this.CreateGraphics();
            grp.Clear(BackColor);
            Random rand = new Random();
            if (ranBchLen.Checked)//初始枝条长度随机时
                treeLen = rand.Next(50, 201);
            else {
                try { //异常处理，当输入不对时
                    treeLen = Convert.ToDouble(BranchesLen.Text);
                    if (treeLen > 200 | treeLen < 50)
                        MessageBox.Show("请输入[50,200]之间的数", "提示");
                }
                catch (Exception) {
                    MessageBox.Show("您的输入不合要求","提示");
                }
            }
            if (ranBchWid.Checked)//枝条宽度随机时
                pWid = rand.Next(3, 11);
            else {
                try {
                    pWid = Convert.ToSingle(BchWidth.Text);
                    if (pWid > 10 | pWid < 3)
                        MessageBox.Show("请输入[3,10]之间的数", "提示");
                }
                catch (Exception) {
                    MessageBox.Show("您的输入不合要求", "提示");
                }
            }

            drawFractalsTree(300, 465, treeLen, -Math.PI / 2, pWid,grp);
        }

        private void drawRanFaTree_Click (object sender, EventArgs e) {
            Graphics grphs = this.CreateGraphics();
            grphs.Clear(BackColor);
            Random rand = new Random();
            treeLen = rand.Next(50, 201);
            pWid = rand.Next(3, 11);
            ranBchLen.Checked = true;
            ranBchAng.Checked = true;
            ranKey.Checked = true;//设置三项都是随机
            drawFractalsTree(300, 465, treeLen, -Math.PI / 2, pWid, grphs);
        }
    }
}



