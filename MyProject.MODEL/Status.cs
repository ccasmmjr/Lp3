using System;
using System.Collections.Generic;

namespace Myprojec.MODEL;

public partial class Status
{
    Status() { }
    public Status(string Status1) { this.Status1 = Status1; }

    public int Id { get; set; }

    public string? Status1 { get; set; }

    public virtual ICollection<Projeto> Projetos { get; set; } = new List<Projeto>();
}
