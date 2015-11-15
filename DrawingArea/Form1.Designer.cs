namespace DrawingArea
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.penColorButton = new System.Windows.Forms.Button();
            this.backgroundColorButton = new System.Windows.Forms.Button();
            this.penSizeUpDown = new System.Windows.Forms.NumericUpDown();
            this.drawingBox = new System.Windows.Forms.PictureBox();
            this.clearButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.penSizeUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.drawingBox)).BeginInit();
            this.SuspendLayout();
            // 
            // penColorButton
            // 
            this.penColorButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.penColorButton.Location = new System.Drawing.Point(13, 227);
            this.penColorButton.Name = "penColorButton";
            this.penColorButton.Size = new System.Drawing.Size(37, 23);
            this.penColorButton.TabIndex = 1;
            this.penColorButton.Text = "Pen";
            this.penColorButton.UseVisualStyleBackColor = true;
            this.penColorButton.Click += new System.EventHandler(this.penColorButton_Click);
            // 
            // backgroundColorButton
            // 
            this.backgroundColorButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.backgroundColorButton.Location = new System.Drawing.Point(56, 227);
            this.backgroundColorButton.Name = "backgroundColorButton";
            this.backgroundColorButton.Size = new System.Drawing.Size(75, 23);
            this.backgroundColorButton.TabIndex = 2;
            this.backgroundColorButton.Text = "Background";
            this.backgroundColorButton.UseVisualStyleBackColor = true;
            this.backgroundColorButton.Click += new System.EventHandler(this.backgroundColorButton_Click);
            // 
            // penSizeUpDown
            // 
            this.penSizeUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.penSizeUpDown.Location = new System.Drawing.Point(323, 229);
            this.penSizeUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.penSizeUpDown.Name = "penSizeUpDown";
            this.penSizeUpDown.Size = new System.Drawing.Size(42, 20);
            this.penSizeUpDown.TabIndex = 3;
            this.penSizeUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.penSizeUpDown.ValueChanged += new System.EventHandler(this.penSizeUpDown_ValueChanged);
            // 
            // drawingBox
            // 
            this.drawingBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.drawingBox.Location = new System.Drawing.Point(13, 13);
            this.drawingBox.Name = "drawingBox";
            this.drawingBox.Size = new System.Drawing.Size(352, 208);
            this.drawingBox.TabIndex = 4;
            this.drawingBox.TabStop = false;
            this.drawingBox.Paint += new System.Windows.Forms.PaintEventHandler(this.drawingBox_Paint);
            this.drawingBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.drawingBox_MouseMove);
            // 
            // clearButton
            // 
            this.clearButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.clearButton.Location = new System.Drawing.Point(176, 227);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(53, 23);
            this.clearButton.TabIndex = 5;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(269, 232);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Pen Size";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 262);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.drawingBox);
            this.Controls.Add(this.penSizeUpDown);
            this.Controls.Add(this.backgroundColorButton);
            this.Controls.Add(this.penColorButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Drawing Area";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.penSizeUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.drawingBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button penColorButton;
        private System.Windows.Forms.Button backgroundColorButton;
        private System.Windows.Forms.NumericUpDown penSizeUpDown;
        private System.Windows.Forms.PictureBox drawingBox;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Label label1;
    }
}

