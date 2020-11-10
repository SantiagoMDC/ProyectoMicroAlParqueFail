using Entity;
using System;
namespace Proyecto.Models
{
    public class RestauranteInputModel
    {
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        
    }

    public class RestauranteViewModel : RestauranteInputModel
    {
        public RestauranteViewModel()
        {

        }
        public RestauranteViewModel(Restaurante restaurante)
        {   
            Codigo = restaurante.Codigo;
            Nombre = restaurante.Nombre;
            Direccion = restaurante.Direccion;
            Telefono = restaurante.Telefono;
        }
    }
}