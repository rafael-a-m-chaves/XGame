using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XGame.Domain.Entites
{
    public class MeuJogo
    {
        public Guid Id { get; set; }
        public JogoPlantaforma JogoPlantaforma { get; set; }
        public bool Desejo { get; set; }
        public DateTime DataDesejo { get; set; }
        public bool Troco { get; set; }
        public bool Vendo { get; set; }

    }
}
