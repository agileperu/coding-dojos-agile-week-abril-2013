using ComercioElectronico.Contratos;

namespace ComercioElectronico.DescuentosEnero {
    internal class Lleva3Paga2 : IRegla {
        public bool EsAplicable(Producto producto) {
            return (producto.Unidad.StartsWith("UNIDAD") && producto.Cantidad % 3 == 0);
        }

        public decimal Aplicar(Producto producto) {
            return producto.Precio * (producto.Cantidad - producto.Cantidad / 3);
        }
    }
}