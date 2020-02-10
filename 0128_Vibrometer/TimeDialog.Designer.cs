namespace _0128_Vibrometer
{
    partial class TimeDialog
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
            this.timebaseChart1 = new _0128_Vibrometer.TimebaseChart();
            this.SuspendLayout();
            // 
            // timebaseChart1
            // 
            this.timebaseChart1.Aaaa = "kk";
            this.timebaseChart1.AnyColoraaa = System.Drawing.Color.Empty;
            this.timebaseChart1.Location = new System.Drawing.Point(31, 12);
            this.timebaseChart1.Name = "timebaseChart1";
            this.timebaseChart1.Size = new System.Drawing.Size(584, 293);
            this.timebaseChart1.TabIndex = 0;
            // 
            // TimeDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.timebaseChart1);
            this.Name = "TimeDialog";
            this.Text = "TimeDialog";
            this.ResumeLayout(false);

        }

        #endregion

        private TimebaseChart timebaseChart1;
    }
}