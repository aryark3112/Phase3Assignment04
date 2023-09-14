using System.ComponentModel.DataAnnotations;

namespace WebAppAssign04.Models
{
    public class Player
    {
        [Required]
        public int UserId { get; set; }
        [Required]

        public string UserName { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string UserPwd { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        public string UserEmail { get; set; }
    }
}
