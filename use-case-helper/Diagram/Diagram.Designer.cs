namespace uch.Diagram
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
            this.diagramContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmsDiagram = new System.Windows.Forms.ToolStripMenuItem();
            this.createUsecaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.diagramContextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // diagramContextMenuStrip
            // 
            this.diagramContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmsDiagram,
            this.createUsecaseToolStripMenuItem});
            this.diagramContextMenuStrip.Name = "diagramContextMenuStrip";
            this.diagramContextMenuStrip.Size = new System.Drawing.Size(154, 48);
            // 
            // cmsDiagram
            // 
            this.cmsDiagram.Name = "cmsDiagram";
            this.cmsDiagram.Size = new System.Drawing.Size(153, 22);
            this.cmsDiagram.Text = "Create Actor";
            this.cmsDiagram.Click += new System.EventHandler(this.createActorToolStripMenuItem_Click);
            // 
            // createUsecaseToolStripMenuItem
            // 
            this.createUsecaseToolStripMenuItem.Name = "createUsecaseToolStripMenuItem";
            this.createUsecaseToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.createUsecaseToolStripMenuItem.Text = "Create Usecase";
            // 
            // Diagram
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ContextMenuStrip = this.diagramContextMenuStrip;
            this.DoubleBuffered = true;
            this.Name = "Diagram";
            this.Size = new System.Drawing.Size(671, 392);
            this.Click += new System.EventHandler(this.OnDiagramClick);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.OnPaint);
            this.diagramContextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip diagramContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem cmsDiagram;
        private System.Windows.Forms.ToolStripMenuItem createUsecaseToolStripMenuItem;
    }
}
