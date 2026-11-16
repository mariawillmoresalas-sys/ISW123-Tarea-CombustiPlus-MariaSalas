namespace CombustiPlus
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
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            textBox2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox3 = new TextBox();
            label4 = new Label();
            lstDespachos = new ListBox();
            lstDetalle = new ListBox();
            bntPorCombustible = new Button();
            lblResumen = new Label();
            gpbDespacho = new GroupBox();
            gpbDetalle = new GroupBox();
            lblPlaca = new Label();
            lblPago = new Label();
            lblGalones = new Label();
            lblCombustible = new Label();
            cmbCombustible = new ComboBox();
            groupBox1 = new GroupBox();
            txtPlaca = new TextBox();
            nudGalones = new NumericUpDown();
            cmbPago = new ComboBox();
            btnDespachar = new Button();
            btnCotizar = new Button();
            gpbDespacho.SuspendLayout();
            gpbDetalle.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudGalones).BeginInit();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(71, 143);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(164, 23);
            comboBox1.TabIndex = 15;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(114, 64);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(121, 23);
            comboBox2.TabIndex = 14;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(84, 104);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(151, 23);
            textBox2.TabIndex = 13;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 67);
            label1.Name = "label1";
            label1.Size = new Size(75, 15);
            label1.TabIndex = 12;
            label1.Text = "Combustible";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 107);
            label2.Name = "label2";
            label2.Size = new Size(49, 15);
            label2.TabIndex = 11;
            label2.Text = "Galones";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(19, 146);
            label3.Name = "label3";
            label3.Size = new Size(34, 15);
            label3.TabIndex = 10;
            label3.Text = "Pago";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(84, 25);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(151, 23);
            textBox3.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(22, 33);
            label4.Name = "label4";
            label4.Size = new Size(35, 15);
            label4.TabIndex = 8;
            label4.Text = "Placa";
            // 
            // lstDespachos
            // 
            lstDespachos.FormattingEnabled = true;
            lstDespachos.Location = new Point(17, 22);
            lstDespachos.Name = "lstDespachos";
            lstDespachos.Size = new Size(455, 199);
            lstDespachos.TabIndex = 9;
            // 
            // lstDetalle
            // 
            lstDetalle.FormattingEnabled = true;
            lstDetalle.Location = new Point(16, 22);
            lstDetalle.Name = "lstDetalle";
            lstDetalle.Size = new Size(263, 139);
            lstDetalle.TabIndex = 10;
            // 
            // bntPorCombustible
            // 
            bntPorCombustible.Location = new Point(17, 230);
            bntPorCombustible.Name = "bntPorCombustible";
            bntPorCombustible.Size = new Size(123, 27);
            bntPorCombustible.TabIndex = 11;
            bntPorCombustible.Text = "Por combustible";
            bntPorCombustible.UseVisualStyleBackColor = true;
            // 
            // lblResumen
            // 
            lblResumen.AutoSize = true;
            lblResumen.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblResumen.ForeColor = SystemColors.HotTrack;
            lblResumen.Location = new Point(329, 314);
            lblResumen.Name = "lblResumen";
            lblResumen.Size = new Size(80, 21);
            lblResumen.TabIndex = 12;
            lblResumen.Text = "Resumen";
            // 
            // gpbDespacho
            // 
            gpbDespacho.Controls.Add(lstDespachos);
            gpbDespacho.Controls.Add(bntPorCombustible);
            gpbDespacho.Location = new Point(312, 24);
            gpbDespacho.Name = "gpbDespacho";
            gpbDespacho.Size = new Size(491, 267);
            gpbDespacho.TabIndex = 13;
            gpbDespacho.TabStop = false;
            gpbDespacho.Text = "Despacho del dia";
            // 
            // gpbDetalle
            // 
            gpbDetalle.Controls.Add(lstDetalle);
            gpbDetalle.Location = new Point(9, 266);
            gpbDetalle.Name = "gpbDetalle";
            gpbDetalle.Size = new Size(297, 173);
            gpbDetalle.TabIndex = 14;
            gpbDetalle.TabStop = false;
            gpbDetalle.Text = "Detalle";
            // 
            // lblPlaca
            // 
            lblPlaca.AutoSize = true;
            lblPlaca.Location = new Point(24, 38);
            lblPlaca.Name = "lblPlaca";
            lblPlaca.Size = new Size(35, 15);
            lblPlaca.TabIndex = 15;
            lblPlaca.Text = "Placa";
            // 
            // lblPago
            // 
            lblPago.AutoSize = true;
            lblPago.Location = new Point(25, 136);
            lblPago.Name = "lblPago";
            lblPago.Size = new Size(34, 15);
            lblPago.TabIndex = 16;
            lblPago.Text = "Pago";
            // 
            // lblGalones
            // 
            lblGalones.AutoSize = true;
            lblGalones.Location = new Point(24, 98);
            lblGalones.Name = "lblGalones";
            lblGalones.Size = new Size(49, 15);
            lblGalones.TabIndex = 17;
            lblGalones.Text = "Galones";
            // 
            // lblCombustible
            // 
            lblCombustible.AutoSize = true;
            lblCombustible.Location = new Point(24, 66);
            lblCombustible.Name = "lblCombustible";
            lblCombustible.Size = new Size(75, 15);
            lblCombustible.TabIndex = 18;
            lblCombustible.Text = "Combustible";
            // 
            // cmbCombustible
            // 
            cmbCombustible.FormattingEnabled = true;
            cmbCombustible.Location = new Point(105, 63);
            cmbCombustible.Name = "cmbCombustible";
            cmbCombustible.Size = new Size(134, 23);
            cmbCombustible.TabIndex = 22;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtPlaca);
            groupBox1.Controls.Add(nudGalones);
            groupBox1.Controls.Add(cmbPago);
            groupBox1.Controls.Add(btnDespachar);
            groupBox1.Controls.Add(btnCotizar);
            groupBox1.Controls.Add(lblCombustible);
            groupBox1.Controls.Add(cmbCombustible);
            groupBox1.Controls.Add(lblPlaca);
            groupBox1.Controls.Add(lblPago);
            groupBox1.Controls.Add(lblGalones);
            groupBox1.Location = new Point(12, 24);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(281, 236);
            groupBox1.TabIndex = 23;
            groupBox1.TabStop = false;
            groupBox1.Text = "Nuevo despacho";
            // 
            // txtPlaca
            // 
            txtPlaca.Location = new Point(65, 30);
            txtPlaca.Name = "txtPlaca";
            txtPlaca.Size = new Size(174, 23);
            txtPlaca.TabIndex = 12;
            // 
            // nudGalones
            // 
            nudGalones.Location = new Point(79, 98);
            nudGalones.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            nudGalones.Name = "nudGalones";
            nudGalones.Size = new Size(160, 23);
            nudGalones.TabIndex = 27;
            // 
            // cmbPago
            // 
            cmbPago.FormattingEnabled = true;
            cmbPago.Location = new Point(65, 136);
            cmbPago.Name = "cmbPago";
            cmbPago.Size = new Size(174, 23);
            cmbPago.TabIndex = 26;
            // 
            // btnDespachar
            // 
            btnDespachar.Location = new Point(134, 186);
            btnDespachar.Name = "btnDespachar";
            btnDespachar.Size = new Size(93, 23);
            btnDespachar.TabIndex = 25;
            btnDespachar.Text = "Despachar";
            btnDespachar.UseVisualStyleBackColor = true;
            btnDespachar.Click += btnDespachar_Click;
            // 
            // btnCotizar
            // 
            btnCotizar.Location = new Point(24, 186);
            btnCotizar.Name = "btnCotizar";
            btnCotizar.Size = new Size(98, 23);
            btnCotizar.TabIndex = 24;
            btnCotizar.Text = "Cotizar";
            btnCotizar.UseVisualStyleBackColor = true;
            btnCotizar.Click += btnCotizar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(815, 450);
            Controls.Add(groupBox1);
            Controls.Add(gpbDetalle);
            Controls.Add(gpbDespacho);
            Controls.Add(lblResumen);
            Name = "Form1";
            Text = "Form1";
            gpbDespacho.ResumeLayout(false);
            gpbDetalle.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudGalones).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private GroupBox groupBox1;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private TextBox textBox2;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox3;
        private Label label4;
        
        private ListBox lstDespachos;
        private ListBox lstDetalle;
        private Button bntPorCombustible;
        private Label lblResumen;
        private GroupBox gpbDespacho;
        private GroupBox gpbDetalle;
        private Label lblPlaca;
        private Label lblPago;
        private Label lblGalones;
        private Label lblCombustible;
       
        private ComboBox cmbCombustible;
       
        private Button btnCotizar;
        private Button btnDespachar;
        private NumericUpDown nudGalones;
        private ComboBox cmbPago;
        private TextBox txtPlaca;
    }
}
