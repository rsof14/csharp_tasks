namespace WinFormsApp1
{
    partial class Calc
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
            null_button = new Button();
            dot_button = new Button();
            one_button = new Button();
            two_button = new Button();
            three_button = new Button();
            four_button = new Button();
            five_button = new Button();
            six_button = new Button();
            seven_button = new Button();
            eight_button = new Button();
            nine_button = new Button();
            eq_button = new Button();
            plus_button = new Button();
            minus_button = new Button();
            mult_button = new Button();
            div_button = new Button();
            clear_button = new Button();
            posneg_button = new Button();
            output_box = new RichTextBox();
            process_box = new RichTextBox();
            SuspendLayout();
            // 
            // null_button
            // 
            null_button.Font = new Font("Segoe UI", 19.875F, FontStyle.Bold, GraphicsUnit.Point);
            null_button.Location = new Point(30, 730);
            null_button.Name = "null_button";
            null_button.Size = new Size(260, 100);
            null_button.TabIndex = 0;
            null_button.Text = "0";
            null_button.UseVisualStyleBackColor = true;
            null_button.Click += button1_Click;
            // 
            // dot_button
            // 
            dot_button.Font = new Font("Segoe UI", 19.875F, FontStyle.Bold, GraphicsUnit.Point);
            dot_button.Location = new Point(310, 730);
            dot_button.Name = "dot_button";
            dot_button.Size = new Size(120, 100);
            dot_button.TabIndex = 1;
            dot_button.Text = ",";
            dot_button.UseVisualStyleBackColor = true;
            dot_button.Click += dot_button_Click;
            // 
            // one_button
            // 
            one_button.Font = new Font("Segoe UI", 19.875F, FontStyle.Bold, GraphicsUnit.Point);
            one_button.Location = new Point(30, 610);
            one_button.Name = "one_button";
            one_button.Size = new Size(120, 100);
            one_button.TabIndex = 2;
            one_button.Text = "1";
            one_button.UseVisualStyleBackColor = true;
            one_button.Click += button1_Click_1;
            // 
            // two_button
            // 
            two_button.Font = new Font("Segoe UI", 19.875F, FontStyle.Bold, GraphicsUnit.Point);
            two_button.Location = new Point(170, 610);
            two_button.Name = "two_button";
            two_button.Size = new Size(120, 100);
            two_button.TabIndex = 3;
            two_button.Text = "2";
            two_button.UseVisualStyleBackColor = true;
            two_button.Click += two_button_Click;
            // 
            // three_button
            // 
            three_button.Font = new Font("Segoe UI", 19.875F, FontStyle.Bold, GraphicsUnit.Point);
            three_button.Location = new Point(310, 610);
            three_button.Name = "three_button";
            three_button.Size = new Size(120, 100);
            three_button.TabIndex = 4;
            three_button.Text = "3";
            three_button.UseVisualStyleBackColor = true;
            three_button.Click += three_button_Click;
            // 
            // four_button
            // 
            four_button.Font = new Font("Segoe UI", 19.875F, FontStyle.Bold, GraphicsUnit.Point);
            four_button.Location = new Point(30, 490);
            four_button.Name = "four_button";
            four_button.Size = new Size(120, 100);
            four_button.TabIndex = 5;
            four_button.Text = "4";
            four_button.UseVisualStyleBackColor = true;
            four_button.Click += four_button_Click;
            // 
            // five_button
            // 
            five_button.Font = new Font("Segoe UI", 19.875F, FontStyle.Bold, GraphicsUnit.Point);
            five_button.Location = new Point(170, 490);
            five_button.Name = "five_button";
            five_button.RightToLeft = RightToLeft.No;
            five_button.Size = new Size(120, 100);
            five_button.TabIndex = 6;
            five_button.Text = "5";
            five_button.UseVisualStyleBackColor = true;
            five_button.Click += five_button_Click;
            // 
            // six_button
            // 
            six_button.Font = new Font("Segoe UI", 19.875F, FontStyle.Bold, GraphicsUnit.Point);
            six_button.Location = new Point(310, 490);
            six_button.Name = "six_button";
            six_button.RightToLeft = RightToLeft.No;
            six_button.Size = new Size(120, 100);
            six_button.TabIndex = 7;
            six_button.Text = "6";
            six_button.UseVisualStyleBackColor = true;
            six_button.Click += six_button_Click;
            // 
            // seven_button
            // 
            seven_button.Font = new Font("Segoe UI", 19.875F, FontStyle.Bold, GraphicsUnit.Point);
            seven_button.Location = new Point(30, 370);
            seven_button.Name = "seven_button";
            seven_button.RightToLeft = RightToLeft.No;
            seven_button.Size = new Size(120, 100);
            seven_button.TabIndex = 8;
            seven_button.Text = "7";
            seven_button.UseVisualStyleBackColor = true;
            seven_button.Click += seven_button_Click;
            // 
            // eight_button
            // 
            eight_button.Font = new Font("Segoe UI", 19.875F, FontStyle.Bold, GraphicsUnit.Point);
            eight_button.Location = new Point(170, 370);
            eight_button.Name = "eight_button";
            eight_button.RightToLeft = RightToLeft.No;
            eight_button.Size = new Size(120, 100);
            eight_button.TabIndex = 9;
            eight_button.Text = "8";
            eight_button.UseVisualStyleBackColor = true;
            eight_button.Click += eight_button_Click;
            // 
            // nine_button
            // 
            nine_button.Font = new Font("Segoe UI", 19.875F, FontStyle.Bold, GraphicsUnit.Point);
            nine_button.Location = new Point(310, 370);
            nine_button.Name = "nine_button";
            nine_button.RightToLeft = RightToLeft.No;
            nine_button.Size = new Size(120, 100);
            nine_button.TabIndex = 10;
            nine_button.Text = "9";
            nine_button.UseVisualStyleBackColor = true;
            nine_button.Click += nine_button_Click;
            // 
            // eq_button
            // 
            eq_button.Font = new Font("Segoe UI", 19.875F, FontStyle.Bold, GraphicsUnit.Point);
            eq_button.Location = new Point(450, 610);
            eq_button.Name = "eq_button";
            eq_button.Size = new Size(120, 220);
            eq_button.TabIndex = 11;
            eq_button.Text = "=";
            eq_button.UseVisualStyleBackColor = true;
            eq_button.Click += eq_button_Click;
            // 
            // plus_button
            // 
            plus_button.Font = new Font("Segoe UI", 19.875F, FontStyle.Bold, GraphicsUnit.Point);
            plus_button.Location = new Point(450, 490);
            plus_button.Name = "plus_button";
            plus_button.RightToLeft = RightToLeft.No;
            plus_button.Size = new Size(120, 100);
            plus_button.TabIndex = 12;
            plus_button.Text = "+";
            plus_button.UseVisualStyleBackColor = true;
            plus_button.Click += plus_button_Click;
            // 
            // minus_button
            // 
            minus_button.Font = new Font("Segoe UI", 19.875F, FontStyle.Bold, GraphicsUnit.Point);
            minus_button.Location = new Point(450, 370);
            minus_button.Name = "minus_button";
            minus_button.RightToLeft = RightToLeft.No;
            minus_button.Size = new Size(120, 100);
            minus_button.TabIndex = 13;
            minus_button.Text = "-";
            minus_button.UseVisualStyleBackColor = true;
            minus_button.Click += minus_button_Click;
            // 
            // mult_button
            // 
            mult_button.Font = new Font("Segoe UI", 19.875F, FontStyle.Bold, GraphicsUnit.Point);
            mult_button.Location = new Point(450, 250);
            mult_button.Name = "mult_button";
            mult_button.RightToLeft = RightToLeft.No;
            mult_button.Size = new Size(120, 100);
            mult_button.TabIndex = 14;
            mult_button.Text = "x";
            mult_button.UseVisualStyleBackColor = true;
            mult_button.Click += mult_button_Click;
            // 
            // div_button
            // 
            div_button.Font = new Font("Segoe UI", 19.875F, FontStyle.Bold, GraphicsUnit.Point);
            div_button.Location = new Point(310, 250);
            div_button.Name = "div_button";
            div_button.RightToLeft = RightToLeft.No;
            div_button.Size = new Size(120, 100);
            div_button.TabIndex = 15;
            div_button.Text = "/";
            div_button.UseVisualStyleBackColor = true;
            div_button.Click += div_button_Click;
            // 
            // clear_button
            // 
            clear_button.Font = new Font("Segoe UI", 19.875F, FontStyle.Bold, GraphicsUnit.Point);
            clear_button.Location = new Point(30, 250);
            clear_button.Name = "clear_button";
            clear_button.RightToLeft = RightToLeft.No;
            clear_button.Size = new Size(120, 100);
            clear_button.TabIndex = 16;
            clear_button.Text = "C";
            clear_button.UseVisualStyleBackColor = true;
            clear_button.Click += clear_button_Click;
            // 
            // posneg_button
            // 
            posneg_button.Font = new Font("Segoe UI", 19.875F, FontStyle.Bold, GraphicsUnit.Point);
            posneg_button.Location = new Point(170, 250);
            posneg_button.Name = "posneg_button";
            posneg_button.RightToLeft = RightToLeft.No;
            posneg_button.Size = new Size(120, 100);
            posneg_button.TabIndex = 17;
            posneg_button.Text = "+/-";
            posneg_button.UseVisualStyleBackColor = true;
            posneg_button.Click += posneg_button_Click;
            // 
            // output_box
            // 
            output_box.BorderStyle = BorderStyle.None;
            output_box.Cursor = Cursors.IBeam;
            output_box.Font = new Font("Segoe UI", 30F, FontStyle.Bold, GraphicsUnit.Point);
            output_box.Location = new Point(30, 93);
            output_box.Margin = new Padding(3, 0, 3, 3);
            output_box.Name = "output_box";
            output_box.ReadOnly = true;
            output_box.Size = new Size(540, 125);
            output_box.TabIndex = 18;
            output_box.TabStop = false;
            output_box.Text = "0";
            // 
            // process_box
            // 
            process_box.Anchor = AnchorStyles.Left;
            process_box.BorderStyle = BorderStyle.None;
            process_box.Cursor = Cursors.IBeam;
            process_box.Font = new Font("Segoe UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point);
            process_box.ForeColor = SystemColors.WindowFrame;
            process_box.Location = new Point(30, 44);
            process_box.Margin = new Padding(3, 3, 3, 0);
            process_box.Name = "process_box";
            process_box.ReadOnly = true;
            process_box.Size = new Size(540, 55);
            process_box.TabIndex = 19;
            process_box.TabStop = false;
            process_box.Text = "";
            // 
            // Calc
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(599, 861);
            Controls.Add(process_box);
            Controls.Add(output_box);
            Controls.Add(posneg_button);
            Controls.Add(clear_button);
            Controls.Add(div_button);
            Controls.Add(mult_button);
            Controls.Add(minus_button);
            Controls.Add(plus_button);
            Controls.Add(eq_button);
            Controls.Add(nine_button);
            Controls.Add(eight_button);
            Controls.Add(seven_button);
            Controls.Add(six_button);
            Controls.Add(five_button);
            Controls.Add(four_button);
            Controls.Add(three_button);
            Controls.Add(two_button);
            Controls.Add(one_button);
            Controls.Add(dot_button);
            Controls.Add(null_button);
            MaximumSize = new Size(625, 932);
            MinimumSize = new Size(625, 932);
            Name = "Calc";
            Text = "Калькулятор";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button null_button;
        private Button dot_button;
        private Button one_button;
        private Button two_button;
        private Button three_button;
        private Button four_button;
        private Button five_button;
        private Button six_button;
        private Button seven_button;
        private Button eight_button;
        private Button nine_button;
        private Button eq_button;
        private Button plus_button;
        private Button minus_button;
        private Button mult_button;
        private Button div_button;
        private Button clear_button;
        private Button posneg_button;
        private RichTextBox output_box;
        private RichTextBox process_box;
    }
}