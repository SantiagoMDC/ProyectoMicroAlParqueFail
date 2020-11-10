using System;
using System.Collections.Generic;
using System.Linq;
using Logica;
using Entity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Proyecto.Models;
using Datos;

namespace Proyecto.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RestauranteController : ControllerBase
    {
        private readonly RestauranteService _restauranteService;
        public IConfiguration Configuration { get; }
        public RestauranteController(PersonasContext context)
        {
            
            _restauranteService = new RestauranteService(context);
        }
	private Restaurante MapearRestaurante(RestauranteInputModel restauranteInput)
        {
            var restaurante = new Restaurante
            {
                Codigo = restauranteInput.Codigo,
                Nombre = restauranteInput.Nombre,
                Direccion = restauranteInput.Direccion,
                Telefono = restauranteInput.Telefono
                
            };    
            return restaurante;
        }

       [HttpGet]
        public IEnumerable<RestauranteViewModel> Gets()
        {
            var restaurantes = _restauranteService.ConsultarTodos().Select(p=> new RestauranteViewModel(p));
            return restaurantes;
        }

        [HttpPost]
        public ActionResult<RestauranteViewModel> Post(RestauranteInputModel restauranteInput)
        {
            Restaurante Restaurante = MapearRestaurante(restauranteInput);
            var response = _restauranteService.Guardar(Restaurante);
            if (response.Error) 
            {
                return BadRequest(response.Mensaje);
            }
            return Ok(response.Restaurante);
        }

        

        
    }
}