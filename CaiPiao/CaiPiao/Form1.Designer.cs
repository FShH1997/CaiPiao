namespace CaiPiao
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label_sign = new System.Windows.Forms.Label();
            this.label_Rules = new System.Windows.Forms.Label();
            this.label_nums = new System.Windows.Forms.Label();
            this.radioButton_Rule_DLT = new System.Windows.Forms.RadioButton();
            this.panel_Rules = new System.Windows.Forms.Panel();
            this.radioButton_Rule0 = new System.Windows.Forms.RadioButton();
            this.radioButton_Rule_SSQ = new System.Windows.Forms.RadioButton();
            this.numericUpDown_nums = new System.Windows.Forms.NumericUpDown();
            this.button_Debug = new System.Windows.Forms.Button();
            this.textBox_Result = new System.Windows.Forms.TextBox();
            this.button_BIU = new System.Windows.Forms.Button();
            this.checkBox_Clear = new System.Windows.Forms.CheckBox();
            this.panel_Rules.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_nums)).BeginInit();
            this.SuspendLayout();
            // 
            // label_sign
            // 
            this.label_sign.AutoSize = true;
            this.label_sign.Enabled = false;
            this.label_sign.Location = new System.Drawing.Point(10, 10);
            this.label_sign.Name = "label_sign";
            this.label_sign.Size = new System.Drawing.Size(101, 12);
            this.label_sign.TabIndex = 0;
            this.label_sign.Text = "Designed by 大海";
            // 
            // label_Rules
            // 
            this.label_Rules.AutoSize = true;
            this.label_Rules.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_Rules.Location = new System.Drawing.Point(30, 40);
            this.label_Rules.Name = "label_Rules";
            this.label_Rules.Size = new System.Drawing.Size(73, 21);
            this.label_Rules.TabIndex = 1;
            this.label_Rules.Text = "规则：";
            // 
            // label_nums
            // 
            this.label_nums.AutoSize = true;
            this.label_nums.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_nums.Location = new System.Drawing.Point(30, 150);
            this.label_nums.Name = "label_nums";
            this.label_nums.Size = new System.Drawing.Size(73, 21);
            this.label_nums.TabIndex = 3;
            this.label_nums.Text = "数量：";
            // 
            // radioButton_Rule_DLT
            // 
            this.radioButton_Rule_DLT.AutoSize = true;
            this.radioButton_Rule_DLT.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.radioButton_Rule_DLT.Location = new System.Drawing.Point(5, 9);
            this.radioButton_Rule_DLT.Name = "radioButton_Rule_DLT";
            this.radioButton_Rule_DLT.Size = new System.Drawing.Size(127, 24);
            this.radioButton_Rule_DLT.TabIndex = 4;
            this.radioButton_Rule_DLT.TabStop = true;
            this.radioButton_Rule_DLT.Text = "体彩大乐透";
            this.radioButton_Rule_DLT.UseVisualStyleBackColor = true;
            // 
            // panel_Rules
            // 
            this.panel_Rules.Controls.Add(this.radioButton_Rule0);
            this.panel_Rules.Controls.Add(this.radioButton_Rule_SSQ);
            this.panel_Rules.Controls.Add(this.radioButton_Rule_DLT);
            this.panel_Rules.Location = new System.Drawing.Point(100, 30);
            this.panel_Rules.Name = "panel_Rules";
            this.panel_Rules.Size = new System.Drawing.Size(150, 90);
            this.panel_Rules.TabIndex = 6;
            // 
            // radioButton_Rule0
            // 
            this.radioButton_Rule0.AutoSize = true;
            this.radioButton_Rule0.Enabled = false;
            this.radioButton_Rule0.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.radioButton_Rule0.Location = new System.Drawing.Point(5, 59);
            this.radioButton_Rule0.Name = "radioButton_Rule0";
            this.radioButton_Rule0.Size = new System.Drawing.Size(87, 24);
            this.radioButton_Rule0.TabIndex = 6;
            this.radioButton_Rule0.TabStop = true;
            this.radioButton_Rule0.Text = "自定义";
            this.radioButton_Rule0.UseVisualStyleBackColor = true;
            this.radioButton_Rule0.Click += new System.EventHandler(this.radioButton_Rule0_Click);
            // 
            // radioButton_Rule_SSQ
            // 
            this.radioButton_Rule_SSQ.AutoSize = true;
            this.radioButton_Rule_SSQ.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.radioButton_Rule_SSQ.Location = new System.Drawing.Point(5, 34);
            this.radioButton_Rule_SSQ.Name = "radioButton_Rule_SSQ";
            this.radioButton_Rule_SSQ.Size = new System.Drawing.Size(127, 24);
            this.radioButton_Rule_SSQ.TabIndex = 5;
            this.radioButton_Rule_SSQ.TabStop = true;
            this.radioButton_Rule_SSQ.Text = "福彩双色球";
            this.radioButton_Rule_SSQ.UseVisualStyleBackColor = true;
            // 
            // numericUpDown_nums
            // 
            this.numericUpDown_nums.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.numericUpDown_nums.Location = new System.Drawing.Point(100, 145);
            this.numericUpDown_nums.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_nums.Name = "numericUpDown_nums";
            this.numericUpDown_nums.Size = new System.Drawing.Size(150, 30);
            this.numericUpDown_nums.TabIndex = 7;
            this.numericUpDown_nums.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDown_nums.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // button_Debug
            // 
            this.button_Debug.Location = new System.Drawing.Point(117, 5);
            this.button_Debug.Name = "button_Debug";
            this.button_Debug.Size = new System.Drawing.Size(75, 23);
            this.button_Debug.TabIndex = 8;
            this.button_Debug.Text = "debug";
            this.button_Debug.UseVisualStyleBackColor = true;
            this.button_Debug.Visible = false;
            this.button_Debug.Click += new System.EventHandler(this.button_Debug_Click);
            // 
            // textBox_Result
            // 
            this.textBox_Result.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_Result.Location = new System.Drawing.Point(300, 30);
            this.textBox_Result.Multiline = true;
            this.textBox_Result.Name = "textBox_Result";
            this.textBox_Result.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox_Result.Size = new System.Drawing.Size(350, 300);
            this.textBox_Result.TabIndex = 9;
            // 
            // button_BIU
            // 
            this.button_BIU.Font = new System.Drawing.Font("宋体", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_BIU.Location = new System.Drawing.Point(50, 200);
            this.button_BIU.Name = "button_BIU";
            this.button_BIU.Size = new System.Drawing.Size(200, 100);
            this.button_BIU.TabIndex = 10;
            this.button_BIU.Text = " 开奖！";
            this.button_BIU.UseVisualStyleBackColor = true;
            this.button_BIU.Click += new System.EventHandler(this.button_BIU_Click);
            // 
            // checkBox_Clear
            // 
            this.checkBox_Clear.AutoSize = true;
            this.checkBox_Clear.Checked = true;
            this.checkBox_Clear.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_Clear.Location = new System.Drawing.Point(154, 314);
            this.checkBox_Clear.Name = "checkBox_Clear";
            this.checkBox_Clear.Size = new System.Drawing.Size(96, 16);
            this.checkBox_Clear.TabIndex = 11;
            this.checkBox_Clear.Text = "覆盖右侧记录";
            this.checkBox_Clear.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 361);
            this.Controls.Add(this.checkBox_Clear);
            this.Controls.Add(this.button_BIU);
            this.Controls.Add(this.textBox_Result);
            this.Controls.Add(this.button_Debug);
            this.Controls.Add(this.numericUpDown_nums);
            this.Controls.Add(this.panel_Rules);
            this.Controls.Add(this.label_nums);
            this.Controls.Add(this.label_Rules);
            this.Controls.Add(this.label_sign);
            this.Name = "Form1";
            this.Text = "中了分我一半";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.panel_Rules.ResumeLayout(false);
            this.panel_Rules.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_nums)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_sign;
        private System.Windows.Forms.Label label_Rules;
        private System.Windows.Forms.Label label_nums;
        private System.Windows.Forms.RadioButton radioButton_Rule_DLT;
        private System.Windows.Forms.Panel panel_Rules;
        private System.Windows.Forms.RadioButton radioButton_Rule_SSQ;
        private System.Windows.Forms.RadioButton radioButton_Rule0;
        private System.Windows.Forms.NumericUpDown numericUpDown_nums;
        private System.Windows.Forms.Button button_Debug;
        private System.Windows.Forms.TextBox textBox_Result;
        private System.Windows.Forms.Button button_BIU;
        private System.Windows.Forms.CheckBox checkBox_Clear;
    }
}

