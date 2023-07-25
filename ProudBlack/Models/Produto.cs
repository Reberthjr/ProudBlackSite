using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProudBlack.Models
{
    [Table("Produto")]
    public class Produto
    {
        [Key]
        public int ProdutoId { get; set; }

        [Required(ErrorMessage = "O nome do Produto deve ser informado")]
        [Display(Name = "Nome do Produto")]
        [MinLength(5, ErrorMessage = "O {0} deve ter no mínimo {1} caracteres")]
        [MaxLength(30, ErrorMessage = "{0}não pode exceder {1} caracteres")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "A descrição do Produto deve ser informada")]
        [Display(Name = "Descrição do Produto")]
        [MinLength(12, ErrorMessage = "Descrição deve ter no mínimo {1} caracteres")]
        [MaxLength(200, ErrorMessage = "Descrição pode exceder {1} caracteres")]
        public string DescricaoCurta { get; set; }

        [Required(ErrorMessage = "O descrição detalhada do Produto deve ser informada")]
        [Display(Name = "Descrição detalhada do Produto")]
        [MinLength(20, ErrorMessage = "Descrição detalhada deve ter no mínimo {1} caracteres")]
        [MaxLength(200, ErrorMessage = "Descrição detalhada pode exceder {1} caracteres")]
        public string DescricaoDetalhada { get; set; }

        [Required(ErrorMessage = "Informe o preço do Produto")]
        [Display(Name = "Preço")]
        [Column(TypeName = "decimal(10,2)")]
        [Range(1, 999.99, ErrorMessage = "O preço deve estar entre 1 e 999,99")]
        public decimal Preco { get; set; }

        [Display(Name = "Caminho Imagem 1")]
        [StringLength(200, ErrorMessage = "O {0} deve ter no máximo {1} caracteres")]
        public string ImagemUrl { get; set; }
        [Display(Name = "Caminho Imagem 2 ")]
        [StringLength(200, ErrorMessage = "O {0} deve ter no máximo {1} caracteres")]
        public string ImagemUrl2 { get; set; }
        [Display(Name = "Caminho Imagem 3")]
        [StringLength(200, ErrorMessage = "O {0} deve ter no máximo {1} caracteres")]
        public string ImagemUrl3 { get; set; }
        [Display(Name = "Caminho Imagem 4")]
        [StringLength(200, ErrorMessage = "O {0} deve ter no máximo {1} caracteres")]
        public string ImagemUrl4 { get; set; }

        [Display(Name = "Caminho Imagem Miniatura")]
        [StringLength(200, ErrorMessage = "O {0} deve ter no máximo {1} caracteres")]
        public string ImagemThumbnailUrl { get; set; }

        [Display(Name = "Promoção")]
        public bool EmPromocao { get; set; }

        [Display(Name = "Estoque")]
        public bool EmEstoque { get; set; }
        [Display(Name = "Categoria")]
        public int CategoriaID { get; set; } 
        public virtual Categoria Categoria { get; set; }
    }
}
