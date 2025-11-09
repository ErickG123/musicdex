using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace musicdex.Models
{
    [Table("musica")]
    public class Musica
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Required]
        [MaxLength(200)]
        [Column("titulo")]
        public string Titulo { get; set; } = null!;

        [MaxLength(150)]
        [Column("artista")]
        public string Artista { get; set; }

        [MaxLength(150)]
        [Column("album")]
        public string Album { get; set; }

        [Column("duracao_segundos")]
        public int DuracaoSegundos { get; set; }

        [Column("lancamento")]
        public DateTime Lancamento { get; set; }

        [Column("descricao")]
        public string Descricao { get; set; }

        [Column("imagem_base64", TypeName = "longtext")]
        public string ImagemBase64 { get; set; }

        [Column("genero_id")]
        public int GeneroId { get; set; }

        [ForeignKey(nameof(GeneroId))]
        public virtual Genero Genero { get; set; }

        [Column("criado_em")]
        public DateTime CriadoEm { get; set; }

        [Column("atualizado_em")]
        public DateTime AtualizadoEm { get; set; }
    }
}
