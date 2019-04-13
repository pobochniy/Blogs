using Atheneum.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Atheneum.Entity
{
    public class ArticleLanguage
    {
        /// <summary>
        /// Идентификатор
        /// </summary>
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public Guid Id { get; set; }

        /// <summary>
        /// Заголовок
        /// </summary>
        [Required]
        public string Title { get; set; }

        /// <summary>
        /// Теги
        /// </summary>
        public string Keywords { get; set; }

        /// <summary>
        /// Описание
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Содержание
        /// </summary>
        public string Content { get; set; }
        
        /// <summary>
        /// Язык
        /// </summary>
        public LangEnum Lang { get; set; }


        public Article Article { get; set; }
    }
}
