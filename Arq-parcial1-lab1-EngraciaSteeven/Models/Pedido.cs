using System;
using System.Collections.Generic;

namespace Arq_parcial1_lab1_EngraciaSteeven.Models;

public partial class Pedido
{
    public int IdPedido { get; set; }

    public string? Descripcion { get; set; }

    public int? IdCliente { get; set; }

    public virtual Cliente? IdClienteNavigation { get; set; }
}
