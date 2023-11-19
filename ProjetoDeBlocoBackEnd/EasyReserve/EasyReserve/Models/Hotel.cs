using System;
using System.Collections.Generic;

namespace EasyReserve.Models;

public partial class Hotel
{
    public int HotelId { get; set; }

    public string Name { get; set; } = null!;

    public string Address { get; set; } = null!;

    public string Description { get; set; } = null!;

    public virtual ICollection<Room> Rooms { get; set; } = new List<Room>();
}
