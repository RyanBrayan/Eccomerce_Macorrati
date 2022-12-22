using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace SiteMVC.Models
{
    public class Categoria
    {
        [Key]
        public int CategoriaId { get; set; }
        [StringLength(100, ErrorMessage ="O tamanho máximo é 100 caracteres")]
        [Required(ErrorMessage ="Informe o nome da categoria")]
        [Display(Name = "Nome da categoria")]
        public string CategoriaNome { get; set; }


        [StringLength(200, ErrorMessage ="O tamanho máximo é 200 caracteres")]
        [Required(ErrorMessage ="Informe a descrição da categoria")]
        [Display(Name = "Descrição")]
        public string Descrição{ get; set; }

        public List<Lanche> Lanches { get; set; }
    }
}