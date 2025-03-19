namespace CapaPresentacion
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tbNroDoc = new TextBox();
            tbIngresosT = new TextBox();
            tbEgresosT = new TextBox();
            tbMontoS = new TextBox();
            tbPlazoS = new TextBox();
            lbTipoDoc = new Label();
            lbNroDoc = new Label();
            lbIngresosT = new Label();
            lbEgresosT = new Label();
            lbMontoS = new Label();
            lbPlazoS = new Label();
            cbTipoDoc = new ComboBox();
            btn = new Button();
            SuspendLayout();
            // 
            // tbNroDoc
            // 
            tbNroDoc.Location = new Point(206, 67);
            tbNroDoc.Name = "tbNroDoc";
            tbNroDoc.Size = new Size(121, 23);
            tbNroDoc.TabIndex = 1;
            // 
            // tbIngresosT
            // 
            tbIngresosT.Location = new Point(206, 106);
            tbIngresosT.Name = "tbIngresosT";
            tbIngresosT.Size = new Size(121, 23);
            tbIngresosT.TabIndex = 2;
            // 
            // tbEgresosT
            // 
            tbEgresosT.Location = new Point(206, 147);
            tbEgresosT.Name = "tbEgresosT";
            tbEgresosT.Size = new Size(121, 23);
            tbEgresosT.TabIndex = 3;
            // 
            // tbMontoS
            // 
            tbMontoS.Location = new Point(206, 190);
            tbMontoS.Name = "tbMontoS";
            tbMontoS.Size = new Size(121, 23);
            tbMontoS.TabIndex = 4;
            // 
            // tbPlazoS
            // 
            tbPlazoS.Location = new Point(206, 231);
            tbPlazoS.Name = "tbPlazoS";
            tbPlazoS.Size = new Size(121, 23);
            tbPlazoS.TabIndex = 5;
            // 
            // lbTipoDoc
            // 
            lbTipoDoc.AutoSize = true;
            lbTipoDoc.Location = new Point(66, 28);
            lbTipoDoc.Name = "lbTipoDoc";
            lbTipoDoc.Size = new Size(96, 15);
            lbTipoDoc.TabIndex = 6;
            lbTipoDoc.Text = "Tipo documento";
            // 
            // lbNroDoc
            // 
            lbNroDoc.AutoSize = true;
            lbNroDoc.Location = new Point(66, 67);
            lbNroDoc.Name = "lbNroDoc";
            lbNroDoc.Size = new Size(116, 15);
            lbNroDoc.TabIndex = 7;
            lbNroDoc.Text = "Numero documento";
            // 
            // lbIngresosT
            // 
            lbIngresosT.AutoSize = true;
            lbIngresosT.Location = new Point(66, 106);
            lbIngresosT.Name = "lbIngresosT";
            lbIngresosT.Size = new Size(89, 15);
            lbIngresosT.TabIndex = 8;
            lbIngresosT.Text = "Ingresos totales";
            // 
            // lbEgresosT
            // 
            lbEgresosT.AutoSize = true;
            lbEgresosT.Location = new Point(66, 147);
            lbEgresosT.Name = "lbEgresosT";
            lbEgresosT.Size = new Size(85, 15);
            lbEgresosT.TabIndex = 9;
            lbEgresosT.Text = "Egresos totales";
            // 
            // lbMontoS
            // 
            lbMontoS.AutoSize = true;
            lbMontoS.Location = new Point(66, 190);
            lbMontoS.Name = "lbMontoS";
            lbMontoS.Size = new Size(98, 15);
            lbMontoS.TabIndex = 10;
            lbMontoS.Text = "Monto Solicitado";
            // 
            // lbPlazoS
            // 
            lbPlazoS.AutoSize = true;
            lbPlazoS.Location = new Point(66, 231);
            lbPlazoS.Name = "lbPlazoS";
            lbPlazoS.Size = new Size(89, 15);
            lbPlazoS.TabIndex = 11;
            lbPlazoS.Text = "Plazo solicitado";
            // 
            // cbTipoDoc
            // 
            cbTipoDoc.FormattingEnabled = true;
            cbTipoDoc.Items.AddRange(new object[] { "CC", "TI" });
            cbTipoDoc.Location = new Point(206, 28);
            cbTipoDoc.Name = "cbTipoDoc";
            cbTipoDoc.Size = new Size(121, 23);
            cbTipoDoc.TabIndex = 12;
            // 
            // btn
            // 
            btn.Location = new Point(128, 286);
            btn.Name = "btn";
            btn.Size = new Size(128, 23);
            btn.TabIndex = 13;
            btn.Text = "Solicitar Credito";
            btn.UseVisualStyleBackColor = true;
            btn.Click += btn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(368, 321);
            Controls.Add(btn);
            Controls.Add(cbTipoDoc);
            Controls.Add(lbPlazoS);
            Controls.Add(lbMontoS);
            Controls.Add(lbEgresosT);
            Controls.Add(lbIngresosT);
            Controls.Add(lbNroDoc);
            Controls.Add(lbTipoDoc);
            Controls.Add(tbPlazoS);
            Controls.Add(tbMontoS);
            Controls.Add(tbEgresosT);
            Controls.Add(tbIngresosT);
            Controls.Add(tbNroDoc);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox tbNroDoc;
        private TextBox tbIngresosT;
        private TextBox tbEgresosT;
        private TextBox tbMontoS;
        private TextBox tbPlazoS;
        private Label lbTipoDoc;
        private Label lbNroDoc;
        private Label lbIngresosT;
        private Label lbEgresosT;
        private Label lbMontoS;
        private Label lbPlazoS;
        private ComboBox cbTipoDoc;
        private Button btn;
    }
}
