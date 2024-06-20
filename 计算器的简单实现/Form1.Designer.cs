namespace 计算器的简单实现
{
    partial class 简易计算器
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(简易计算器));
            button1 = new Button();
            Clear = new Button();
            dividedBy = new Button();
            times = new Button();
            minus = new Button();
            add = new Button();
            Expression = new TextBox();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button10 = new Button();
            button11 = new Button();
            button12 = new Button();
            button13 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(28, 311);
            button1.Name = "button1";
            button1.Size = new Size(132, 133);
            button1.TabIndex = 0;
            button1.Text = "1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Clear
            // 
            Clear.Location = new Point(28, 182);
            Clear.Name = "Clear";
            Clear.Size = new Size(271, 123);
            Clear.TabIndex = 9;
            Clear.Text = "清空";
            Clear.UseVisualStyleBackColor = true;
            Clear.Click += button10_Click;
            // 
            // dividedBy
            // 
            dividedBy.Location = new Point(455, 744);
            dividedBy.Name = "dividedBy";
            dividedBy.Size = new Size(141, 133);
            dividedBy.TabIndex = 20;
            dividedBy.Text = "/";
            dividedBy.UseVisualStyleBackColor = true;
            dividedBy.Click += dividedBy_Click;
            // 
            // times
            // 
            times.Location = new Point(455, 605);
            times.Name = "times";
            times.Size = new Size(141, 129);
            times.TabIndex = 21;
            times.Text = "*";
            times.UseVisualStyleBackColor = true;
            times.Click += button13_Click;
            // 
            // minus
            // 
            minus.Location = new Point(457, 457);
            minus.Name = "minus";
            minus.Size = new Size(141, 123);
            minus.TabIndex = 22;
            minus.Text = "-";
            minus.UseVisualStyleBackColor = true;
            minus.Click += button15_Click_1;
            // 
            // add
            // 
            add.Location = new Point(455, 316);
            add.Name = "add";
            add.Size = new Size(141, 123);
            add.TabIndex = 23;
            add.Text = "+";
            add.UseVisualStyleBackColor = true;
            add.Click += add_Click;
            // 
            // Expression
            // 
            Expression.Location = new Point(28, 23);
            Expression.Multiline = true;
            Expression.Name = "Expression";
            Expression.Size = new Size(568, 142);
            Expression.TabIndex = 25;
            // 
            // button2
            // 
            button2.Location = new Point(167, 311);
            button2.Name = "button2";
            button2.Size = new Size(132, 133);
            button2.TabIndex = 27;
            button2.Text = "2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click_1;
            // 
            // button3
            // 
            button3.Location = new Point(305, 311);
            button3.Name = "button3";
            button3.Size = new Size(132, 133);
            button3.TabIndex = 28;
            button3.Text = "3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click_1;
            // 
            // button4
            // 
            button4.Location = new Point(28, 457);
            button4.Name = "button4";
            button4.Size = new Size(132, 133);
            button4.TabIndex = 29;
            button4.Text = "4";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(167, 455);
            button5.Name = "button5";
            button5.Size = new Size(132, 133);
            button5.TabIndex = 30;
            button5.Text = "5";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click_2;
            // 
            // button6
            // 
            button6.Location = new Point(305, 459);
            button6.Name = "button6";
            button6.Size = new Size(132, 133);
            button6.TabIndex = 31;
            button6.Text = "6";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Location = new Point(28, 605);
            button7.Name = "button7";
            button7.Size = new Size(132, 133);
            button7.TabIndex = 32;
            button7.Text = "7";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click_1;
            // 
            // button8
            // 
            button8.Location = new Point(167, 605);
            button8.Name = "button8";
            button8.Size = new Size(132, 133);
            button8.TabIndex = 33;
            button8.Text = "8";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click_1;
            // 
            // button9
            // 
            button9.Location = new Point(305, 605);
            button9.Name = "button9";
            button9.Size = new Size(132, 133);
            button9.TabIndex = 34;
            button9.Text = "9";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click_2;
            // 
            // button10
            // 
            button10.Location = new Point(28, 744);
            button10.Name = "button10";
            button10.Size = new Size(132, 133);
            button10.TabIndex = 35;
            button10.Text = "0";
            button10.UseVisualStyleBackColor = true;
            button10.Click += button10_Click_2;
            // 
            // button11
            // 
            button11.Location = new Point(167, 744);
            button11.Name = "button11";
            button11.Size = new Size(132, 133);
            button11.TabIndex = 36;
            button11.Text = ".";
            button11.UseVisualStyleBackColor = true;
            button11.Click += button11_Click_1;
            // 
            // button12
            // 
            button12.Location = new Point(305, 744);
            button12.Name = "button12";
            button12.Size = new Size(132, 133);
            button12.TabIndex = 37;
            button12.Text = "=";
            button12.UseVisualStyleBackColor = true;
            button12.Click += button12_Click;
            // 
            // button13
            // 
            button13.Location = new Point(305, 182);
            button13.Name = "button13";
            button13.Size = new Size(291, 123);
            button13.TabIndex = 38;
            button13.Text = "取余数";
            button13.UseVisualStyleBackColor = true;
            button13.Click += button13_Click_1;
            // 
            // 简易计算器
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(610, 898);
            Controls.Add(button13);
            Controls.Add(button12);
            Controls.Add(button11);
            Controls.Add(button10);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(Expression);
            Controls.Add(add);
            Controls.Add(minus);
            Controls.Add(times);
            Controls.Add(dividedBy);
            Controls.Add(Clear);
            Controls.Add(button1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "简易计算器";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "简易计算器";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button Clear;
        private Button dividedBy;
        private Button times;
        private Button minus;
        private Button add;
        private TextBox Expression;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button10;
        private Button button11;
        private Button button12;
        private Button button13;
    }
}
