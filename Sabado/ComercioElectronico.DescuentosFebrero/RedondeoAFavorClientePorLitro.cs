using System;
using ComercioElectronico.Contratos;

namespace ComercioElectronico.DescuentosFebrero {
    public class RedondeoAFavorClientePorLitro : IRegla {
        public bool EsAplicable(Producto producto) {
            return producto.Unidad.StartsWith("LITRO");
        }

        public decimal Aplicar(Producto producto) {
            return Math.Round(producto.Precio * producto.Cantidad);
        }
    }
}