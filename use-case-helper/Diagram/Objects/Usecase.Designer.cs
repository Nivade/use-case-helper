namespace uch.Diagram.Objects
{
    partial class Usecase
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
            this.tbName = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.cmsUsecase = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1.SuspendLayout();
            this.cmsUsecase.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbName
            // 
            this.tbName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbName.Location = new System.Drawing.Point(10, 26);
            this.tbName.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.tbName.Multiline = true;
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(170, 17);
            this.tbName.TabIndex = 0;
            this.tbName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbName.WordWrap = false;
            this.tbName.TextChanged += new System.EventHandler(this.OnTbNameTextChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tbName, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(190, 70);
            this.tableLayoutPanel1.TabIndex = 1;
            this.tableLayoutPanel1.DoubleClick += new System.EventHandler(this.DoubleClick);
            this.tableLayoutPanel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BeginDrag);
            this.tableLayoutPanel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Drag);
            // 
            // cmsUsecase
            // 
            this.cmsUsecase.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.cmsUsecase.Name = "cmsUsecase";
            this.cmsUsecase.Size = new System.Drawing.Size(108, 48);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // Usecase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::uch.Properties.Resources.usecase;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ContextMenuStrip = this.cmsUsecase;
            this.Controls.Add(this.tableLayoutPanel1);
            this.DoubleBuffered = true;
            this.Name = "Usecase";
            this.Size = new System.Drawing.Size(190, 70);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BeginDrag);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Drag);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.cmsUsecase.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ContextMenuStrip cmsUsecase;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
    }
}
