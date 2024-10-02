using System.ComponentModel.DataAnnotations;
using PROVA_H1.Validation;

namespace PROVA_H1.Models
{
    public class Convidado
    {
        [Required(ErrorMessage = "Campo obrigatório!")]
        [ValidacaoNome(ErrorMessage = "O nome não possui o comprimento adequado")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Campo obrigatório!")]
        [ValidacaoIdade(ErrorMessage = "Não é menor de 18")]
        public int Idade { get; set; }

        [ValidacaoCarne(ErrorMessage = "Por que levar isso tudo?...")]
        public string Carne { get; set; }

        [ValidacaoBebida(ErrorMessage = "Por que levar isso tudo?...")]
        public string Bebida { get; set; }
    }
}
