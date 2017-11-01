namespace SecretaryProblem.UI
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
            this.plotView1 = new OxyPlot.WindowsForms.PlotView();
            this.rbThreshold = new System.Windows.Forms.RadioButton();
            this.rbTolerance = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nudFixedParameter = new System.Windows.Forms.NumericUpDown();
            this.lblFixedParameter = new System.Windows.Forms.Label();
            this.lblMinVariableParameter = new System.Windows.Forms.Label();
            this.nudMinVariableParameter = new System.Windows.Forms.NumericUpDown();
            this.lblMaxVariableParameter = new System.Windows.Forms.Label();
            this.nudMaxVariableParameter = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.nudNbOfExperiments = new System.Windows.Forms.NumericUpDown();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudFixedParameter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinVariableParameter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxVariableParameter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNbOfExperiments)).BeginInit();
            this.SuspendLayout();
            // 
            // plotView1
            // 
            this.plotView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.plotView1.Location = new System.Drawing.Point(0, 0);
            this.plotView1.Name = "plotView1";
            this.plotView1.PanCursor = System.Windows.Forms.Cursors.Hand;
            this.plotView1.Size = new System.Drawing.Size(1040, 496);
            this.plotView1.TabIndex = 1;
            this.plotView1.Text = "plot1";
            this.plotView1.ZoomHorizontalCursor = System.Windows.Forms.Cursors.SizeWE;
            this.plotView1.ZoomRectangleCursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.plotView1.ZoomVerticalCursor = System.Windows.Forms.Cursors.SizeNS;
            // 
            // rbThreshold
            // 
            this.rbThreshold.AutoSize = true;
            this.rbThreshold.Location = new System.Drawing.Point(6, 55);
            this.rbThreshold.Name = "rbThreshold";
            this.rbThreshold.Size = new System.Drawing.Size(100, 24);
            this.rbThreshold.TabIndex = 2;
            this.rbThreshold.Text = "threshold";
            this.rbThreshold.UseVisualStyleBackColor = true;
            this.rbThreshold.CheckedChanged += new System.EventHandler(this.ToggleVariableParameter);
            // 
            // rbTolerance
            // 
            this.rbTolerance.AutoSize = true;
            this.rbTolerance.Checked = true;
            this.rbTolerance.Location = new System.Drawing.Point(6, 25);
            this.rbTolerance.Name = "rbTolerance";
            this.rbTolerance.Size = new System.Drawing.Size(100, 24);
            this.rbTolerance.TabIndex = 3;
            this.rbTolerance.TabStop = true;
            this.rbTolerance.Text = "tolerance";
            this.rbTolerance.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbThreshold);
            this.groupBox1.Controls.Add(this.rbTolerance);
            this.groupBox1.Location = new System.Drawing.Point(12, 515);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(166, 97);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Parameter to vary";
            // 
            // nudFixedParameter
            // 
            this.nudFixedParameter.Location = new System.Drawing.Point(448, 521);
            this.nudFixedParameter.Name = "nudFixedParameter";
            this.nudFixedParameter.Size = new System.Drawing.Size(63, 26);
            this.nudFixedParameter.TabIndex = 5;
            this.nudFixedParameter.Value = new decimal(new int[] {
            37,
            0,
            0,
            0});
            // 
            // lblFixedParameter
            // 
            this.lblFixedParameter.AutoSize = true;
            this.lblFixedParameter.Location = new System.Drawing.Point(222, 523);
            this.lblFixedParameter.Name = "lblFixedParameter";
            this.lblFixedParameter.Size = new System.Drawing.Size(165, 20);
            this.lblFixedParameter.TabIndex = 6;
            this.lblFixedParameter.Text = "Fixed parameter value";
            // 
            // lblMinVariableParameter
            // 
            this.lblMinVariableParameter.AutoSize = true;
            this.lblMinVariableParameter.Location = new System.Drawing.Point(222, 554);
            this.lblMinVariableParameter.Name = "lblMinVariableParameter";
            this.lblMinVariableParameter.Size = new System.Drawing.Size(214, 20);
            this.lblMinVariableParameter.TabIndex = 8;
            this.lblMinVariableParameter.Text = "Variable parameter min value";
            // 
            // nudMinVariableParameter
            // 
            this.nudMinVariableParameter.Location = new System.Drawing.Point(448, 552);
            this.nudMinVariableParameter.Name = "nudMinVariableParameter";
            this.nudMinVariableParameter.Size = new System.Drawing.Size(63, 26);
            this.nudMinVariableParameter.TabIndex = 7;
            // 
            // lblMaxVariableParameter
            // 
            this.lblMaxVariableParameter.AutoSize = true;
            this.lblMaxVariableParameter.Location = new System.Drawing.Point(222, 585);
            this.lblMaxVariableParameter.Name = "lblMaxVariableParameter";
            this.lblMaxVariableParameter.Size = new System.Drawing.Size(218, 20);
            this.lblMaxVariableParameter.TabIndex = 10;
            this.lblMaxVariableParameter.Text = "Variable parameter max value";
            // 
            // nudMaxVariableParameter
            // 
            this.nudMaxVariableParameter.Location = new System.Drawing.Point(448, 583);
            this.nudMaxVariableParameter.Name = "nudMaxVariableParameter";
            this.nudMaxVariableParameter.Size = new System.Drawing.Size(63, 26);
            this.nudMaxVariableParameter.TabIndex = 9;
            this.nudMaxVariableParameter.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(914, 570);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 41);
            this.button1.TabIndex = 11;
            this.button1.Text = "Calculate!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(552, 523);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(173, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Number of experiments";
            // 
            // nudNbOfExperiments
            // 
            this.nudNbOfExperiments.Location = new System.Drawing.Point(731, 521);
            this.nudNbOfExperiments.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudNbOfExperiments.Name = "nudNbOfExperiments";
            this.nudNbOfExperiments.Size = new System.Drawing.Size(99, 26);
            this.nudNbOfExperiments.TabIndex = 12;
            this.nudNbOfExperiments.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 624);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nudNbOfExperiments);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblMaxVariableParameter);
            this.Controls.Add(this.nudMaxVariableParameter);
            this.Controls.Add(this.lblMinVariableParameter);
            this.Controls.Add(this.nudMinVariableParameter);
            this.Controls.Add(this.lblFixedParameter);
            this.Controls.Add(this.nudFixedParameter);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.plotView1);
            this.Name = "Form1";
            this.Text = "Secretary problem simulator";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudFixedParameter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinVariableParameter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxVariableParameter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNbOfExperiments)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private OxyPlot.WindowsForms.PlotView plotView1;
        private System.Windows.Forms.RadioButton rbThreshold;
        private System.Windows.Forms.RadioButton rbTolerance;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown nudFixedParameter;
        private System.Windows.Forms.Label lblFixedParameter;
        private System.Windows.Forms.Label lblMinVariableParameter;
        private System.Windows.Forms.NumericUpDown nudMinVariableParameter;
        private System.Windows.Forms.Label lblMaxVariableParameter;
        private System.Windows.Forms.NumericUpDown nudMaxVariableParameter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudNbOfExperiments;
    }
}

