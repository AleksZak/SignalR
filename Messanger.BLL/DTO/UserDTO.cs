using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Messanger.BLL.DTO
{
    public class UserDTO
    {
        public int ID { get; set; }
        public string UserName { get; set; }
        public HashSet<string> UserConnectiionId { get; set; }
        public List<MessageDTO> Messages { get; set; }
    }
}
