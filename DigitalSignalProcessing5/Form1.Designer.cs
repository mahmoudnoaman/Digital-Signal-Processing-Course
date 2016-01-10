namespace DigitalSignalProcessing5
{
    partial class DigitalSignalProcessing
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
            this.SignalAlgorithms = new System.Windows.Forms.ComboBox();
            this.loadsinal1 = new System.Windows.Forms.Button();
            this.loadsignal2 = new System.Windows.Forms.Button();
            this.standard = new System.Windows.Forms.CheckBox();
            this.fast = new System.Windows.Forms.CheckBox();
            this.openfile = new System.Windows.Forms.OpenFileDialog();
            this.ResultSignal = new System.Windows.Forms.RichTextBox();
            this.Compute = new System.Windows.Forms.Button();
            this.ResultSignalNorlmalized = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SignalAlgorithms
            // 
            this.SignalAlgorithms.FormattingEnabled = true;
            this.SignalAlgorithms.Items.AddRange(new object[] {
            "Convolution",
            "PeriodicCorrelation",
            "NonPeriodicCorrelation",
            "PeriodicAutoCorrelation",
            "NonPeriodicAutoCorrelation"});
            this.SignalAlgorithms.Location = new System.Drawing.Point(12, 31);
            this.SignalAlgorithms.Name = "SignalAlgorithms";
            this.SignalAlgorithms.Size = new System.Drawing.Size(121, 21);
            this.SignalAlgorithms.TabIndex = 0;
            this.SignalAlgorithms.SelectedIndexChanged += new System.EventHandler(this.SignalAlgorithms_SelectedIndexChanged);
            // 
            // loadsinal1
            // 
            this.loadsinal1.Location = new System.Drawing.Point(177, 31);
            this.loadsinal1.Name = "loadsinal1";
            this.loadsinal1.Size = new System.Drawing.Size(75, 23);
            this.loadsinal1.TabIndex = 1;
            this.loadsinal1.Text = "LoadSignal1";
            this.loadsinal1.UseVisualStyleBackColor = true;
            this.loadsinal1.Click += new System.EventHandler(this.loadsinal2_Click);
            // 
            // loadsignal2
            // 
            this.loadsignal2.Location = new System.Drawing.Point(277, 31);
            this.loadsignal2.Name = "loadsignal2";
            this.loadsignal2.Size = new System.Drawing.Size(75, 23);
            this.loadsignal2.TabIndex = 2;
            this.loadsignal2.Text = "LoadSignal2";
            this.loadsignal2.UseVisualStyleBackColor = true;
            this.loadsignal2.Click += new System.EventHandler(this.loadsignal1_Click);
            // 
            // standard
            // 
            this.standard.AutoSize = true;
            this.standard.Location = new System.Drawing.Point(183, 70);
            this.standard.Name = "standard";
            this.standard.Size = new System.Drawing.Size(69, 17);
            this.standard.TabIndex = 3;
            this.standard.Text = "standard";
            this.standard.UseVisualStyleBackColor = true;
            // 
            // fast
            // 
            this.fast.AutoSize = true;
            this.fast.Location = new System.Drawing.Point(307, 70);
            this.fast.Name = "fast";
            this.fast.Size = new System.Drawing.Size(45, 17);
            this.fast.TabIndex = 4;
            this.fast.Text = "fast";
            this.fast.UseVisualStyleBackColor = true;
            // 
            // ResultSignal
            // 
            this.ResultSignal.Location = new System.Drawing.Point(177, 109);
            this.ResultSignal.Name = "ResultSignal";
            this.ResultSignal.Size = new System.Drawing.Size(171, 229);
            this.ResultSignal.TabIndex = 5;
            this.ResultSignal.Text = "";
            // 
            // Compute
            // 
            this.Compute.Location = new System.Drawing.Point(183, 361);
            this.Compute.Name = "Compute";
            this.Compute.Size = new System.Drawing.Size(75, 23);
            this.Compute.TabIndex = 6;
            this.Compute.Text = "Compute";
            this.Compute.UseVisualStyleBackColor = true;
            this.Compute.Click += new System.EventHandler(this.Compute_Click);
            // 
            // ResultSignalNorlmalized
            // 
            this.ResultSignalNorlmalized.Location = new System.Drawing.Point(365, 109);
            this.ResultSignalNorlmalized.Name = "ResultSignalNorlmalized";
            this.ResultSignalNorlmalized.Size = new System.Drawing.Size(171, 229);
            this.ResultSignalNorlmalized.TabIndex = 7;
            this.ResultSignalNorlmalized.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(183, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Standard";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(375, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Normalized";
            // 
            // DigitalSignalProcessing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(834, 452);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ResultSignalNorlmalized);
            this.Controls.Add(this.Compute);
            this.Controls.Add(this.ResultSignal);
            this.Controls.Add(this.fast);
            this.Controls.Add(this.standard);
            this.Controls.Add(this.loadsignal2);
            this.Controls.Add(this.loadsinal1);
            this.Controls.Add(this.SignalAlgorithms);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Name = "DigitalSignalProcessing";
            this.Text = "DigitalSignalProcessing";
            this.Load += new System.EventHandler(this.DigitalSignalProcessing_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox SignalAlgorithms;
        private System.Windows.Forms.Button loadsinal1;
        private System.Windows.Forms.Button loadsignal2;
        private System.Windows.Forms.CheckBox standard;
        private System.Windows.Forms.CheckBox fast;
        private System.Windows.Forms.OpenFileDialog openfile;
        private System.Windows.Forms.RichTextBox ResultSignal;
        private System.Windows.Forms.Button Compute;
        private System.Windows.Forms.RichTextBox ResultSignalNorlmalized;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

