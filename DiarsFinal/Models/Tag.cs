using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DiarsFinal.Models
{
    public class Tag
    {
        public int Id { get; set; }
        public string Nombre { get; set; }

        public List <DetallePostTags> DetallePostTags { get; set; }
    }
}
