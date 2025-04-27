namespace POOVentas
{
    public class FormaPagoTarjeta : IFormaPago
    {
        public void Cobrar(decimal total)
        {
            MessageBox.Show("Esperando a la terminal");
            MessageBox.Show("El código fue aprobado con exito");
        }
    }
}
