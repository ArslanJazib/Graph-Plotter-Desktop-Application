namespace VPAssignment6
{
    partial class GraphPlotter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GraphPlotter));
            this.generate_btn = new System.Windows.Forms.Button();
            this.Graph_pbox = new System.Windows.Forms.PictureBox();
            this.xMin = new System.Windows.Forms.TextBox();
            this.xMax = new System.Windows.Forms.TextBox();
            this.yMin = new System.Windows.Forms.TextBox();
            this.yMax = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.trigno_list = new System.Windows.Forms.CheckedListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.other_list = new System.Windows.Forms.CheckedListBox();
            this.range_gbox = new System.Windows.Forms.GroupBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.LineColor = new System.Windows.Forms.ToolStripButton();
            this.LineStyle = new System.Windows.Forms.ToolStripButton();
            this.Clear_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Graph_pbox)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.range_gbox.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // generate_btn
            // 
            this.generate_btn.BackColor = System.Drawing.Color.LightGreen;
            this.generate_btn.FlatAppearance.BorderSize = 0;
            this.generate_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.generate_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generate_btn.ForeColor = System.Drawing.Color.Black;
            this.generate_btn.Location = new System.Drawing.Point(797, 542);
            this.generate_btn.Name = "generate_btn";
            this.generate_btn.Size = new System.Drawing.Size(205, 86);
            this.generate_btn.TabIndex = 0;
            this.generate_btn.Text = "Generate Graph";
            this.generate_btn.UseVisualStyleBackColor = false;
            this.generate_btn.Click += new System.EventHandler(this.generate_btn_Click);
            // 
            // Graph_pbox
            // 
            this.Graph_pbox.BackColor = System.Drawing.Color.Silver;
            this.Graph_pbox.Location = new System.Drawing.Point(12, 48);
            this.Graph_pbox.Name = "Graph_pbox";
            this.Graph_pbox.Size = new System.Drawing.Size(1011, 462);
            this.Graph_pbox.TabIndex = 1;
            this.Graph_pbox.TabStop = false;
            this.Graph_pbox.Click += new System.EventHandler(this.Graph_pbox_Click);
            // 
            // xMin
            // 
            this.xMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xMin.ForeColor = System.Drawing.Color.DarkBlue;
            this.xMin.Location = new System.Drawing.Point(16, 66);
            this.xMin.Name = "xMin";
            this.xMin.Size = new System.Drawing.Size(95, 30);
            this.xMin.TabIndex = 2;
            this.xMin.Text = "X-MIN";
            // 
            // xMax
            // 
            this.xMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xMax.ForeColor = System.Drawing.Color.DarkBlue;
            this.xMax.Location = new System.Drawing.Point(136, 66);
            this.xMax.Name = "xMax";
            this.xMax.Size = new System.Drawing.Size(95, 30);
            this.xMax.TabIndex = 3;
            this.xMax.Text = "X-MAX";
            // 
            // yMin
            // 
            this.yMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yMin.ForeColor = System.Drawing.Color.ForestGreen;
            this.yMin.Location = new System.Drawing.Point(14, 133);
            this.yMin.Name = "yMin";
            this.yMin.Size = new System.Drawing.Size(97, 30);
            this.yMin.TabIndex = 4;
            this.yMin.Text = "Y-MIN";
            // 
            // yMax
            // 
            this.yMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yMax.ForeColor = System.Drawing.Color.ForestGreen;
            this.yMax.Location = new System.Drawing.Point(136, 133);
            this.yMax.Name = "yMax";
            this.yMax.Size = new System.Drawing.Size(95, 30);
            this.yMax.TabIndex = 5;
            this.yMax.Text = "Y-MAX";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.trigno_list);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 532);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(260, 199);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Trignometric Functions";
            // 
            // trigno_list
            // 
            this.trigno_list.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trigno_list.FormattingEnabled = true;
            this.trigno_list.Items.AddRange(new object[] {
            "sin(x)",
            "cos(x)",
            "tan(x)",
            "cosec(x)",
            "sec(x)",
            "cotan(x)",
            "arcsin(x)",
            "arccos(x)",
            "arctan(x)"});
            this.trigno_list.Location = new System.Drawing.Point(6, 56);
            this.trigno_list.Name = "trigno_list";
            this.trigno_list.Size = new System.Drawing.Size(245, 129);
            this.trigno_list.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.other_list);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(278, 532);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(246, 199);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Other Functions";
            // 
            // other_list
            // 
            this.other_list.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.other_list.FormattingEnabled = true;
            this.other_list.Items.AddRange(new object[] {
            "e^x",
            "log_2(x)",
            "log_10(x)",
            "x^2",
            "x^3"});
            this.other_list.Location = new System.Drawing.Point(6, 56);
            this.other_list.Name = "other_list";
            this.other_list.Size = new System.Drawing.Size(234, 129);
            this.other_list.TabIndex = 0;
            // 
            // range_gbox
            // 
            this.range_gbox.Controls.Add(this.xMin);
            this.range_gbox.Controls.Add(this.xMax);
            this.range_gbox.Controls.Add(this.yMin);
            this.range_gbox.Controls.Add(this.yMax);
            this.range_gbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.range_gbox.Location = new System.Drawing.Point(530, 532);
            this.range_gbox.Name = "range_gbox";
            this.range_gbox.Size = new System.Drawing.Size(243, 199);
            this.range_gbox.TabIndex = 8;
            this.range_gbox.TabStop = false;
            this.range_gbox.Text = "Range of the plot";
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LineColor,
            this.LineStyle});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1035, 32);
            this.toolStrip1.TabIndex = 9;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // LineColor
            // 
            this.LineColor.Image = ((System.Drawing.Image)(resources.GetObject("LineColor.Image")));
            this.LineColor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.LineColor.Name = "LineColor";
            this.LineColor.Size = new System.Drawing.Size(119, 29);
            this.LineColor.Text = "Line Color";
            this.LineColor.Click += new System.EventHandler(this.LineColor_Click);
            // 
            // LineStyle
            // 
            this.LineStyle.Image = ((System.Drawing.Image)(resources.GetObject("LineStyle.Image")));
            this.LineStyle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.LineStyle.Name = "LineStyle";
            this.LineStyle.Size = new System.Drawing.Size(113, 29);
            this.LineStyle.Text = "Line Style";
            this.LineStyle.Click += new System.EventHandler(this.LineStyle_Click);
            // 
            // Clear_button
            // 
            this.Clear_button.BackColor = System.Drawing.Color.IndianRed;
            this.Clear_button.FlatAppearance.BorderSize = 0;
            this.Clear_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Clear_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clear_button.ForeColor = System.Drawing.Color.Black;
            this.Clear_button.Location = new System.Drawing.Point(797, 645);
            this.Clear_button.Name = "Clear_button";
            this.Clear_button.Size = new System.Drawing.Size(205, 86);
            this.Clear_button.TabIndex = 10;
            this.Clear_button.Text = "Clear Graph";
            this.Clear_button.UseVisualStyleBackColor = false;
            this.Clear_button.Click += new System.EventHandler(this.Clear_button_Click);
            // 
            // GraphPlotter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1035, 743);
            this.Controls.Add(this.Clear_button);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.range_gbox);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Graph_pbox);
            this.Controls.Add(this.generate_btn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1057, 799);
            this.MinimumSize = new System.Drawing.Size(1057, 799);
            this.Name = "GraphPlotter";
            this.Text = "Plotter";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.GraphPlotter_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Graph_pbox)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.range_gbox.ResumeLayout(false);
            this.range_gbox.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button generate_btn;
        private System.Windows.Forms.PictureBox Graph_pbox;
        private System.Windows.Forms.TextBox xMin;
        private System.Windows.Forms.TextBox xMax;
        private System.Windows.Forms.TextBox yMin;
        private System.Windows.Forms.TextBox yMax;
        private System.Windows.Forms.GroupBox range_gbox;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton LineColor;
        private System.Windows.Forms.ToolStripButton LineStyle;
        private System.Windows.Forms.Button Clear_button;
        public System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.CheckedListBox trigno_list;
        public System.Windows.Forms.CheckedListBox other_list;
    }
}

