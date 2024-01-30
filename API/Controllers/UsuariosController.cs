using System.Data.Common;
using API.Data;
using API.DTOs;
using API.Models;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuariosController : Controller
    {
        private readonly AppDbContext _context;
        private ResponseDTO _response;

        public UsuariosController(AppDbContext context)
        {
            _context = context;
            _response = new ResponseDTO();
        }

        [HttpGet]
        public ResponseDTO GetUsuarios()
        {
            try
            {
                _response.Data = _context.Usuarios.ToList();
            }
            catch (Exception ex)
            {
                _response.info = ex.ToString();
            }

            return _response;
        }

    }
}