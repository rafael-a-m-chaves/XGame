using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XGame.Domain.Entites
{
    public class JogoPlantaforma
    {
        public Guid Id { get; set; }
        public Jogo Jogo { get; set; }
        public Plantaforma Plantaforma { get; set; }
        public DateTime DataLancamento { get; set; }
    }
}
