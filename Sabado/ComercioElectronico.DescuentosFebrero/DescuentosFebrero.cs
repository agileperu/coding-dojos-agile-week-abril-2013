using System.Collections.Generic;
using ComercioElectronico.Contratos;

namespace ComercioElectronico.DescuentosFebrero {
    public class DescuentosFebrero : DescuentosEnero.DescuentosEnero {
        static readonly List<IRegla> Reglas = new List<IRegla> {
            new RedondeoAFavorClientePorLitro()
        };

        public DescuentosFebrero() : base(Reglas) {}
    }
}