using System;

namespace AlasComercialERP.Mapeamento
{
    public class Usuario
    {
        public int IdUsuario { get; set; }
        public string NomeUsuario { get; set; }
        public string NomeExibicao { get; set; }
        public string SenhaHash { get; set; }
        public string SenhaSalt { get; set; }
        public bool Ativo { get; set; }
        public DateTime CriadoEm { get; set; }
    }
}
