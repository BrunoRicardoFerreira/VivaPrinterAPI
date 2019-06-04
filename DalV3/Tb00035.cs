using System;
using System.Collections.Generic;

namespace DalUnlocker
{
    public partial class Tb00035
    {
        public Tb00035()
        {
            Tb01059 = new HashSet<Tb01059>();
            Tb01060 = new HashSet<Tb01060>();
            Tb01062 = new HashSet<Tb01062>();
        }

        public DateTime? Tb00035Dtcad { get; set; }
        public string Tb00035Nome { get; set; }
        public string Tb00035Situacao { get; set; }
        public string Tb00035Senha { get; set; }
        public string Tb00035Senha2 { get; set; }
        public string Tb00035Vend { get; set; }
        public string Tb00035Conscli { get; set; }
        public string Tb00035Email { get; set; }
        public string Tb00035Smtp { get; set; }
        public string Tb00035Usuario { get; set; }
        public string Tb00035Senhaemail { get; set; }
        public int? Tb00035Porta { get; set; }
        public string Tb00035Identificacao { get; set; }
        public string Tb00035Master { get; set; }
        public string Tb00035Tipo { get; set; }
        public string Tb00035Grupo { get; set; }
        public string Tb00035Tecnico { get; set; }
        public string Tb00035Financeiro { get; set; }
        public string Tb00035Gerente { get; set; }
        public string Tb00035Codtec { get; set; }
        public string Tb00035Fone { get; set; }
        public string Tb00035Manager { get; set; }
        public string Tb00035Autemail { get; set; }
        public int? Tb00035Tipoaut { get; set; }
        public int? Tb00035Tipocript { get; set; }
        public string Tb00035Permissaousu { get; set; }
        public string Tb00035Estoque { get; set; }

        public virtual ICollection<Tb01059> Tb01059 { get; set; }
        public virtual ICollection<Tb01060> Tb01060 { get; set; }
        public virtual ICollection<Tb01062> Tb01062 { get; set; }
    }
}