namespace drawFractalTrees {
    partial class Form1 {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose (bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent () {
            this.drawFaTree = new System.Windows.Forms.Button();
            this.drawRanFaTree = new System.Windows.Forms.Button();
            this.BranchesLen = new System.Windows.Forms.TextBox();
            this.BranchAngle = new System.Windows.Forms.TextBox();
            this.LenKey = new System.Windows.Forms.TextBox();
            this.TreesColDialog = new System.Windows.Forms.ColorDialog();
            this.ColBtn = new System.Windows.Forms.Button();
            this.ranBchLen = new System.Windows.Forms.CheckBox();
            this.ranKey = new System.Windows.Forms.CheckBox();
            this.ranBchAng = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BchWidth = new System.Windows.Forms.TextBox();
            this.ranBchWid = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // drawFaTree
            // 
            this.drawFaTree.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.drawFaTree.Location = new System.Drawing.Point(601, 391);
            this.drawFaTree.Name = "drawFaTree";
            this.drawFaTree.Size = new System.Drawing.Size(75, 23);
            this.drawFaTree.TabIndex = 0;
            this.drawFaTree.Text = "画分形树";
            this.drawFaTree.UseVisualStyleBackColor = true;
            this.drawFaTree.Click += new System.EventHandler(this.drawFaTree_Click);
            // 
            // drawRanFaTree
            // 
            this.drawRanFaTree.Location = new System.Drawing.Point(576, 441);
            this.drawRanFaTree.Name = "drawRanFaTree";
            this.drawRanFaTree.Size = new System.Drawing.Size(125, 23);
            this.drawRanFaTree.TabIndex = 1;
            this.drawRanFaTree.Text = "画一颗完全随机的树";
            this.drawRanFaTree.UseVisualStyleBackColor = true;
            this.drawRanFaTree.Click += new System.EventHandler(this.drawRanFaTree_Click);
            // 
            // BranchesLen
            // 
            this.BranchesLen.Location = new System.Drawing.Point(574, 50);
            this.BranchesLen.Name = "BranchesLen";
            this.BranchesLen.Size = new System.Drawing.Size(79, 21);
            this.BranchesLen.TabIndex = 2;
            this.BranchesLen.Text = "120";
            this.BranchesLen.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BranchAngle
            // 
            this.BranchAngle.Location = new System.Drawing.Point(576, 188);
            this.BranchAngle.Name = "BranchAngle";
            this.BranchAngle.Size = new System.Drawing.Size(79, 21);
            this.BranchAngle.TabIndex = 3;
            this.BranchAngle.Text = "64";
            this.BranchAngle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LenKey
            // 
            this.LenKey.Location = new System.Drawing.Point(576, 264);
            this.LenKey.Name = "LenKey";
            this.LenKey.Size = new System.Drawing.Size(79, 21);
            this.LenKey.TabIndex = 4;
            this.LenKey.Text = "0.76";
            this.LenKey.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TreesColDialog
            // 
            this.TreesColDialog.Color = System.Drawing.Color.Sienna;
            this.TreesColDialog.ShowHelp = true;
            // 
            // ColBtn
            // 
            this.ColBtn.BackColor = System.Drawing.Color.Sienna;
            this.ColBtn.Location = new System.Drawing.Point(576, 317);
            this.ColBtn.Name = "ColBtn";
            this.ColBtn.Size = new System.Drawing.Size(81, 30);
            this.ColBtn.TabIndex = 5;
            this.ColBtn.Text = "选择颜色";
            this.ColBtn.UseVisualStyleBackColor = false;
            this.ColBtn.Click += new System.EventHandler(this.ColBtn_Click);
            // 
            // ranBchLen
            // 
            this.ranBchLen.AutoSize = true;
            this.ranBchLen.Location = new System.Drawing.Point(671, 55);
            this.ranBchLen.Name = "ranBchLen";
            this.ranBchLen.Size = new System.Drawing.Size(48, 16);
            this.ranBchLen.TabIndex = 6;
            this.ranBchLen.Text = "随机";
            this.ranBchLen.UseVisualStyleBackColor = true;
            // 
            // ranKey
            // 
            this.ranKey.AutoSize = true;
            this.ranKey.Location = new System.Drawing.Point(673, 269);
            this.ranKey.Name = "ranKey";
            this.ranKey.Size = new System.Drawing.Size(48, 16);
            this.ranKey.TabIndex = 8;
            this.ranKey.Text = "随机";
            this.ranKey.UseVisualStyleBackColor = true;
            // 
            // ranBchAng
            // 
            this.ranBchAng.AutoSize = true;
            this.ranBchAng.Location = new System.Drawing.Point(673, 193);
            this.ranBchAng.Name = "ranBchAng";
            this.ranBchAng.Size = new System.Drawing.Size(48, 16);
            this.ranBchAng.TabIndex = 9;
            this.ranBchAng.Text = "随机";
            this.ranBchAng.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(564, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 12);
            this.label1.TabIndex = 10;
            this.label1.Text = "初始树枝长度：（50-200）";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(564, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 12);
            this.label2.TabIndex = 11;
            this.label2.Text = "两子枝夹角：（20-100）";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(564, 249);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 12);
            this.label3.TabIndex = 12;
            this.label3.Text = "两子枝长度比：（0.6-1.0）";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(564, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 12);
            this.label4.TabIndex = 13;
            this.label4.Text = "初始枝条宽度：（3-10）";
            // 
            // BchWidth
            // 
            this.BchWidth.Location = new System.Drawing.Point(574, 121);
            this.BchWidth.Name = "BchWidth";
            this.BchWidth.Size = new System.Drawing.Size(81, 21);
            this.BchWidth.TabIndex = 14;
            this.BchWidth.Text = "5";
            this.BchWidth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ranBchWid
            // 
            this.ranBchWid.AutoSize = true;
            this.ranBchWid.Location = new System.Drawing.Point(673, 126);
            this.ranBchWid.Name = "ranBchWid";
            this.ranBchWid.Size = new System.Drawing.Size(48, 16);
            this.ranBchWid.TabIndex = 15;
            this.ranBchWid.Text = "随机";
            this.ranBchWid.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 476);
            this.Controls.Add(this.ranBchWid);
            this.Controls.Add(this.BchWidth);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ranBchAng);
            this.Controls.Add(this.ranKey);
            this.Controls.Add(this.ranBchLen);
            this.Controls.Add(this.ColBtn);
            this.Controls.Add(this.LenKey);
            this.Controls.Add(this.BranchAngle);
            this.Controls.Add(this.BranchesLen);
            this.Controls.Add(this.drawRanFaTree);
            this.Controls.Add(this.drawFaTree);
            this.Name = "Form1";
            this.Text = "画分形树(Draw Fractal Tree)";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button drawFaTree;
        private System.Windows.Forms.Button drawRanFaTree;
        private System.Windows.Forms.TextBox BranchesLen;
        private System.Windows.Forms.TextBox BranchAngle;
        private System.Windows.Forms.TextBox LenKey;
        private System.Windows.Forms.ColorDialog TreesColDialog;
        private System.Windows.Forms.Button ColBtn;
        private System.Windows.Forms.CheckBox ranBchLen;
        private System.Windows.Forms.CheckBox ranKey;
        private System.Windows.Forms.CheckBox ranBchAng;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox BchWidth;
        private System.Windows.Forms.CheckBox ranBchWid;
    }
}

