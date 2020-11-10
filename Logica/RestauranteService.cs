using System;
using Datos;
using Entity;
using System.Collections.Generic;
using System.Linq;

namespace Logica
{
    public class RestauranteService
    {
        private readonly PersonasContext _context;
        

        public RestauranteService(PersonasContext context)
        {
            _context = context;
        }

        public class GuardarRestauranteResponse
        {
            public GuardarRestauranteResponse(Restaurante restaurante)
            {
                Error = false;
                Restaurante = restaurante;
            }

            public GuardarRestauranteResponse(string mensaje)
            {
                Error = true;
                Mensaje = mensaje;
            }

            public bool Error { get; set; }
            public string Mensaje { get; set; }
            public Restaurante Restaurante { get; set; }
        }

        public GuardarRestauranteResponse Guardar(Restaurante restaurante)
        {
            try
            {
                _context.restaurantes.Add(restaurante);
                
                _context.SaveChanges();
                return new GuardarRestauranteResponse(restaurante);
               
            }
            catch (Exception e)
            {
                return new GuardarRestauranteResponse($"Error de la Aplicacion: {e.Message}");
            }
            
        }

        public List<Restaurante> ConsultarTodos()
        {
            
            List<Restaurante> restaurantes = _context.restaurantes.ToList();
           
            return restaurantes;
        }

    }
}