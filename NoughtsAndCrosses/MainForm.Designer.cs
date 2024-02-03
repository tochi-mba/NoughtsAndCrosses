namespace NoughtsAndCrosses
{
    partial class MainForm
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
            cell1 = new Button();
            cell4 = new Button();
            cell7 = new Button();
            cell8 = new Button();
            cell5 = new Button();
            cell2 = new Button();
            cell9 = new Button();
            cell6 = new Button();
            cell3 = new Button();
            SuspendLayout();
            // 
            // cell1
            // 
            cell1.Location = new Point(240, 76);
            cell1.Margin = new Padding(7);
            cell1.Name = "cell1";
            cell1.Size = new Size(115, 115);
            cell1.TabIndex = 0;
            cell1.UseVisualStyleBackColor = true;
            cell1.Click += cell1_Click;
            // 
            // cell4
            // 
            cell4.Location = new Point(240, 192);
            cell4.Margin = new Padding(7);
            cell4.Name = "cell4";
            cell4.Size = new Size(115, 115);
            cell4.TabIndex = 3;
            cell4.UseVisualStyleBackColor = true;
            cell4.Click += cell4_Click;
            // 
            // cell7
            // 
            cell7.Location = new Point(240, 309);
            cell7.Margin = new Padding(7);
            cell7.Name = "cell7";
            cell7.Size = new Size(115, 115);
            cell7.TabIndex = 6;
            cell7.UseVisualStyleBackColor = true;
            cell7.Click += cell7_Click;
            // 
            // cell8
            // 
            cell8.Location = new Point(358, 309);
            cell8.Margin = new Padding(7);
            cell8.Name = "cell8";
            cell8.Size = new Size(115, 115);
            cell8.TabIndex = 9;
            cell8.UseVisualStyleBackColor = true;
            cell8.Click += cell8_Click;
            // 
            // cell5
            // 
            cell5.Location = new Point(358, 192);
            cell5.Margin = new Padding(7);
            cell5.Name = "cell5";
            cell5.Size = new Size(115, 115);
            cell5.TabIndex = 8;
            cell5.UseVisualStyleBackColor = true;
            cell5.Click += cell5_Click;
            // 
            // cell2
            // 
            cell2.Location = new Point(358, 76);
            cell2.Margin = new Padding(7);
            cell2.Name = "cell2";
            cell2.Size = new Size(115, 115);
            cell2.TabIndex = 7;
            cell2.UseVisualStyleBackColor = true;
            cell2.Click += cell2_Click;
            // 
            // cell9
            // 
            cell9.Location = new Point(477, 309);
            cell9.Margin = new Padding(7);
            cell9.Name = "cell9";
            cell9.Size = new Size(115, 115);
            cell9.TabIndex = 12;
            cell9.UseVisualStyleBackColor = true;
            cell9.Click += cell9_Click;
            // 
            // cell6
            // 
            cell6.Location = new Point(477, 192);
            cell6.Margin = new Padding(7);
            cell6.Name = "cell6";
            cell6.Size = new Size(115, 115);
            cell6.TabIndex = 11;
            cell6.UseVisualStyleBackColor = true;
            cell6.Click += cell6_Click;
            // 
            // cell3
            // 
            cell3.Location = new Point(477, 76);
            cell3.Margin = new Padding(7);
            cell3.Name = "cell3";
            cell3.Size = new Size(115, 115);
            cell3.TabIndex = 10;
            cell3.UseVisualStyleBackColor = true;
            cell3.Click += cell3_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(18F, 45F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(830, 499);
            Controls.Add(cell9);
            Controls.Add(cell6);
            Controls.Add(cell3);
            Controls.Add(cell8);
            Controls.Add(cell5);
            Controls.Add(cell2);
            Controls.Add(cell7);
            Controls.Add(cell4);
            Controls.Add(cell1);
            Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(7);
            Name = "MainForm";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button cell1;
        private Button cell4;
        private Button cell7;
        private Button cell8;
        private Button cell5;
        private Button cell2;
        private Button cell9;
        private Button cell6;
        private Button cell3;
    }
}
