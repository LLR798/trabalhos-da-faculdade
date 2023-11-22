using System;
using System.Collections.Generic;

namespace EasyReserve.API.Models;

public partial class Reserve
{
    public int ReserveId { get; set; }

    public int RoomId { get; set; }

    public int ClientId { get; set; }

    public int Number { get; set; }

    public DateTime CheckIn { get; set; }

    public DateTime CheckOut { get; set; }

    public double TotalCost { get; set; }

    public virtual Client Client { get; set; } = null!;

    public virtual Room Room { get; set; } = null!;
}
