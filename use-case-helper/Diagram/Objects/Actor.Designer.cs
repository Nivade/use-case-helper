namespace uch.Diagram.Objects
{
    partial class Actor
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
            this.tbName = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.SuspendLayout();
            // 
            // tbName
            // 
            this.tbName.Depth = 0;
            this.tbName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tbName.Hint = "";
            this.tbName.Location = new System.Drawing.Point(3, 117);
            this.tbName.MouseState = MaterialSkin.MouseState.HOVER;
            this.tbName.Name = "tbName";
            this.tbName.PasswordChar = '\0';
            this.tbName.SelectedText = "";
            this.tbName.SelectionLength = 0;
            this.tbName.SelectionStart = 0;
            this.tbName.Size = new System.Drawing.Size(75, 23);
            this.tbName.TabIndex = 0;
            this.tbName.UseSystemPasswordChar = false;
            this.tbName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OnKeyDown);
            // 
            // Actor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::uch.Properties.Resources.stickman;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Controls.Add(this.tbName);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.DoubleBuffered = true;
            this.MinimumSize = new System.Drawing.Size(47, 112);
            this.Name = "Actor";
            this.Size = new System.Drawing.Size(81, 143);
            this.DoubleClick += new System.EventHandler(this.OnDoubleClick);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BeginDrag);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Drag);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.OnMouseUp);
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialSingleLineTextField tbName;
    }
}
