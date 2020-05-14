using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ef6CoreForPosgreSQL.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        // from the group model (Entity framework will connect the Primarykey and forign key)
        public Group Group { get; set; }
        public int GroupId { get; set; }
    }
}
