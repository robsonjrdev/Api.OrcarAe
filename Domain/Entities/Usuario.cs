using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Usuario : BaseEntity
    {
        public string? Nome { get; private set; }
        public string? Email { get; private set; }
        public string? Senha { get; private set; }
    }
}
