namespace IQ_switch_Backend.Models
{
    public class Elemento
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public int Valor { get; set; }
        public int UbicacionId { get; set; }
        public Ubicacion Ubicacion { get; set; }
    }
}
