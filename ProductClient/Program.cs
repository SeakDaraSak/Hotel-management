using BookingClient;

BookingHelper.BaseUrl = "https://localhost:7242";
Console.WriteLine("Product Management");
BookingHelper.MenuBank.MenuSimulate(() => { Console.WriteLine(); });
