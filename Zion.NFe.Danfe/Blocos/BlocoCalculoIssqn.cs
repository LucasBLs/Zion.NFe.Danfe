﻿using Zion.NFe.Danfe.Elementos;
using Zion.NFe.Danfe.Enumeracoes;
using Zion.NFe.Danfe.Modelo;

namespace Zion.NFe.Danfe.Blocos
{
    internal class BlocoCalculoIssqn : BlocoBase
    {
        public BlocoCalculoIssqn(DanfeViewModel viewModel, Estilo estilo) : base(viewModel, estilo)
        {
            var m = viewModel.CalculoIssqn;

            AdicionarLinhaCampos()
                .ComCampo("INSCRIÇÃO MUNICIPAL", m.InscricaoMunicipal, AlinhamentoHorizontal.Centro)
                .ComCampoNumerico("VALOR TOTAL DOS SERVIÇOS", m.ValorTotalServicos)
                .ComCampoNumerico("BASE DE CÁLCULO DO ISSQN", m.BaseIssqn)
                .ComCampoNumerico("VALOR TOTAL DO ISSQN", m.ValorIssqn)
                .ComLargurasIguais();
        }

        public override PosicaoBloco Posicao => PosicaoBloco.Base;
        public override string Cabecalho => "CÁLCULO DO ISSQN";
    }
}
