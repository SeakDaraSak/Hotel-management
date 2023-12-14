using MenuLib;
using BookingLib;
using RestClientLib;

namespace BookingClient;
public static class BookingHelper
{
    public static string BaseUrl { get; set; } = "https://localhost:5001";

    public static MenuBank MenuBank { get; set; } = new MenuBank()
    {
        Title = "Booking",
        Menus = new List<Menu>()
        {
            new Menu(){ Text= "Viewing", Action=ViewingProducts},
            new Menu(){ Text= "Creating", Action=CreatingBookings},
            new Menu(){ Text= "Updating", Action=UpdatingProducts},
            new Menu(){ Text= "Deleting", Action=DeletingProducts},
            new Menu(){ Text= "Exiting", Action = ExitingProgram}
        }
    };
    public static void ExitingProgram()
        {
            Console.WriteLine("\n[Exiting Program]");
            Environment.Exit(0);
        }
    private static void DeletingProducts()
    {
        Task.Run(async () =>
        {
            RestClient<Booking> restClient = new(BaseUrl);
            Console.WriteLine("\n[Deleting Booking]");
            while (true)
            {
                Console.Write("Product Id/Phone: ");
                var key = Console.ReadLine() ?? "";
                var endpoint = $"api/Bookings/{key}";
                var result = await restClient.DeleteAsync<Result<string>>(endpoint);
                if (result!.Data != null)
                {
                    Console.WriteLine($"Successfully delete the Booking with id/Phone, {key}");
                }
                else
                {
                    Console.WriteLine($"Failed to delete a product with id/Phone, {key}");
                }

                if (WaitForEscPressed("ESC to stop or any key for more deleting ..."))
                {
                    break;
                }
            }
        }).Wait();
    }
    private static void UpdatingProducts()
    {
        Task.Run(async () =>
        {
            RestClient<Booking> restClient = new(BaseUrl);
            Console.WriteLine("\n[Updating Bookings]");
            while (true)
            {
                Console.Write("Product Id/FullName(required): ");
                var key = Console.ReadLine() ?? "";
                var endpoint = "api/Bookings";
                Console.Write("New FullName : ");
                var name = Console.ReadLine();

                Console.Write("New Gender : ");
                var gender = Console.ReadLine();

                Console.Write("New Phone : ");
                var phone = Console.ReadLine();

                Console.Write("New RoomNo : ");
                var roomno = Console.ReadLine();

                Console.Write("New RoomType : ");
                var roomtype = Console.ReadLine();

                Console.Write("New Date : ");
                var date = Console.ReadLine();
                var result = await restClient.PutAsync<BookingUpdateReq, Result<string>>(endpoint, new BookingUpdateReq()
                {
                    Key = key,
                    fullName = name,
                    Gender=gender,
                    Phone=phone,
                    RoomNo=roomno,
                    RoomType=roomtype,
                    Date=date,
                });

                if (result!.Data !=null)
                {
                    Console.WriteLine($"Successfully update the product with id/FullName, {key}");
                }
                else
                {
                    Console.WriteLine($"Failed to update the product with id/FullName, {key}");
                }

                Console.WriteLine();
                if (WaitForEscPressed("ESC to stop or any key for more updating...")) break;
            }
        }).Wait();
    }
    private static bool WaitForEscPressed(string text)
    { 
        Console.Write(text);;
        ConsoleKeyInfo keyInfo = Console.ReadKey(true);
        Console.WriteLine(keyInfo.KeyChar);
        return keyInfo.Key == ConsoleKey.Escape;
    }
    private static void CreatingBookings()
    {
        Task.Run(async () =>
        {
            RestClient<Booking> restClient = new(BaseUrl);
            Console.WriteLine("\n[Creating Bookings]");
            var endpoint = "api/Bookings";
            while (true)
            {
                var req = GetCreateBooking();
                if (req != null)
                {
                    var result = await restClient.PostAsync<BookingCreateReq, Result<string>>(endpoint, req);
                    var id = result!.Data;
                    if (!string.IsNullOrEmpty(id))
                        Console.WriteLine($"Successfully created a new product with id, {id}");
                    else
                        Console.WriteLine($"Failed to create a new product FUllName, {req.fullName}");
                }

                Console.WriteLine();
                if (WaitForEscPressed("ESC to stop or any key for more creating...")) break;
            }
        }).Wait();
    }
    static BookingCreateReq? GetCreateBooking()
    {
        Console.Write("Product(fullName/Gender/Phone/RoomNo/RoomType/Date): ");
        string data = Console.ReadLine() ?? "";
        var dataParts = data.Split("/");
        if (dataParts.Length < 6)
        {
            Console.WriteLine("Invalid create Boooking is data");
            return null;
        }
        var name = dataParts[0].Trim();
        var gender = dataParts[1].Trim();
        var phone = dataParts[2].Trim();
        var roomno = dataParts[3].Trim();
        var roomtype = dataParts[4].Trim();
        var datetime = dataParts[5].Trim();
        return new BookingCreateReq() { fullName=name , Gender =gender, Phone=phone ,RoomNo=roomno,RoomType=roomtype,Date=datetime};

    }
    private static  void ViewingProducts()
    {
        Task.Run(async () =>
        {
            RestClient<Booking> restClient = new(BaseUrl);
            Console.WriteLine("\n[Viewing Bookings]");
            var endpoint = "api/Bookings";
            var result = await restClient.GetAsync<Result<List<BookingResponse>>>(endpoint) ?? new();
            var all = result!.Data??new();
            var count = all.Count;
            Console.WriteLine($"Bookings: {count}");
            if (count == 0) return;

            Console.WriteLine($" {"Id",-10} {"fullName",-30} {"Gender",-36} {"Phone",-10} {"RoomNo",-30} {"RoomType",-30} {"Date",-30}");
/*            Console.WriteLine(new string('=', 36 + 1 + 10 + 1 + 30 + 1 + 36 + 1 + 10 + 1 + 30 +1+30+1+30+1+30));*/
            foreach (var Bk in all)
            {
                Console.WriteLine($"{Bk.Id,-36} {Bk.fullName,-10} {Bk.Gender,-30} {Bk.Phone,-30} {Bk.RoomNo,-30} {Bk.RoomType,-30} {Bk.Date,-30}");
            }
        }).Wait();
    }
}
