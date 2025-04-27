namespace POOVentas
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
            btnVentaCredito = new Button();
            btnVentaContado = new Button();
            btnVentaCortesia = new Button();
            SuspendLayout();
            // 
            // btnVentaCredito
            // 
            btnVentaCredito.BackColor = SystemColors.ScrollBar;
            btnVentaCredito.Font = new Font("Verdana", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnVentaCredito.ForeColor = SystemColors.Desktop;
            btnVentaCredito.Location = new Point(74, 276);
            btnVentaCredito.Name = "btnVentaCredito";
            btnVentaCredito.Size = new Size(250, 175);
            btnVentaCredito.TabIndex = 0;
            btnVentaCredito.Text = "VentaCrédito";
            btnVentaCredito.UseVisualStyleBackColor = false;
            btnVentaCredito.Click += btnVentaCredito_Click;
            // 
            // btnVentaContado
            // 
            btnVentaContado.BackColor = SystemColors.ScrollBar;
            btnVentaContado.Font = new Font("Verdana", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnVentaContado.Location = new Point(388, 276);
            btnVentaContado.Name = "btnVentaContado";
            btnVentaContado.Size = new Size(250, 175);
            btnVentaContado.TabIndex = 1;
            btnVentaContado.Text = "VentaContado";
            btnVentaContado.UseVisualStyleBackColor = false;
            btnVentaContado.Click += btnVentaContado_Click;
            // 
            // btnVentaCortesia
            // 
            btnVentaCortesia.BackColor = SystemColors.ScrollBar;
            btnVentaCortesia.Font = new Font("Verdana", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnVentaCortesia.Location = new Point(702, 276);
            btnVentaCortesia.Name = "btnVentaCortesia";
            btnVentaCortesia.Size = new Size(250, 175);
            btnVentaCortesia.TabIndex = 2;
            btnVentaCortesia.Text = "VentaCortesía";
            btnVentaCortesia.UseVisualStyleBackColor = false;
            btnVentaCortesia.Click += btnVentaCortesia_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._9nxu2czi;
            ClientSize = new Size(1100, 674);
            Controls.Add(btnVentaCortesia);
            Controls.Add(btnVentaContado);
            Controls.Add(btnVentaCredito);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnVentaCredito;
        private Button btnVentaContado;
        private Button btnVentaCortesia;
    }
}
