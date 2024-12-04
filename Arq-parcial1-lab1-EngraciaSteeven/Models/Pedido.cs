using System.ComponentModel.DataAnnotations;

namespace Arq_parcial1_lab1_EngraciaSteeven.Models;

public partial class Pedido
{
    [Key]
    public int IdPedido { get; set; }

    [Required]
    [StringLength(100)]
    public string? Descripcion { get; set; }

    [Required]
    [StringLength(100)]
    public int? IdCliente { get; set; }
}
