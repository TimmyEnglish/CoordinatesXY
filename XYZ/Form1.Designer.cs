namespace CoordinatesXY
{
    partial class Form1
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
            xTextBox = new TextBox();
            yTextBox = new TextBox();
            CalculateButton = new Button();
            pictureBox1 = new PictureBox();
            scaleTrackBar = new TrackBar();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)scaleTrackBar).BeginInit();
            SuspendLayout();
            // 
            // xTextBox
            // 
            xTextBox.ForeColor = Color.Silver;
            xTextBox.Location = new System.Drawing.Point(35, 43);
            xTextBox.Name = "xTextBox";
            xTextBox.Size = new Size(175, 35);
            xTextBox.TabIndex = 0;
            xTextBox.Text = "Координата X";
            xTextBox.Enter += xTextBox_Enter;
            xTextBox.Leave += xTextBox_Leave;
            // 
            // yTextBox
            // 
            yTextBox.ForeColor = Color.Silver;
            yTextBox.Location = new System.Drawing.Point(35, 124);
            yTextBox.Name = "yTextBox";
            yTextBox.Size = new Size(175, 35);
            yTextBox.TabIndex = 1;
            yTextBox.Text = "Координата Y";
            yTextBox.Enter += yTextBox_Enter;
            yTextBox.Leave += yTextBox_Leave;
            // 
            // CalculateButton
            // 
            CalculateButton.BackColor = Color.PaleGreen;
            CalculateButton.FlatAppearance.BorderColor = Color.Black;
            CalculateButton.FlatStyle = FlatStyle.Flat;
            CalculateButton.Location = new System.Drawing.Point(35, 208);
            CalculateButton.Name = "CalculateButton";
            CalculateButton.Size = new Size(175, 40);
            CalculateButton.TabIndex = 17;
            CalculateButton.Text = "Обчислити";
            CalculateButton.UseVisualStyleBackColor = false;
            CalculateButton.Click += CalculateButton_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new System.Drawing.Point(339, 43);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(434, 316);
            pictureBox1.TabIndex = 18;
            pictureBox1.TabStop = false;
            // 
            // scaleTrackBar
            // 
            scaleTrackBar.Location = new System.Drawing.Point(35, 292);
            scaleTrackBar.Maximum = 20;
            scaleTrackBar.Minimum = 7;
            scaleTrackBar.Name = "scaleTrackBar";
            scaleTrackBar.Size = new Size(175, 80);
            scaleTrackBar.TabIndex = 19;
            scaleTrackBar.Value = 7;
            scaleTrackBar.ValueChanged += scaleTrackBar_ValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(69, 342);
            label1.Name = "label1";
            label1.Size = new Size(102, 30);
            label1.TabIndex = 20;
            label1.Text = "Масштаб";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(scaleTrackBar);
            Controls.Add(pictureBox1);
            Controls.Add(CalculateButton);
            Controls.Add(yTextBox);
            Controls.Add(xTextBox);
            Name = "Form1";
            Text = "CoordinatesXY";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)scaleTrackBar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox xTextBox;
        private TextBox yTextBox;
        private Button CalculateButton;
        private PictureBox pictureBox1;
        private TrackBar scaleTrackBar;
        private Label label1;
    }
}
