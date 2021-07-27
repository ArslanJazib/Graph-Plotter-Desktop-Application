namespace VPAssignment6
{
    partial class Line_Color
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Line_Color));
            this.apply_btn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.other_list = new System.Windows.Forms.CheckedListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.trigno_list = new System.Windows.Forms.CheckedListBox();
            this.coloMixer = new VPAssignment6.ColorMixer();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // apply_btn
            // 
            this.apply_btn.BackColor = System.Drawing.SystemColors.Highlight;
            this.apply_btn.FlatAppearance.BorderSize = 0;
            this.apply_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.apply_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apply_btn.Location = new System.Drawing.Point(601, 422);
            this.apply_btn.Name = "apply_btn";
            this.apply_btn.Size = new System.Drawing.Size(260, 72);
            this.apply_btn.TabIndex = 1;
            this.apply_btn.Text = "Apply";
            this.apply_btn.UseVisualStyleBackColor = false;
            this.apply_btn.Click += new System.EventHandler(this.apply_btn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.other_list);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(601, 217);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(260, 199);
            this.groupBox2.TabIndex = 9;
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
            this.groupBox1.Location = new System.Drawing.Point(601, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(260, 199);
            this.groupBox1.TabIndex = 8;
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
            this.trigno_list.SelectedIndexChanged += new System.EventHandler(this.trigno_list_SelectedIndexChanged);
            // 
            // coloMixer
            // 
            this.coloMixer.Location = new System.Drawing.Point(12, 12);
            this.coloMixer.Name = "coloMixer";
            this.coloMixer.Size = new System.Drawing.Size(589, 601);
            this.coloMixer.TabIndex = 0;
            this.coloMixer.Load += new System.EventHandler(this.coloMixer_Load);
            // 
            // Line_Color
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 625);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.apply_btn);
            this.Controls.Add(this.coloMixer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Line_Color";
            this.Text = "Line Color";
            this.Load += new System.EventHandler(this.Line_Color_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ColorMixer coloMixer;
        private System.Windows.Forms.Button apply_btn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckedListBox other_list;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckedListBox trigno_list;
    }
}