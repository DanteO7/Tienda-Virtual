namespace TiendaVirtual.Modelo
{
    public class Tienda
    {
        private string _nombre;
        private List<Producto> _productos = new List<Producto>();

        public string Nombre => _nombre;
        public List<Producto> Productos => _productos;

        public Tienda(string nombre, List<Producto> productos)
        {
            _nombre = nombre;
            if(productos.Count <= 0) {
                throw new ArgumentException("La lista de productos no puede estar vacía");
            }
            _productos = productos;
        }
        public Tienda(string nombre, Producto producto)
        {
            _nombre = nombre;
            AgregarProducto(producto);            
        }
        public void AgregarProducto(Producto producto)
        {
            if (string.IsNullOrEmpty(producto.Nombre))
            {
                throw new ArgumentException("El nombre del producto no puede estar vacía");
            }
            _productos.Add(producto);
        }
        public void ConsultarProducto(Producto producto)
        {
            producto.MostrarDetalles();
        }
        public void ConsultarProducto()
        {
            foreach(Producto producto in _productos)
            {
                producto.MostrarDetalles();
            }
        }
    }
}
