using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Atheneum.Entity
{
    public class Article
    {
        /// <summary>
        /// Идентификатор
        /// </summary>
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public int Id { get; set; }

        /// <summary>
        /// Язык
        /// </summary>
        [Required]
        public int Alias { get; set; }


        public ICollection<ArticleLanguage> ArticleLanguage { get; set; }
    }
}
