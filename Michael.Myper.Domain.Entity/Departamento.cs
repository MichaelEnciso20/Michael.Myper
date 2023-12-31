﻿namespace Michael.Myper.Domain.Entity
{
    public partial class Departamento
    {
        public int Id { get; set; }

        public string? NombreDepartamento { get; set; }

        public virtual ICollection<Provincium> Provincia { get; set; } = new List<Provincium>();

        public virtual ICollection<Trabajadore> Trabajadores { get; set; } = new List<Trabajadore>();
    }

}

