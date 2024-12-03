using System.ComponentModel.DataAnnotations;

namespace Arq_parcial1_lab1_EngraciaSteeven.Models;

public partial class Cliente
{
    [Key]
    public int IdCliente { get; set; }

    [Required]
    [StringLength(100)]
    public string? Nombre { get; set; }

    [Required]
    [StringLength(100)]
    public string? Email { get; set; }


    public virtual ICollection<Pedido> Pedidos { get; set; } = new List<Pedido>();
}
