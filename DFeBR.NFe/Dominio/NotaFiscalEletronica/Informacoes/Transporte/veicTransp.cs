﻿// =============================================================
// DFeBR - Documentos Fiscais Eletrônicos em .Net
// Projeto: DFeBR.NFe
// Autores: 
// Valnei Filho  e-mail: vmarinpietri@yahoo.com.br;
// Marco Polo  e-mail: marcopoloviana@hotmail.com
// Data Criação:26/03/2019
// Todos os direitos reservados
// =============================================================


namespace DFeBR.EmissorNFe.Dominio.NotaFiscalEletronica.Informacoes.Transporte
{
    public class veicTransp
    {
        #region Propriedades

        /// <summary>
        ///     X19 - Placa do Veículo
        /// </summary>
        public string placa { get; set; }

        /// <summary>
        ///     X20 - Sigla da UF
        /// </summary>
        public string UF { get; set; }

        /// <summary>
        ///     X21 - Registro Nacional de Transportador de Carga (ANTT)
        /// </summary>
        public string RNTC { get; set; }

        #endregion
    }
}