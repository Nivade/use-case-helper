namespace UseCaseHelper.Controls
{
    partial class Diagram
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
            this.components = new System.ComponentModel.Container();
            this.diagramContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addActorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addUseCaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.diagramContextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // diagramContextMenu
            // 
            this.diagramContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addActorToolStripMenuItem,
            this.addUseCaseToolStripMenuItem});
            this.diagramContextMenu.Name = "diagramContextMenu";
            this.diagramContextMenu.Size = new System.Drawing.Size(147, 48);
            // 
            // addActorToolStripMenuItem
            // 
            this.addActorToolStripMenuItem.Name = "addActorToolStripMenuItem";
            this.addActorToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.addActorToolStripMenuItem.Text = "Add Actor";
            this.addActorToolStripMenuItem.Click += new System.EventHandler(this.OnClick);
            // 
            // addUseCaseToolStripMenuItem
            // 
            this.addUseCaseToolStripMenuItem.Name = "addUseCaseToolStripMenuItem";
            this.addUseCaseToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.addUseCaseToolStripMenuItem.Text = "Add Use Case";
            // 
            // Diagram
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ContextMenuStrip = this.diagramContextMenu;
            this.Name = "Diagram";
            this.Size = new System.Drawing.Size(1056, 516);
            this.Click += new System.EventHandler(this.OnClick);
            this.diagramContextMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip diagramContextMenu;
        private System.Windows.Forms.ToolStripMenuItem addActorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addUseCaseToolStripMenuItem;
    }
}
