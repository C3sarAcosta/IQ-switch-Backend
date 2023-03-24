namespace IQ_switch_Backend.Models
{
    public class Ubicacion
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public int DispositivoId { get; set; }
        public Dispositivo Dispositivo { get; set; }
        public List<Elemento> Elementos { get; set; }
    }
}
