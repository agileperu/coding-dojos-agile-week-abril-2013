namespace ComercioElectronico.Contratos {
    public interface IRegla {
        bool EsAplicable(Producto producto);
        decimal Aplicar(Producto producto);
    }
}