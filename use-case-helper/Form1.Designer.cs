namespace use_case_helper
{
    partial class fMain
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
            this.pMain = new System.Windows.Forms.Panel();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newDiagramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.insertToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usecaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.status = new System.Windows.Forms.StatusStrip();
            this.diagram = new uch.Diagram.Diagram();
            this.pMain.SuspendLayout();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pMain
            // 
            this.pMain.BackColor = System.Drawing.Color.Transparent;
            this.pMain.Controls.Add(this.diagram);
            this.pMain.Controls.Add(this.menu);
            this.pMain.Controls.Add(this.status);
            this.pMain.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pMain.Location = new System.Drawing.Point(0, 64);
            this.pMain.Margin = new System.Windows.Forms.Padding(0);
            this.pMain.Name = "pMain";
            this.pMain.Size = new System.Drawing.Size(770, 484);
            this.pMain.TabIndex = 3;
            // 
            // menu
            // 
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Padding = new System.Windows.Forms.Padding(0);
            this.menu.Size = new System.Drawing.Size(770, 24);
            this.menu.TabIndex = 3;
            this.menu.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newDiagramToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newDiagramToolStripMenuItem
            // 
            this.newDiagramToolStripMenuItem.Name = "newDiagramToolStripMenuItem";
            this.newDiagramToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.newDiagramToolStripMenuItem.Text = "New Diagram";
            this.newDiagramToolStripMenuItem.Click += new System.EventHandler(this.OnNewDiagramClick);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.insertToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 24);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // insertToolStripMenuItem
            // 
            this.insertToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usecaseToolStripMenuItem,
            this.actorToolStripMenuItem});
            this.insertToolStripMenuItem.Name = "insertToolStripMenuItem";
            this.insertToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.insertToolStripMenuItem.Text = "Insert";
            // 
            // usecaseToolStripMenuItem
            // 
            this.usecaseToolStripMenuItem.Name = "usecaseToolStripMenuItem";
            this.usecaseToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.usecaseToolStripMenuItem.Text = "Actor";
            this.usecaseToolStripMenuItem.Click += new System.EventHandler(this.OnInsertActorClicked);
            // 
            // actorToolStripMenuItem
            // 
            this.actorToolStripMenuItem.Name = "actorToolStripMenuItem";
            this.actorToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.actorToolStripMenuItem.Text = "Usecase";
            this.actorToolStripMenuItem.Click += new System.EventHandler(this.OnInsertUsecaseClicked);
            // 
            // status
            // 
            this.status.Location = new System.Drawing.Point(0, 462);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(770, 22);
            this.status.TabIndex = 4;
            this.status.Text = "statusStrip1";
            // 
            // diagram
            // 
            this.diagram.BackColor = System.Drawing.Color.White;
            this.diagram.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.diagram.Location = new System.Drawing.Point(0, 27);
            this.diagram.Name = "diagram";
            this.diagram.Size = new System.Drawing.Size(770, 435);
            this.diagram.TabIndex = 2;
            this.diagram.MouseClick += new System.Windows.Forms.MouseEventHandler(this.OnClick);
            // 
            // fMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 548);
            this.Controls.Add(this.pMain);
            this.Name = "fMain";
            this.Text = "Use Case Helper";
            this.pMain.ResumeLayout(false);
            this.pMain.PerformLayout();
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private uch.Diagram.Diagram diagram;
        private System.Windows.Forms.Panel pMain;
        private System.Windows.Forms.ToolStripMenuItem newDiagramToolStripMenuItem;
        private System.Windows.Forms.StatusStrip status;
        private System.Windows.Forms.ToolStripMenuItem actorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usecaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem insertToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menu;
    }
}

