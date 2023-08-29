using System.ComponentModel.DataAnnotations;

namespace Projeto.AspNet._03.MVC.CRUD.Models
{
    public class Colab
    {
        //props/atributos que compoem o model
        //neste próximo passo, serão definidas algumas validações via atributos

        [Required(ErrorMessage = "Insira por favor, o seu nome")]
        public string? Nome { get; set; }

        [Range(15, 99, ErrorMessage = "Informe, por favor, uma idade entre 15 e 99")]
        public int Idade { get; set; }

        [RegularExpression(@"\d+(\.\d{1, 2})?", ErrorMessage = ("Valor invalido. Sugestão: insira dessa forma $ ou $.$"))]
        public decimal Salario { get; set; }


        public string? Departamento { get; set; }

        [RegularExpression(@"^[FMO]+$",ErrorMessage = "Selecione ao menos 1 valor.")]
        public Char Genero { get; set; }

    }
}
