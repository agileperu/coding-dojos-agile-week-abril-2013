using System.Collections.Generic;
using ComercioElectronico.Contratos;

namespace ComercioElectronico.DescuentosEnero {
    public class DescuentosEnero : ReglasDescuentosBase {
        static readonly List<IRegla> Reglas = new List<IRegla> {
            new Lleva3Paga2(), 
            new PorCadaKilo100GramosGratis()
        };

        public DescuentosEnero()
            : base(Reglas) {}

        protected DescuentosEnero(IEnumerable<IRegla> reglas) : this() {
            _reglas.AddRange(reglas);
        }
    }
}