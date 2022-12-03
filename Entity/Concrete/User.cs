using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class User
    {
        [Key]
        public int UserID { get; set; }
        [DisplayName("Kullanıcı Ad")]
        public string Username { get; set; }
        [DisplayName("Şifre")]
        public string Password { get; set; }
        [DisplayName("Doğum Tarihi")]
        public DateTime? BirthDate { get; set; }
        public List<Basket> Baskets { get; set; }
        public bool Status { get; set; }


    }
}
