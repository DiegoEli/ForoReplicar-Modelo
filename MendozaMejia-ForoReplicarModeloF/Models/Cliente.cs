using System;
using System.Collections.Generic;

namespace MendozaMejia_ForoReplicarModeloF.Models;

public partial class Cliente
{
    public int ClienteId { get; set; }

    public string? Nombre { get; set; }

    public string? Apellido { get; set; }

    public string? Direccion { get; set; }

    public string? Telefono { get; set; }

    public DateTime? FechaNacimiento { get; set; }

    public bool? Estado { get; set; }
}
