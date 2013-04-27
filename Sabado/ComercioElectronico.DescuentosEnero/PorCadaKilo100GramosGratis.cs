using ComercioElectronico.Contratos;

namespace ComercioElectronico.DescuentosEnero {
    internal class PorCadaKilo100GramosGratis : IRegla {
        public bool EsAplicable(Producto producto) {
            return producto.Unidad.StartsWith("KG") && producto.Cantidad >= 1;
        }

        public decimal Aplicar(Producto producto) {
            return producto.Precio * (producto.Cantidad - producto.Cantidad / 10);
            ;
        }
    }
}