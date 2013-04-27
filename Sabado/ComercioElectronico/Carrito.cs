using System.Collections.Generic;
using ComercioElectronico.Contratos;

namespace ComercioElectronico {
    public class Carrito {
        readonly List<Producto> _productos;
        readonly IReglasDescuentos _reglas;

        public Carrito(IReglasDescuentos reglas) {
            _reglas = reglas;
            _productos = new List<Producto>();
        }

        public IEnumerable<Producto> Productos { get { return _productos; } }
        public string EmailCliente { get; set; }

        public void Agregar(Producto producto) {
            _productos.Add(producto);
        }

        public decimal CalcularTotal() {
            decimal total = 0m;
            foreach (var producto in Productos) {
                total += _reglas.AplicarDescuento(producto);
            }

            return total;
        }
    }
}