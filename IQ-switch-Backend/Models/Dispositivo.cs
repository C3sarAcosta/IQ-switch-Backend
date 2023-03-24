using Microsoft.AspNetCore.Identity;

namespace IQ_switch_Backend.Models
{
    public class Dispositivo
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string Ip { get; set; }
        public string usuario { get; set; }
        public string password { get; set; }
        public string UsuarioId { get; set; }
        public IdentityUser Usuario { get; set; }
        public List<Ubicacion> Ubicaciones { get; set; }
    }
}
