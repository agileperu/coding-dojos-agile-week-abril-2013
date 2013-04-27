using System.Collections.Generic;
using System.Linq;
using ComercioElectronico.Contratos;

namespace ComercioElectronico {
    public class ReglasDescuentosBase : IReglasDescuentos {
        protected readonly List<IRegla> _reglas;

        protected ReglasDescuentosBase(IEnumerable<IRegla> reglas) {
            _reglas = reglas.ToList();
        }

        public virtual decimal AplicarDescuento(Producto producto) {
            decimal total = 0;

            var reglaAplicable = obtenerReglaAplicable(producto);
            total += reglaAplicable.Aplicar(producto);

            return total;
        }

        IRegla obtenerReglaAplicable(Producto producto) {
            return _reglas.First(regla => regla.EsAplicable(producto));
        }
    }
}