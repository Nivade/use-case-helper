namespace UseCaseHelper.Controls
{
    partial class UseCaseControl
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
            this.tbName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(3, 44);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(307, 20);
            this.tbName.TabIndex = 0;
            // 
            // UseCaseControl
            // 
            this.ActiveBackgroundImage = global::UseCaseHelper.Properties.Resources.usecase_click;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::UseCaseHelper.Properties.Resources.usecase;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.tbName);
            this.DefaultBackgroundImage = global::UseCaseHelper.Properties.Resources.usecase;
            this.Name = "UseCaseControl";
            this.Size = new System.Drawing.Size(313, 107);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbName;
    }
}
