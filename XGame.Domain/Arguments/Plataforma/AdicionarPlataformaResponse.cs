using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XGame.Domain.Interface.Arguments;

namespace XGame.Domain.Arguments.Plataforma
{
    public class AdicionarPlataformaResponse : IResponse
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string Mensagem { get; set; }
    }
}
