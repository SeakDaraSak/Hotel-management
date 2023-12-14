using BookingLib.Extensions;

namespace BookingLib;
public class BookingRepo 
{
    private static List<Booking> store = new();
   
    public void Create(Booking entity)
    {
        store.Add(entity.Clone());
    }
    public IQueryable<Booking> GetQueryable()
    {
        return store.AsQueryable();
    }
  
    public bool Update(Booking entity)
    {
        var found = GetQueryable().FirstOrDefault(x => x.Id == entity.Id);
        if (found != null) found.Copy(entity);
        return found != null;
    }
    public bool Delete(string id)
    {
        var found = store.FirstOrDefault(x => x.Id == id);
        return found==null? false : store.Remove(found);
    }
}