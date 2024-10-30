namespace WebApplication1.Models;

using static Models.Rooms;

public class Reservation
{
    public int Id { get; set; }
    public DateTime CheckInDate { get; set; }
    public DateTime CheckOutDate { get; set; }
    public int GuestId { get; set; }
    public Guest Guest { get; set; }
    public int RoomId { get; set; }
    public Rooms Room { get; set; }
}
