namespace BookingLib;

public class BookingUpdateReq
{
    public string Key { get; set; } = default!;
    public string? fullName { get; set; } = default;
    public string Gender { get; set; } = default!;
    public string Phone { get; set; } = default;
    public string RoomNo { get; set; } = default;
    public string RoomType { get; set; } = default!;
    public string Date { get; set; } = default!;
}