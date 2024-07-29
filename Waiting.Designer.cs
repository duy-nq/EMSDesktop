namespace EMSDesktop
{
    partial class Waiting
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
            this.progressPanel1 = new DevExpress.XtraWaitForm.ProgressPanel();
            this.SuspendLayout();
            // 
            // progressPanel1
            // 
            this.progressPanel1.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.progressPanel1.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.progressPanel1.Appearance.Options.UseBackColor = true;
            this.progressPanel1.Appearance.Options.UseFont = true;
            this.progressPanel1.Appearance.Options.UseTextOptions = true;
            this.progressPanel1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.progressPanel1.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.progressPanel1.AppearanceCaption.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.progressPanel1.AppearanceCaption.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.progressPanel1.AppearanceCaption.Options.UseFont = true;
            this.progressPanel1.AppearanceCaption.Options.UseTextOptions = true;
            this.progressPanel1.AppearanceCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.progressPanel1.AppearanceDescription.Options.UseTextOptions = true;
            this.progressPanel1.AppearanceDescription.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.progressPanel1.AppearanceDescription.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.progressPanel1.Caption = "We are finding the answer...";
            this.progressPanel1.ContentAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.progressPanel1.Description = "Stay tuned";
            this.progressPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.progressPanel1.Location = new System.Drawing.Point(0, 0);
            this.progressPanel1.Name = "progressPanel1";
            this.progressPanel1.Size = new System.Drawing.Size(498, 66);
            this.progressPanel1.TabIndex = 0;
            this.progressPanel1.Text = "progressPanel1";
            // 
            // Waiting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 66);
            this.Controls.Add(this.progressPanel1);
            this.Name = "Waiting";
            this.Text = "Waiting";
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraWaitForm.ProgressPanel progressPanel1;
    }
}