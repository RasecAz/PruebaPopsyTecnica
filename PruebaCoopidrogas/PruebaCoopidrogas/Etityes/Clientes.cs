namespace PruebaCoopidrogas.Etityes
{
    public class Clientes
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = null!;
        public string? NombrApellido1 { get; set; }
        public string? NombrApellido2 { get; set; }
        public string? Telefono { get; set; }
        public string? Fecha_creacion { get; set; }
    }
}
