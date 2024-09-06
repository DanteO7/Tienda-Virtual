using TiendaVirtual.Modelo;

namespace TiendaVirtual
{
    public class Program
    {
        public static void Main()
        {
            Producto producto1 = new Alimento("Milanesa", "Alimento", 7000);
            Producto producto2 = new Alimento("Jean", "Ropa", 25000);
            Producto producto3 = new Alimento("Celular", "Dispositivo Electronico", 300000);

            List<Producto> productos = new List<Producto>();
            productos.Add(producto1);
            productos.Add(producto2);

            Tienda tiendita = new Tienda("SuperMart", productos);
            tiendita.AgregarProducto(producto3);

            tiendita.ConsultarProducto(producto1);
            tiendita.ConsultarProducto();
        }
    }
}