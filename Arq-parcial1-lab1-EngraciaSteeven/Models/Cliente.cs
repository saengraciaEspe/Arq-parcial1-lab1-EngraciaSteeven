using System;
using System.Collections.Generic;

namespace Arq_parcial1_lab1_EngraciaSteeven.Models;

public partial class Cliente
{
    public int IdCliente { get; set; }

    public string? Nombre { get; set; }

    public string? Email { get; set; }


    public virtual ICollection<Pedido> Pedidos { get; set; } = new List<Pedido>();
}
