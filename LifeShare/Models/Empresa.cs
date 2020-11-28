using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace LifeShare.Models
{
    [Table("Tb_Empresa")]
    public class Empresa
    {

        [Column("Id"),HiddenInput]
        public int EmpresaId { get; set; }
        [MaxLength(80)]
        public string Nome { get; set; }
        [Column("Dt_Entrada"), DataType(DataType.Date), Display(Name = "Data de Entrada")]
        public DateTime DataEntrada{ get; set; }
        public Status Status { get; set; }

    }
}
