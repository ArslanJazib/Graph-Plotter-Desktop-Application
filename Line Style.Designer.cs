namespace VPAssignment6
{
    partial class Line_Style
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Line_Style));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.other_list = new System.Windows.Forms.CheckedListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.trigno_list = new System.Windows.Forms.CheckedListBox();
            this.apply_btn = new System.Windows.Forms.Button();
            this.solidPbox = new System.Windows.Forms.PictureBox();
            this.dashPbox = new System.Windows.Forms.PictureBox();
            this.dotPbox = new System.Windows.Forms.PictureBox();
            this.solidLine = new System.Windows.Forms.RadioButton();
            this.dashedLine = new System.Windows.Forms.RadioButton();
            this.dotLine = new System.Windows.Forms.RadioButton();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.solidPbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dashPbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dotPbox)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.other_list);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(488, 264);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(260, 199);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Other Functions";
            // 
            // other_list
            // 
            this.other_list.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.other_list.FormattingEnabled = true;
            this.other_list.Location = new System.Drawing.Point(6, 56);
            this.other_list.Name = "other_list";
            this.other_list.Size = new System.Drawing.Size(245, 129);
            this.other_list.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.trigno_list);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(488, 59);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(260, 199);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Trignometric Functions";
            // 
            // trigno_list
            // 
            this.trigno_list.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trigno_list.FormattingEnabled = true;
            this.trigno_list.Location = new System.Drawing.Point(6, 56);
            this.trigno_list.Name = "trigno_list";
            this.trigno_list.Size = new System.Drawing.Size(245, 129);
            this.trigno_list.TabIndex = 1;
            // 
            // apply_btn
            // 
            this.apply_btn.BackColor = System.Drawing.SystemColors.Highlight;
            this.apply_btn.FlatAppearance.BorderSize = 0;
            this.apply_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.apply_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apply_btn.Location = new System.Drawing.Point(241, 511);
            this.apply_btn.Name = "apply_btn";
            this.apply_btn.Size = new System.Drawing.Size(260, 72);
            this.apply_btn.TabIndex = 10;
            this.apply_btn.Text = "Apply";
            this.apply_btn.UseVisualStyleBackColor = false;
            this.apply_btn.Click += new System.EventHandler(this.apply_btn_Click);
            // 
            // solidPbox
            // 
            this.solidPbox.Image = ((System.Drawing.Image)(resources.GetObject("solidPbox.Image")));
            this.solidPbox.Location = new System.Drawing.Point(189, 120);
            this.solidPbox.Name = "solidPbox";
            this.solidPbox.Size = new System.Drawing.Size(146, 14);
            this.solidPbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.solidPbox.TabIndex = 13;
            this.solidPbox.TabStop = false;
            // 
            // dashPbox
            // 
            this.dashPbox.Image = ((System.Drawing.Image)(resources.GetObject("dashPbox.Image")));
            this.dashPbox.Location = new System.Drawing.Point(189, 244);
            this.dashPbox.Name = "dashPbox";
            this.dashPbox.Size = new System.Drawing.Size(146, 14);
            this.dashPbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dashPbox.TabIndex = 14;
            this.dashPbox.TabStop = false;
            // 
            // dotPbox
            // 
            this.dotPbox.Image = ((System.Drawing.Image)(resources.GetObject("dotPbox.Image")));
            this.dotPbox.Location = new System.Drawing.Point(189, 370);
            this.dotPbox.Name = "dotPbox";
            this.dotPbox.Size = new System.Drawing.Size(146, 15);
            this.dotPbox.TabIndex = 15;
            this.dotPbox.TabStop = false;
            // 
            // solidLine
            // 
            this.solidLine.AutoSize = true;
            this.solidLine.Location = new System.Drawing.Point(29, 110);
            this.solidLine.Name = "solidLine";
            this.solidLine.Size = new System.Drawing.Size(69, 24);
            this.solidLine.TabIndex = 16;
            this.solidLine.TabStop = true;
            this.solidLine.Text = "Solid";
            this.solidLine.UseVisualStyleBackColor = true;
            // 
            // dashedLine
            // 
            this.dashedLine.AutoSize = true;
            this.dashedLine.Location = new System.Drawing.Point(29, 234);
            this.dashedLine.Name = "dashedLine";
            this.dashedLine.Size = new System.Drawing.Size(90, 24);
            this.dashedLine.TabIndex = 17;
            this.dashedLine.TabStop = true;
            this.dashedLine.Text = "Dashed";
            this.dashedLine.UseVisualStyleBackColor = true;
            // 
            // dotLine
            // 
            this.dotLine.AutoSize = true;
            this.dotLine.Location = new System.Drawing.Point(29, 361);
            this.dotLine.Name = "dotLine";
            this.dotLine.Size = new System.Drawing.Size(60, 24);
            this.dotLine.TabIndex = 18;
            this.dotLine.TabStop = true;
            this.dotLine.Text = "Dot";
            this.dotLine.UseVisualStyleBackColor = true;
            // 
            // Line_Style
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 595);
            this.Controls.Add(this.dotLine);
            this.Controls.Add(this.dashedLine);
            this.Controls.Add(this.solidLine);
            this.Controls.Add(this.dotPbox);
            this.Controls.Add(this.dashPbox);
            this.Controls.Add(this.solidPbox);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.apply_btn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Line_Style";
            this.Text = "Line Style";
            this.Load += new System.EventHandler(this.Line_Style_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.solidPbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dashPbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dotPbox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckedListBox other_list;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckedListBox trigno_list;
        private System.Windows.Forms.Button apply_btn;
        private System.Windows.Forms.PictureBox solidPbox;
        private System.Windows.Forms.PictureBox dashPbox;
        private System.Windows.Forms.PictureBox dotPbox;
        private System.Windows.Forms.RadioButton solidLine;
        private System.Windows.Forms.RadioButton dashedLine;
        private System.Windows.Forms.RadioButton dotLine;
    }
}