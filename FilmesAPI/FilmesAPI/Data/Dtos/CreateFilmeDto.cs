using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FilmesAPI.Data.Dtos
{
    public class CreateFilmeDto
    {
        [Required(ErrorMessage = "O campo Titulo é obrigatório")]
        public string Titulo { get; set; }
        [Required(ErrorMessage = "O campo Diretor é obrigatório")]
        public string Diretor { get; set; }
        [StringLength(30, ErrorMessage = "O Gênero não pode passar de 30 caracteres")]
        public string Genero { get; set; }
        [Range(1, 600, ErrorMessage = "A Duracao deve ter no mínimo 1 e no máximo 600 minutos")]
        public int Duracao { get; set; }
    }
}
