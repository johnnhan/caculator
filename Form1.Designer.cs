namespace Calculate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.number7 = new System.Windows.Forms.Button();
            this.value = new System.Windows.Forms.Label();
            this.number8 = new System.Windows.Forms.Button();
            this.number9 = new System.Windows.Forms.Button();
            this.sub = new System.Windows.Forms.Button();
            this.mul = new System.Windows.Forms.Button();
            this.div = new System.Windows.Forms.Button();
            this.del = new System.Windows.Forms.Button();
            this.ac = new System.Windows.Forms.Button();
            this.plus = new System.Windows.Forms.Button();
            this.number6 = new System.Windows.Forms.Button();
            this.number5 = new System.Windows.Forms.Button();
            this.number4 = new System.Windows.Forms.Button();
            this.number3 = new System.Windows.Forms.Button();
            this.number2 = new System.Windows.Forms.Button();
            this.number1 = new System.Windows.Forms.Button();
            this.point = new System.Windows.Forms.Button();
            this.number0 = new System.Windows.Forms.Button();
            this.neg = new System.Windows.Forms.Button();
            this.equal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // number7
            // 
            this.number7.CausesValidation = false;
            this.number7.Location = new System.Drawing.Point(16, 136);
            this.number7.Name = "number7";
            this.number7.Size = new System.Drawing.Size(64, 36);
            this.number7.TabIndex = 20;
            this.number7.TabStop = false;
            this.number7.Text = "7";
            this.number7.UseVisualStyleBackColor = true;
            this.number7.Click += new System.EventHandler(this.number7_Click);
            // 
            // value
            // 
            this.value.BackColor = System.Drawing.Color.White;
            this.value.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.value.Font = new System.Drawing.Font("微软雅黑", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.value.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.value.Location = new System.Drawing.Point(16, 16);
            this.value.Name = "value";
            this.value.Size = new System.Drawing.Size(292, 44);
            this.value.TabIndex = 1;
            this.value.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // number8
            // 
            this.number8.Location = new System.Drawing.Point(92, 136);
            this.number8.Name = "number8";
            this.number8.Size = new System.Drawing.Size(64, 36);
            this.number8.TabIndex = 2;
            this.number8.TabStop = false;
            this.number8.Text = "8";
            this.number8.UseVisualStyleBackColor = true;
            this.number8.Click += new System.EventHandler(this.number8_Click);
            // 
            // number9
            // 
            this.number9.Location = new System.Drawing.Point(168, 136);
            this.number9.Name = "number9";
            this.number9.Size = new System.Drawing.Size(64, 36);
            this.number9.TabIndex = 3;
            this.number9.TabStop = false;
            this.number9.Text = "9";
            this.number9.UseVisualStyleBackColor = true;
            this.number9.Click += new System.EventHandler(this.number9_Click);
            // 
            // sub
            // 
            this.sub.Location = new System.Drawing.Point(244, 136);
            this.sub.Name = "sub";
            this.sub.Size = new System.Drawing.Size(64, 36);
            this.sub.TabIndex = 4;
            this.sub.TabStop = false;
            this.sub.Text = "-";
            this.sub.UseVisualStyleBackColor = true;
            this.sub.Click += new System.EventHandler(this.sub_Click);
            // 
            // mul
            // 
            this.mul.Location = new System.Drawing.Point(244, 88);
            this.mul.Name = "mul";
            this.mul.Size = new System.Drawing.Size(64, 36);
            this.mul.TabIndex = 8;
            this.mul.TabStop = false;
            this.mul.Text = "*";
            this.mul.UseVisualStyleBackColor = true;
            this.mul.Click += new System.EventHandler(this.mul_Click);
            // 
            // div
            // 
            this.div.Location = new System.Drawing.Point(168, 88);
            this.div.Name = "div";
            this.div.Size = new System.Drawing.Size(64, 36);
            this.div.TabIndex = 7;
            this.div.TabStop = false;
            this.div.Text = "/";
            this.div.UseVisualStyleBackColor = true;
            this.div.Click += new System.EventHandler(this.div_Click);
            // 
            // del
            // 
            this.del.Location = new System.Drawing.Point(92, 88);
            this.del.Name = "del";
            this.del.Size = new System.Drawing.Size(64, 36);
            this.del.TabIndex = 6;
            this.del.TabStop = false;
            this.del.Text = "←";
            this.del.UseVisualStyleBackColor = true;
            this.del.Click += new System.EventHandler(this.del_Click);
            // 
            // ac
            // 
            this.ac.Location = new System.Drawing.Point(16, 88);
            this.ac.Name = "ac";
            this.ac.Size = new System.Drawing.Size(64, 36);
            this.ac.TabIndex = 5;
            this.ac.TabStop = false;
            this.ac.Text = "AC";
            this.ac.UseVisualStyleBackColor = true;
            this.ac.Click += new System.EventHandler(this.ac_Click);
            // 
            // plus
            // 
            this.plus.Location = new System.Drawing.Point(244, 184);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(64, 36);
            this.plus.TabIndex = 12;
            this.plus.TabStop = false;
            this.plus.Text = "+";
            this.plus.UseVisualStyleBackColor = true;
            this.plus.Click += new System.EventHandler(this.plus_Click);
            // 
            // number6
            // 
            this.number6.Location = new System.Drawing.Point(168, 184);
            this.number6.Name = "number6";
            this.number6.Size = new System.Drawing.Size(64, 36);
            this.number6.TabIndex = 11;
            this.number6.TabStop = false;
            this.number6.Text = "6";
            this.number6.UseVisualStyleBackColor = true;
            this.number6.Click += new System.EventHandler(this.number6_Click);
            // 
            // number5
            // 
            this.number5.Location = new System.Drawing.Point(92, 184);
            this.number5.Name = "number5";
            this.number5.Size = new System.Drawing.Size(64, 36);
            this.number5.TabIndex = 10;
            this.number5.TabStop = false;
            this.number5.Text = "5";
            this.number5.UseVisualStyleBackColor = true;
            this.number5.Click += new System.EventHandler(this.number5_Click);
            // 
            // number4
            // 
            this.number4.Location = new System.Drawing.Point(16, 184);
            this.number4.Name = "number4";
            this.number4.Size = new System.Drawing.Size(64, 36);
            this.number4.TabIndex = 9;
            this.number4.TabStop = false;
            this.number4.Text = "4";
            this.number4.UseVisualStyleBackColor = true;
            this.number4.Click += new System.EventHandler(this.number4_Click);
            // 
            // number3
            // 
            this.number3.Location = new System.Drawing.Point(168, 232);
            this.number3.Name = "number3";
            this.number3.Size = new System.Drawing.Size(64, 36);
            this.number3.TabIndex = 15;
            this.number3.TabStop = false;
            this.number3.Text = "3";
            this.number3.UseVisualStyleBackColor = true;
            this.number3.Click += new System.EventHandler(this.number3_Click);
            // 
            // number2
            // 
            this.number2.Location = new System.Drawing.Point(92, 232);
            this.number2.Name = "number2";
            this.number2.Size = new System.Drawing.Size(64, 36);
            this.number2.TabIndex = 14;
            this.number2.TabStop = false;
            this.number2.Text = "2";
            this.number2.UseVisualStyleBackColor = true;
            this.number2.Click += new System.EventHandler(this.number2_Click);
            // 
            // number1
            // 
            this.number1.Location = new System.Drawing.Point(16, 232);
            this.number1.Name = "number1";
            this.number1.Size = new System.Drawing.Size(64, 36);
            this.number1.TabIndex = 13;
            this.number1.TabStop = false;
            this.number1.Text = "1";
            this.number1.UseVisualStyleBackColor = true;
            this.number1.Click += new System.EventHandler(this.number1_Click);
            // 
            // point
            // 
            this.point.Location = new System.Drawing.Point(168, 280);
            this.point.Name = "point";
            this.point.Size = new System.Drawing.Size(64, 36);
            this.point.TabIndex = 18;
            this.point.TabStop = false;
            this.point.Text = ".";
            this.point.UseVisualStyleBackColor = true;
            this.point.Click += new System.EventHandler(this.point_Click);
            // 
            // number0
            // 
            this.number0.Location = new System.Drawing.Point(92, 280);
            this.number0.Name = "number0";
            this.number0.Size = new System.Drawing.Size(64, 36);
            this.number0.TabIndex = 17;
            this.number0.TabStop = false;
            this.number0.Text = "0";
            this.number0.UseVisualStyleBackColor = true;
            this.number0.Click += new System.EventHandler(this.number0_Click);
            // 
            // neg
            // 
            this.neg.Location = new System.Drawing.Point(16, 280);
            this.neg.Name = "neg";
            this.neg.Size = new System.Drawing.Size(64, 36);
            this.neg.TabIndex = 16;
            this.neg.TabStop = false;
            this.neg.Text = "-/+";
            this.neg.UseVisualStyleBackColor = true;
            this.neg.Click += new System.EventHandler(this.neg_Click);
            // 
            // equal
            // 
            this.equal.Location = new System.Drawing.Point(244, 232);
            this.equal.Name = "equal";
            this.equal.Size = new System.Drawing.Size(64, 84);
            this.equal.TabIndex = 19;
            this.equal.TabStop = false;
            this.equal.Text = "=";
            this.equal.UseVisualStyleBackColor = true;
            this.equal.Click += new System.EventHandler(this.equal_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.ClientSize = new System.Drawing.Size(324, 331);
            this.Controls.Add(this.equal);
            this.Controls.Add(this.point);
            this.Controls.Add(this.number0);
            this.Controls.Add(this.neg);
            this.Controls.Add(this.number3);
            this.Controls.Add(this.number2);
            this.Controls.Add(this.number1);
            this.Controls.Add(this.plus);
            this.Controls.Add(this.number6);
            this.Controls.Add(this.number5);
            this.Controls.Add(this.number4);
            this.Controls.Add(this.mul);
            this.Controls.Add(this.div);
            this.Controls.Add(this.del);
            this.Controls.Add(this.ac);
            this.Controls.Add(this.sub);
            this.Controls.Add(this.number9);
            this.Controls.Add(this.number8);
            this.Controls.Add(this.value);
            this.Controls.Add(this.number7);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "计算器";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button number7;
        private System.Windows.Forms.Label value;
        private System.Windows.Forms.Button number8;
        private System.Windows.Forms.Button number9;
        private System.Windows.Forms.Button sub;
        private System.Windows.Forms.Button mul;
        private System.Windows.Forms.Button div;
        private System.Windows.Forms.Button del;
        private System.Windows.Forms.Button ac;
        private System.Windows.Forms.Button plus;
        private System.Windows.Forms.Button number6;
        private System.Windows.Forms.Button number5;
        private System.Windows.Forms.Button number4;
        private System.Windows.Forms.Button number3;
        private System.Windows.Forms.Button number2;
        private System.Windows.Forms.Button number1;
        private System.Windows.Forms.Button point;
        private System.Windows.Forms.Button number0;
        private System.Windows.Forms.Button neg;
        private System.Windows.Forms.Button equal;
    }
}

