using CursoCubits.Models;
using Microsoft.AspNetCore.Mvc;
using ObtenerUsuario;

namespace CursoCubits.Controllers
{
    [Route("users")]
    public class UsersController : Controller
    {
        [Route("getList")]
        public async Task<IActionResult> GetList()
        {
            var servicio = new ServiceClient();
            var userService = await servicio.GetUserAsync(1);
            var usuario = new UserModel
            {
                Nombre = userService.Nombre,
                Apellido = userService.Apellido
            };

            return View("Indes", usuario);
        }
    }
}