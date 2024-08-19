
using System.ComponentModel.DataAnnotations;

namespace api_tarefa.Dtos
{
    public class CarroDTO
    {
        [Required]
        [MinLength(5)]
        public string Marca { get; set; }

        [Required]
        [MinLength(4)]
        public string Modelo { get; set; }

        public int AnoFabricacao { get; set; }

        public int AnoModelo { get; set; }

        public string Placa { get; set; }


    }
}
