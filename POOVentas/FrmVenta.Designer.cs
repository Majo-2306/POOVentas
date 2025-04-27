namespace POOVentas
{
    partial class FrmVenta
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
            label1 = new Label();
            label2 = new Label();
            DgvConceptos = new DataGridView();
            btnAgregar = new Button();
            TxtCantidad = new TextBox();
            TxtDescripcion = new TextBox();
            label3 = new Label();
            TxtValorUnitario = new TextBox();
            TxtTotal = new TextBox();
            BtnEfectivo = new Button();
            BtnTarjeta = new Button();
            label4 = new Label();
            TxtCortesia = new TextBox();
            ((System.ComponentModel.ISupportInitialize)DgvConceptos).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Britannic Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(90, 40);
            label1.Name = "label1";
            label1.Size = new Size(100, 26);
            label1.TabIndex = 0;
            label1.Text = "Cantidad";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Britannic Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(90, 95);
            label2.Name = "label2";
            label2.Size = new Size(130, 26);
            label2.TabIndex = 1;
            label2.Text = "Descripción";
            label2.Click += label2_Click;
            // 
            // DgvConceptos
            // 
            DgvConceptos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvConceptos.Location = new Point(41, 253);
            DgvConceptos.Name = "DgvConceptos";
            DgvConceptos.RowHeadersWidth = 51;
            DgvConceptos.Size = new Size(916, 376);
            DgvConceptos.TabIndex = 2;
            DgvConceptos.TabStop = false;
            // 
            // btnAgregar
            // 
            btnAgregar.Font = new Font("Britannic Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAgregar.Location = new Point(694, 193);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(94, 34);
            btnAgregar.TabIndex = 3;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // TxtCantidad
            // 
            TxtCantidad.Location = new Point(305, 40);
            TxtCantidad.Name = "TxtCantidad";
            TxtCantidad.Size = new Size(125, 27);
            TxtCantidad.TabIndex = 0;
            // 
            // TxtDescripcion
            // 
            TxtDescripcion.Location = new Point(305, 92);
            TxtDescripcion.Multiline = true;
            TxtDescripcion.Name = "TxtDescripcion";
            TxtDescripcion.Size = new Size(483, 71);
            TxtDescripcion.TabIndex = 1;
            TxtDescripcion.TextChanged += TxtDescripcion_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Britannic Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(90, 193);
            label3.Name = "label3";
            label3.Size = new Size(151, 26);
            label3.TabIndex = 0;
            label3.Text = "Valor Unitario";
            // 
            // TxtValorUnitario
            // 
            TxtValorUnitario.Location = new Point(305, 193);
            TxtValorUnitario.Name = "TxtValorUnitario";
            TxtValorUnitario.Size = new Size(125, 27);
            TxtValorUnitario.TabIndex = 2;
            // 
            // TxtTotal
            // 
            TxtTotal.Location = new Point(305, 646);
            TxtTotal.Name = "TxtTotal";
            TxtTotal.ReadOnly = true;
            TxtTotal.Size = new Size(125, 27);
            TxtTotal.TabIndex = 4;
            TxtTotal.Text = "0.00";
            TxtTotal.TextAlign = HorizontalAlignment.Center;
            TxtTotal.TextChanged += TxtTotal_TextChanged;
            // 
            // BtnEfectivo
            // 
            BtnEfectivo.Font = new Font("Britannic Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnEfectivo.Location = new Point(757, 644);
            BtnEfectivo.Name = "BtnEfectivo";
            BtnEfectivo.Size = new Size(100, 45);
            BtnEfectivo.TabIndex = 5;
            BtnEfectivo.Text = "Efectivo";
            BtnEfectivo.UseVisualStyleBackColor = true;
            BtnEfectivo.Click += BtnEfectivo_Click;
            // 
            // BtnTarjeta
            // 
            BtnTarjeta.Font = new Font("Britannic Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnTarjeta.Location = new Point(863, 644);
            BtnTarjeta.Name = "BtnTarjeta";
            BtnTarjeta.Size = new Size(94, 45);
            BtnTarjeta.TabIndex = 6;
            BtnTarjeta.Text = "Tarjeta";
            BtnTarjeta.UseVisualStyleBackColor = true;
            BtnTarjeta.Click += BtnTarjeta_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Britannic Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(41, 647);
            label4.Name = "label4";
            label4.Size = new Size(96, 26);
            label4.TabIndex = 7;
            label4.Text = "Cortesía";
            label4.Click += label4_Click;
            // 
            // TxtCortesia
            // 
            TxtCortesia.Location = new Point(153, 646);
            TxtCortesia.Name = "TxtCortesia";
            TxtCortesia.Size = new Size(125, 27);
            TxtCortesia.TabIndex = 8;
            TxtCortesia.TextChanged += TxtCortesia_TextChanged;
            // 
            // FrmVenta
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._9nxu2czi;
            ClientSize = new Size(1016, 701);
            Controls.Add(TxtCortesia);
            Controls.Add(label4);
            Controls.Add(BtnTarjeta);
            Controls.Add(BtnEfectivo);
            Controls.Add(TxtTotal);
            Controls.Add(TxtDescripcion);
            Controls.Add(TxtValorUnitario);
            Controls.Add(TxtCantidad);
            Controls.Add(btnAgregar);
            Controls.Add(DgvConceptos);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmVenta";
            Text = "FrmVenta";
            Load += FrmVenta_Load;
            ((System.ComponentModel.ISupportInitialize)DgvConceptos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private DataGridView DgvConceptos;
        private Button btnAgregar;
        private TextBox TxtCantidad;
        private TextBox TxtDescripcion;
        private Label label3;
        private TextBox TxtValorUnitario;
        private TextBox TxtTotal;
        private Button BtnEfectivo;
        private Button BtnTarjeta;
        private Label label4;
        private TextBox TxtCortesia;
    }
}