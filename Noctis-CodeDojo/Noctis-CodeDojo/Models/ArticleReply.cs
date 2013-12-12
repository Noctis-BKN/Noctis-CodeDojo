using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Noctis_CodeDojo.Models
{
    public class ArticleReply
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "暱稱")]
        public string NickName { get; set; }

        [Display(Name = "評論內容")]
        public string Comment { get; set; }

    }
}