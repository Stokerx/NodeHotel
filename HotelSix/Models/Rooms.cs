namespace WebApplication1.Models;

public class Rooms
{
    public int Id { get; set; }
    public string RoomNumber { get; set; }
    public string RoomType { get; set; }
    public decimal PricePerNight { get; set; }
    public List<Reservation> Reservations { get; set; }
}