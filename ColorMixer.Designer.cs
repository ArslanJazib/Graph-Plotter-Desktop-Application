namespace VPAssignment6
{
    partial class ColorMixer
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.blueColor = new System.Windows.Forms.Label();
            this.greenColor = new System.Windows.Forms.Label();
            this.redColor = new System.Windows.Forms.Label();
            this.colorDisplay = new System.Windows.Forms.Panel();
            this.greenTrackBar = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.blueTrackBar = new System.Windows.Forms.TrackBar();
            this.Blue = new System.Windows.Forms.Label();
            this.redTrackBar = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.greenTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blueTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.redTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // blueColor
            // 
            this.blueColor.AutoSize = true;
            this.blueColor.Location = new System.Drawing.Point(508, 233);
            this.blueColor.Name = "blueColor";
            this.blueColor.Size = new System.Drawing.Size(0, 20);
            this.blueColor.TabIndex = 19;
            // 
            // greenColor
            // 
            this.greenColor.AutoSize = true;
            this.greenColor.Location = new System.Drawing.Point(508, 139);
            this.greenColor.Name = "greenColor";
            this.greenColor.Size = new System.Drawing.Size(0, 20);
            this.greenColor.TabIndex = 18;
            // 
            // redColor
            // 
            this.redColor.AutoSize = true;
            this.redColor.Location = new System.Drawing.Point(508, 46);
            this.redColor.Name = "redColor";
            this.redColor.Size = new System.Drawing.Size(0, 20);
            this.redColor.TabIndex = 17;
            // 
            // colorDisplay
            // 
            this.colorDisplay.Location = new System.Drawing.Point(27, 337);
            this.colorDisplay.Name = "colorDisplay";
            this.colorDisplay.Size = new System.Drawing.Size(542, 200);
            this.colorDisplay.TabIndex = 16;
            // 
            // greenTrackBar
            // 
            this.greenTrackBar.Location = new System.Drawing.Point(19, 139);
            this.greenTrackBar.Maximum = 255;
            this.greenTrackBar.Name = "greenTrackBar";
            this.greenTrackBar.Size = new System.Drawing.Size(457, 69);
            this.greenTrackBar.TabIndex = 15;
            this.greenTrackBar.TickFrequency = 5;
            this.greenTrackBar.Scroll += new System.EventHandler(this.redTrackBar_Scroll);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "Green";
            // 
            // blueTrackBar
            // 
            this.blueTrackBar.Location = new System.Drawing.Point(19, 233);
            this.blueTrackBar.Maximum = 255;
            this.blueTrackBar.Name = "blueTrackBar";
            this.blueTrackBar.Size = new System.Drawing.Size(457, 69);
            this.blueTrackBar.TabIndex = 13;
            this.blueTrackBar.TickFrequency = 5;
            this.blueTrackBar.Scroll += new System.EventHandler(this.redTrackBar_Scroll);
            // 
            // Blue
            // 
            this.Blue.AutoSize = true;
            this.Blue.Location = new System.Drawing.Point(23, 210);
            this.Blue.Name = "Blue";
            this.Blue.Size = new System.Drawing.Size(41, 20);
            this.Blue.TabIndex = 12;
            this.Blue.Text = "Blue";
            // 
            // redTrackBar
            // 
            this.redTrackBar.Location = new System.Drawing.Point(23, 46);
            this.redTrackBar.Maximum = 255;
            this.redTrackBar.Name = "redTrackBar";
            this.redTrackBar.Size = new System.Drawing.Size(457, 69);
            this.redTrackBar.TabIndex = 11;
            this.redTrackBar.TickFrequency = 5;
            this.redTrackBar.Scroll += new System.EventHandler(this.redTrackBar_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Red";
            // 
            // ColoMixer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.blueColor);
            this.Controls.Add(this.greenColor);
            this.Controls.Add(this.redColor);
            this.Controls.Add(this.colorDisplay);
            this.Controls.Add(this.greenTrackBar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.blueTrackBar);
            this.Controls.Add(this.Blue);
            this.Controls.Add(this.redTrackBar);
            this.Controls.Add(this.label1);
            this.Name = "ColoMixer";
            this.Size = new System.Drawing.Size(661, 593);
            this.Load += new System.EventHandler(this.ColoMixer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.greenTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blueTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.redTrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label blueColor;
        private System.Windows.Forms.Label greenColor;
        private System.Windows.Forms.Label redColor;
        private System.Windows.Forms.Panel colorDisplay;
        private System.Windows.Forms.TrackBar greenTrackBar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TrackBar blueTrackBar;
        private System.Windows.Forms.Label Blue;
        private System.Windows.Forms.TrackBar redTrackBar;
        private System.Windows.Forms.Label label1;
    }
}
