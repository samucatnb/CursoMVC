using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CursoMVC.Models
{
    public class Produto
    {
        public int Id { get; set; }

        [Display(Name = "Descrição")]
        [Required(ErrorMessage = "Campo Descrição é obrigatório")]
        public string Descricao { get; set; }
        [Range(1,9999, ErrorMessage = "Valor fora da faixa permitida")]
        public decimal Quantidade { get; set; }

        public int CategoriaId { get; set; }
        public Categoria Categoria { get; set; }

        /// <summary>
        /// criei propriedade para devolver codigo e nome da categoria para mostrar em tela
        /// </summary>
        public string Categoria_CodigoNome
        {
            get { return CategoriaId.ToString() + " - " + string.IsNullOrEmpty(Categoria.Descricao)?? ""; }

        }
    }
}
