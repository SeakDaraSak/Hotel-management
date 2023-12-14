namespace BookingLib;
public class BookingResponse
{

    public string Id { get; set; } = default!;
    public string fullName { get; set; } = default!;
    public string Gender { get; set; } = default!;
    public string Phone { get; set; } = default;
    public string RoomNo { get; set; } = default;
    public string RoomType { get; set; } = default!;
    public string Date { get; set; } = default!;
}