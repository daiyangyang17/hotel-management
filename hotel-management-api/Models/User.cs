using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace hotel_management_api.Models
{
    public class User : BaseModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [Column(TypeName = "nvarchar(10)")]
        public string CitizenIdentification { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Address { get; set; }
        [Column(TypeName = "nvarchar(10)")]
        public string NumberPhone { get; set; }
        public string Email { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        [Column(TypeName = "nvarchar(20)")]
        public string Role { get; set; }
    }
}
