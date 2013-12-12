using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Security;

namespace Noctis_CodeDojo.Models
{
    public class Member
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "請輸入Email帳號")]
        [DataType(DataType.EmailAddress)]
        [EmailAddress]
        [Display(Name = "登入信箱")]
        public string Email { get; set; }

        [Display(Name = "會員名稱")]
        public string NickName { get; set; }

        [Display(Name = "登入密碼")]
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "請輸入密碼")]
        public string Password { get; set; }

        [NotMapped]
        [Display(Name = "重複密碼")]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "重複密碼不相同")]
        public string ConfirmPassword { get; set; }

        [Required]
        [Display(Name = "是否啟用")]
        public bool IsEnable { get; set; }

        [Display(Name = "建立者編號")]
        public int? CreateUser { get; set; }

        [Display(Name = "建立時間")]
        public DateTime CreateTime { get; set; }

        [Display(Name = "修改者編號")]
        public int? ModifyUser { get; set; }

        [Display(Name = "修改時間")]
        public Nullable<DateTime> ModifyTime { get; set; }

        [Display(Name = "最後登入時間")]
        public Nullable<DateTime> LastLogOn { get; set; }
    }
}