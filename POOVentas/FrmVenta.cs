﻿namespace POOVentas
{
    public partial class FrmVenta : Form
    {
        //Borramos la Lista que teníamos antes y le pusimos _venta para que sea privada
        private Ventas _venta;

        public FrmVenta(string tipoVenta)
        {
            InitializeComponent();


            if (tipoVenta == "credito")
            {
                _venta = new VentaCredito();
                this.Text = "Venta de Credito";
                TxtCortesia.Text = "No";

                BtnEfectivo.Visible = false; // esto nos ayudara a ocultar el boton de efectivo cuando la venta sea a credito
                BtnTarjeta.Visible = true; // Con esto nos sera posible realizar el pago con tarjeta
            }
            else if (tipoVenta == "contado")
            {
                _venta = new VentaContado();
                this.Text = "Venta de Contado";
                TxtCortesia.Text = "No";

                BtnEfectivo.Visible= true;//Aqui seria el caso contrario al de venta credito
                BtnTarjeta.Visible= false;//En este caso ocultara el boton de tarjeta cuando sea de contado
            }
            else
            {
                _venta = new VentaCortesia();
                this.Text = "Venta de Cortesia";
                TxtCortesia.Text = "Sí";

                BtnEfectivo.Visible= false;
                BtnTarjeta.Visible = false;
            }



        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            DgvConceptos.DataSource = null;


            ConceptodeVenta concepto = new ConceptodeVenta();
            concepto.Cantidad = Convert.ToInt32(TxtCantidad.Text);
            concepto.Descripcion = TxtDescripcion.Text;
            concepto.ValorUnitario = Convert.ToDecimal(TxtValorUnitario.Text);
            _venta.Conceptos.Add(concepto);

            DgvConceptos.DataSource = _venta.Conceptos;

            //Se agrega Empty, para que se limpie los conceptos que se agregaron
            TxtCantidad.Text = string.Empty;
            TxtDescripcion.Text = string.Empty;
            TxtValorUnitario.Text = string.Empty;
            TxtTotal.Text = _venta.Total.ToString();
            TxtCantidad.Focus();

        }

        private void FrmVenta_Load(object sender, EventArgs e)
        {

        }

        private void BtnEfectivo_Click(object sender, EventArgs e)
        {
            FormaPagoEfectivo efectivo = new FormaPagoEfectivo();
            AplicarPago(efectivo);
        }

        void AplicarPago(IFormaPago formaPago)
        {
            formaPago.Cobrar(_venta.Total);
        }

        private void BtnTarjeta_Click(object sender, EventArgs e)
        {
            FormaPagoTarjeta tarjeta = new FormaPagoTarjeta();
            AplicarPago(tarjeta);
        }



        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void TxtCortesia_TextChanged(object sender, EventArgs e)
        {
            if (TxtCortesia.Text.ToLower() == "sí")
            {
                _venta = new VentaCortesia();
                this.Text = "Venta de Cortesía";

            }
            else
            {
                _venta = new VentaContado(); // O el tipo de venta predeterminado
                this.Text = "Venta de Contado";
            }

        }

        private void TxtDescripcion_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtTotal_TextChanged(object sender, EventArgs e)
        {

        }

        
    }
}
