﻿using System.ComponentModel.DataAnnotations;

namespace ProyectoWeb24AM_NET._7.Entities
{
    public class Rol
    {
        [Key]
        public int PkRol {  get; set; }
        [Required]

        public string Nombre { get; set; }
    }
}
