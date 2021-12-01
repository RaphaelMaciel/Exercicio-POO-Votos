using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VotosPorEleitores
{
    public class Voto
    {
        public readonly double Valido;
        public readonly double Branco;
        public readonly double Nulo;
        public readonly double TotalDeEleitores;

        public Voto()
        {
            Valido = 800;
            Branco = 150;
            Nulo = 50;
            TotalDeEleitores = new Eleitor().totalDeEleitores;
        }


        public Voto(int valido, int branco, int nulo, int totalDeEleitores)
        {
            Valido = valido;
            Branco = branco;
            Nulo = nulo;
            TotalDeEleitores = new Eleitor(totalDeEleitores).totalDeEleitores;
        }
        public double PorcentagemVotoValido() => (Valido / TotalDeEleitores) * 100;

        public double PorcentagemVotoBranco() => (Branco / TotalDeEleitores) * 100;

        public double PorcentagemVotoNulo() => (Nulo / TotalDeEleitores) * 100;

        public double PorcentagemProporcional() => (((Nulo / 12) * 3) + Nulo) / (((TotalDeEleitores / 12) * 3) + TotalDeEleitores)*100;

    }
}
