using System.ComponentModel.DataAnnotations;

namespace FilmesApi.Data.Dtos;
public class UpdateFilmeDto
{
    [Required(ErrorMessage = "O título do filme é obrigatório")]
    public string Titulo { get; set; }
    [Required(ErrorMessage = "O genêro do filme é obrigatório")]
    [StringLength(50, ErrorMessage = "O tamanho do gênero não pode exceder 50 caracteres")]
    public string Genero { get; set; }
    [Required]
    [Range(70, 360, ErrorMessage = "A duração de ter entre 70 e 360 minutos")]
    public int Duracao { get; set; }
}