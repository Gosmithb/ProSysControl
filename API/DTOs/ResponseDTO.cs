using API.Models;

namespace API.DTOs
{
    public class ResponseDTO
    {
        public List<UsuarioModel> Data { get; set; }
        public bool Success { get; set; }
        public string? info { get; set; }
    }
}