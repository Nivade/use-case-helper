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
            this.tmiCreateActor = new System.Windows.Forms.ToolStripMenuItem();
            this.tmiCreateUseCase = new System.Windows.Forms.ToolStripMenuItem();
            this.diagramContextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // diagramContextMenu
            // 
            this.diagramContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tmiCreateActor,
            this.tmiCreateUseCase});
            this.diagramContextMenu.Name = "diagramContextMenu";
            this.diagramContextMenu.Size = new System.Drawing.Size(154, 48);
            // 
            // tmiCreateActor
            // 
            this.tmiCreateActor.Name = "tmiCreateActor";
            this.tmiCreateActor.Size = new System.Drawing.Size(153, 22);
            this.tmiCreateActor.Text = "Create Actor";
            this.tmiCreateActor.Click += new System.EventHandler(this.OnCreateActorClick);
            // 
            // tmiCreateUseCase
            // 
            this.tmiCreateUseCase.Name = "tmiCreateUseCase";
            this.tmiCreateUseCase.Size = new System.Drawing.Size(153, 22);
            this.tmiCreateUseCase.Text = "Create Usecase";
            this.tmiCreateUseCase.Click += new System.EventHandler(this.OnCreateUseCaseClick);
            // 
            // Diagram
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ContextMenuStrip = this.diagramContextMenu;
            this.Name = "Diagram";
            this.Size = new System.Drawing.Size(1056, 516);
            this.Click += new System.EventHandler(this.OnDiagramClicked);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.OnPaint);
            this.diagramContextMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip diagramContextMenu;
        private System.Windows.Forms.ToolStripMenuItem tmiCreateActor;
        private System.Windows.Forms.ToolStripMenuItem tmiCreateUseCase;
    }
}
