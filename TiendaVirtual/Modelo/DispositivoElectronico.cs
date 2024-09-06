namespace TiendaVirtual.Modelo
{
    public class DispositivoElectronico : Producto
    {
        public DispositivoElectronico(string nombre, string tipo, double precio) : base(nombre, tipo, precio) { }
        public override void MostrarDetalles()
        {
            Console.WriteLine($"Detalles del producto:");
            Console.WriteLine($"Nombre: {Nombre}, Tipo De Producto: {Tipo}, Precio: {Precio:C}\n");
        }
    }
}