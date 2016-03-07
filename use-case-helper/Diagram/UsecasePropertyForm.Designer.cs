namespace uch.Diagram
{
    partial class UsecasePropertyForm
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
            this.tbNaam = new System.Windows.Forms.TextBox();
            this.tbSamenvatting = new System.Windows.Forms.TextBox();
            this.tbActoren = new System.Windows.Forms.TextBox();
            this.tbAannamen = new System.Windows.Forms.TextBox();
            this.tbBeschrijving = new System.Windows.Forms.TextBox();
            this.tbUitzonderingen = new System.Windows.Forms.TextBox();
            this.tbResultaat = new System.Windows.Forms.TextBox();
            this.lNaam = new System.Windows.Forms.Label();
            this.lSamenvatting = new System.Windows.Forms.Label();
            this.lActoren = new System.Windows.Forms.Label();
            this.lAannamen = new System.Windows.Forms.Label();
            this.lBeschrijving = new System.Windows.Forms.Label();
            this.lUitzonderingen = new System.Windows.Forms.Label();
            this.lResultaat = new System.Windows.Forms.Label();
            this.btSave = new MaterialSkin.Controls.MaterialFlatButton();
            this.cbActors = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // tbNaam
            // 
            this.tbNaam.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbNaam.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNaam.Location = new System.Drawing.Point(150, 12);
            this.tbNaam.Name = "tbNaam";
            this.tbNaam.Size = new System.Drawing.Size(361, 24);
            this.tbNaam.TabIndex = 0;
            this.tbNaam.TextChanged += new System.EventHandler(this.OnTextboxNameChanged);
            // 
            // tbSamenvatting
            // 
            this.tbSamenvatting.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbSamenvatting.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSamenvatting.Location = new System.Drawing.Point(150, 42);
            this.tbSamenvatting.Name = "tbSamenvatting";
            this.tbSamenvatting.Size = new System.Drawing.Size(361, 24);
            this.tbSamenvatting.TabIndex = 1;
            // 
            // tbActoren
            // 
            this.tbActoren.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbActoren.Enabled = false;
            this.tbActoren.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbActoren.Location = new System.Drawing.Point(150, 72);
            this.tbActoren.Name = "tbActoren";
            this.tbActoren.Size = new System.Drawing.Size(241, 24);
            this.tbActoren.TabIndex = 2;
            // 
            // tbAannamen
            // 
            this.tbAannamen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbAannamen.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAannamen.Location = new System.Drawing.Point(150, 102);
            this.tbAannamen.Name = "tbAannamen";
            this.tbAannamen.Size = new System.Drawing.Size(361, 24);
            this.tbAannamen.TabIndex = 3;
            // 
            // tbBeschrijving
            // 
            this.tbBeschrijving.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbBeschrijving.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbBeschrijving.Location = new System.Drawing.Point(150, 132);
            this.tbBeschrijving.Multiline = true;
            this.tbBeschrijving.Name = "tbBeschrijving";
            this.tbBeschrijving.Size = new System.Drawing.Size(361, 181);
            this.tbBeschrijving.TabIndex = 4;
            // 
            // tbUitzonderingen
            // 
            this.tbUitzonderingen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbUitzonderingen.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUitzonderingen.Location = new System.Drawing.Point(150, 319);
            this.tbUitzonderingen.Multiline = true;
            this.tbUitzonderingen.Name = "tbUitzonderingen";
            this.tbUitzonderingen.Size = new System.Drawing.Size(361, 181);
            this.tbUitzonderingen.TabIndex = 5;
            // 
            // tbResultaat
            // 
            this.tbResultaat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbResultaat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbResultaat.Location = new System.Drawing.Point(150, 526);
            this.tbResultaat.Name = "tbResultaat";
            this.tbResultaat.Size = new System.Drawing.Size(361, 24);
            this.tbResultaat.TabIndex = 6;
            // 
            // lNaam
            // 
            this.lNaam.AutoSize = true;
            this.lNaam.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lNaam.Location = new System.Drawing.Point(21, 14);
            this.lNaam.Name = "lNaam";
            this.lNaam.Size = new System.Drawing.Size(52, 18);
            this.lNaam.TabIndex = 7;
            this.lNaam.Text = "Naam:";
            // 
            // lSamenvatting
            // 
            this.lSamenvatting.AutoSize = true;
            this.lSamenvatting.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lSamenvatting.Location = new System.Drawing.Point(21, 44);
            this.lSamenvatting.Name = "lSamenvatting";
            this.lSamenvatting.Size = new System.Drawing.Size(101, 18);
            this.lSamenvatting.TabIndex = 8;
            this.lSamenvatting.Text = "Samenvatting:";
            // 
            // lActoren
            // 
            this.lActoren.AutoSize = true;
            this.lActoren.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lActoren.Location = new System.Drawing.Point(21, 74);
            this.lActoren.Name = "lActoren";
            this.lActoren.Size = new System.Drawing.Size(63, 18);
            this.lActoren.TabIndex = 9;
            this.lActoren.Text = "Actoren:";
            // 
            // lAannamen
            // 
            this.lAannamen.AutoSize = true;
            this.lAannamen.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lAannamen.Location = new System.Drawing.Point(21, 104);
            this.lAannamen.Name = "lAannamen";
            this.lAannamen.Size = new System.Drawing.Size(82, 18);
            this.lAannamen.TabIndex = 10;
            this.lAannamen.Text = "Aannamen:";
            // 
            // lBeschrijving
            // 
            this.lBeschrijving.AutoSize = true;
            this.lBeschrijving.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lBeschrijving.Location = new System.Drawing.Point(21, 134);
            this.lBeschrijving.Name = "lBeschrijving";
            this.lBeschrijving.Size = new System.Drawing.Size(79, 18);
            this.lBeschrijving.TabIndex = 11;
            this.lBeschrijving.Text = "Bescrijving";
            // 
            // lUitzonderingen
            // 
            this.lUitzonderingen.AutoSize = true;
            this.lUitzonderingen.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lUitzonderingen.Location = new System.Drawing.Point(21, 321);
            this.lUitzonderingen.Name = "lUitzonderingen";
            this.lUitzonderingen.Size = new System.Drawing.Size(111, 18);
            this.lUitzonderingen.TabIndex = 12;
            this.lUitzonderingen.Text = "Uitzonderingen:";
            // 
            // lResultaat
            // 
            this.lResultaat.AutoSize = true;
            this.lResultaat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lResultaat.Location = new System.Drawing.Point(48, 526);
            this.lResultaat.Name = "lResultaat";
            this.lResultaat.Size = new System.Drawing.Size(74, 18);
            this.lResultaat.TabIndex = 13;
            this.lResultaat.Text = "Resultaat:";
            // 
            // btSave
            // 
            this.btSave.AutoSize = true;
            this.btSave.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btSave.Depth = 0;
            this.btSave.Location = new System.Drawing.Point(243, 570);
            this.btSave.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btSave.MouseState = MaterialSkin.MouseState.HOVER;
            this.btSave.Name = "btSave";
            this.btSave.Primary = false;
            this.btSave.Size = new System.Drawing.Size(46, 36);
            this.btSave.TabIndex = 14;
            this.btSave.Text = "Save";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.Save);
            // 
            // cbActors
            // 
            this.cbActors.FormattingEnabled = true;
            this.cbActors.Location = new System.Drawing.Point(397, 72);
            this.cbActors.Name = "cbActors";
            this.cbActors.Size = new System.Drawing.Size(114, 21);
            this.cbActors.TabIndex = 15;
            // 
            // UsecasePropertyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 621);
            this.Controls.Add(this.cbActors);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.lResultaat);
            this.Controls.Add(this.lUitzonderingen);
            this.Controls.Add(this.lBeschrijving);
            this.Controls.Add(this.lAannamen);
            this.Controls.Add(this.lActoren);
            this.Controls.Add(this.lSamenvatting);
            this.Controls.Add(this.lNaam);
            this.Controls.Add(this.tbResultaat);
            this.Controls.Add(this.tbUitzonderingen);
            this.Controls.Add(this.tbBeschrijving);
            this.Controls.Add(this.tbAannamen);
            this.Controls.Add(this.tbActoren);
            this.Controls.Add(this.tbSamenvatting);
            this.Controls.Add(this.tbNaam);
            this.Name = "UsecasePropertyForm";
            this.Text = "PropertyWindow";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbNaam;
        private System.Windows.Forms.TextBox tbSamenvatting;
        private System.Windows.Forms.TextBox tbActoren;
        private System.Windows.Forms.TextBox tbAannamen;
        private System.Windows.Forms.TextBox tbBeschrijving;
        private System.Windows.Forms.TextBox tbUitzonderingen;
        private System.Windows.Forms.TextBox tbResultaat;
        private System.Windows.Forms.Label lNaam;
        private System.Windows.Forms.Label lSamenvatting;
        private System.Windows.Forms.Label lActoren;
        private System.Windows.Forms.Label lAannamen;
        private System.Windows.Forms.Label lBeschrijving;
        private System.Windows.Forms.Label lUitzonderingen;
        private System.Windows.Forms.Label lResultaat;
        private MaterialSkin.Controls.MaterialFlatButton btSave;
        private System.Windows.Forms.ComboBox cbActors;
    }
}