using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using static BleToDo0._2.Types.Types;

namespace BleToDo0._2.Models
{
    public class Afazer
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Digite a titulo!")]
        [MinLength(1, ErrorMessage = "O tamanho mínimo da titulo são 1 caracteres.")]
        [StringLength(30, ErrorMessage = "O tamanho máximo são 30 caracteres.")]
        [Display(Name = "Titulo: ")]
        public string AFZ_TITULO { get; set; }

        [Required(ErrorMessage = "Digite a descrição!")]
        [MinLength(5, ErrorMessage = "O tamanho mínimo da descrição são 5 caracteres.")]
        [StringLength(256, ErrorMessage = "O tamanho máximo são 256 caracteres.")]
        [Display(Name = "Descrição: ")]
        public string AFZ_DESCRICAO { get; set; }

        [Display(Name = "Nivel de Prioridade")]
        [Range(1, int.MaxValue, ErrorMessage = "Selecione um Nivel valido!")]
        public Prioridades AFZ_NIVEL { get; set; }


        [Display(Name = "Categoria:")]
        [Range(1, int.MaxValue, ErrorMessage = "Selecione uma Categoria!")]
        public Categorias AFZ_CATEGORIA { get; set; }


        [Display(Name = "Status: ")]
        public bool AFZ_DONE { get; set; }

        [Browsable(false)]
        public string ApplicationUserId { get; set; }
    }
}