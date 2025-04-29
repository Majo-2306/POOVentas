namespace POOVentas
{
    internal class VentaCortesia : Ventas
    {
        public override decimal CalcularTotal()
        {
            return 0; // Cuando sea venta de cortesia, no tienes que pagar nada.
        }
    }
}
