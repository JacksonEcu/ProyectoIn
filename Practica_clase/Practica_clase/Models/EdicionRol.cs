using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace Practica_clase.Models
{
    public class EdicionRol
    {
        public IdentityRole Rol { get; set; }
        public IEnumerable<IdentityUser> Miembros { get; set; }
        public IEnumerable<IdentityUser> NoMiembros { get; set; }
    }
}