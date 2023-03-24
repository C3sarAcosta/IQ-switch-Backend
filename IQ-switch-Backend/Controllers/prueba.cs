using Microsoft.AspNetCore.Mvc;
using Renci.SshNet;
using System.Device.Gpio;

namespace IQ_switch_Backend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class prueba : Controller
    {

        [HttpPost("on")]
        public IActionResult TurnOn()
        {
            // Conexión a la Raspberry Pi
            using (var ssh = new SshClient("172.16.0.194", "cesar", "nada123"))
            {
                ssh.Connect();

                // Encender el LED
                ssh.RunCommand("echo 1 > /sys/class/gpio/gpio17/value");
            }

            return Ok();
        }

        [HttpPost("off")]
        public IActionResult TurnOff()
        {
            // Conexión a la Raspberry Pi
            using (var ssh = new SshClient("172.16.0.194", "cesar", "nada123"))
            {
                ssh.Connect();

                // Apagar el LED
                ssh.RunCommand("echo 0 > /sys/class/gpio/gpio17/value");
            }

            return Ok();
        }
    }
}
