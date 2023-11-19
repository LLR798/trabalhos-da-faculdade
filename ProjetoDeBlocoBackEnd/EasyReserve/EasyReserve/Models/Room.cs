using System;
using System.Collections.Generic;

namespace EasyReserve.Models;

public partial class Room
{
    public int RoomId { get; set; }

    public int HotelId { get; set; }

    public int Number { get; set; }

    public string Type { get; set; } = null!;

    public string Description { get; set; } = null!;

    public double Price { get; set; }

    public bool IsReserved { get; set; }

    public virtual Hotel Hotel { get; set; } = null!;

    public virtual ICollection<Reserve> Reserves { get; set; } = new List<Reserve>();
}
