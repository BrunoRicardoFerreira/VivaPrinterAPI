using System;
using System.Collections.Generic;

namespace DalUnlocker
{
    public partial class NddEquipamento
    {
        public int Id { get; set; }
        public string Contrato { get; set; }
        public string NomeCliente { get; set; }
        public string Serial { get; set; }
        public string NomeEquipamento { get; set; }
        public int? Site { get; set; }
        public int? Depto { get; set; }
        public string Modelo { get; set; }
        public string Fabricante { get; set; }
        public string Cnpj { get; set; }
        public string Coddepto { get; set; }
        public string Codsite { get; set; }
    }
}