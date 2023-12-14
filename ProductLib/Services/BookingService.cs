using BookingLib.Extensions;

namespace BookingLib;
public class BookingService 
{
    private BookingRepo _repo = new();
    private bool isInit = false;

    public Result<List<string?>> Initialize()
    {
        if (isInit) return new();
        isInit = !isInit;
        var reqs = new List<BookingCreateReq>()
        {
            new()
            {
                fullName = "Rothana",
                Gender= "Male",
                Phone="0987632",
                RoomNo="3",
                RoomType="DoubleRoom",
                Date="12/04/2024"
            },
            new()
            {
                fullName = "Suna",
                Gender= "Female",
                Phone="09376432",
                RoomNo="14",
                RoomType="OneRoom",
                Date="20/02/2024"
            }
        };
        var result = reqs.Select(x => Create(x).Data).ToList();
        return Result<List<string?>>.Success(result);
    }

    public Result<bool> Exist(string key)
    {
        var result = _repo.GetQueryable().Any(x => x.Id == key || x.fullName.ToLower() == key.ToLower());
        return Result<bool>.Success(result);
    }
    public Result<string?> Create(BookingCreateReq req)
    {
        if (Exist(req.fullName).Data == true) return Result<string?>.Fail($" Name, {req.fullName}, does already exist");
        Booking entity = req.ToEntity();
        _repo.Create(entity);
        return Result<string?>.Success(entity.Id, "Successfully created");
    }
    
    public Result<List<BookingResponse>> ReadAll()
    {
        var result = _repo.GetQueryable().Select(x => x.ToResponse()).ToList();
        return Result<List<BookingResponse>>.Success(result);
    }
    public Result<BookingResponse?> Read(string key)
    {
        var entity = _repo.GetQueryable().FirstOrDefault(x => x.Id == key || x.fullName.ToLower()==key.ToLower());
        return Result<BookingResponse?>.Success(entity?.ToResponse());
    }

    public Result<string?> Update(BookingUpdateReq req)
    {
        var found = _repo.GetQueryable().FirstOrDefault(x => (x.Id == req.Key) || (x.fullName.ToLower() == req.fullName.ToLower()));
        if (found == null) return Result<string?>.Fail($"No Booking with id/fullName, {req.Key}");
        var entity = found.Clone();
        entity.Copy(req);
        var result= _repo.Update(entity);
        return result == true ? Result<string?>.Success(entity.Id, "Successfully updated")
                : Result<string?>.Fail($"Failed to update Booking with id/FullName, {req.Key}");
    }
    public Result<string?> Delete(string key)
    {
        var found = _repo.GetQueryable().FirstOrDefault(x => (x.Id == key) || (x.fullName.ToLower() == key.ToLower()));
        if (found == null) return Result<string?>.Fail($"No Booking with id/FullName, {key}");
        var result= _repo.Delete(found.Id);
        return result == true ? Result<string?>.Success(found.Id, "Successfully deleted")
                : Result<string?>.Fail($"Failed to delete Booking with id/FullName, {key}");
    }
}
