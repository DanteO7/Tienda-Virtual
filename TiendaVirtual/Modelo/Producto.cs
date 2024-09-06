namespace TiendaVirtual.Modelo
{
    public abstract class Producto
    {
        private string _nombre = null!;
        private string _tipo = null!;
        private double _precio;

        public string Nombre => _nombre;
        public string Tipo => _tipo;
        public double Precio => _precio;
        public Producto(string nombre, string tipo, double precio)
        {
            _nombre = nombre;
            _tipo = tipo;
            _precio = precio;
        }
        public abstract void MostrarDetalles();
    }
}
