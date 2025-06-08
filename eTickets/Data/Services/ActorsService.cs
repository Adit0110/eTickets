/*using eTickets.Data.Base;
using eTickets.Models;
using Microsoft.EntityFrameworkCore;

namespace eTickets.Data.Services
{
    public class ActorsService : EntityBaseRepository<Actor>, IActorsService
    {

        public ActorsService(AppDbContext context) : base(context) { }

        //public ActorsService(AppDbContext context) : base(context) { }
        /*private readonly AppDbContext _context;

        public ActorsService(AppDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task<Actor> UpdateAsync(int id, Actor newActor)
        {
            var existingActor = await _context.Actors.FirstOrDefaultAsync(a => a.Id == id);
            if (existingActor == null) return null;

            existingActor.FullName = newActor.FullName;
            existingActor.ProfilePictureURL = newActor.ProfilePictureURL;
            existingActor.Bio = newActor.Bio;

            await _context.SaveChangesAsync();
            return existingActor;
        }*/
//}
//}*/


using eTickets.Data.Base;
using eTickets.Models;

namespace eTickets.Data.Services
{
    public class ActorsService : EntityBaseRepository<Actor>, IActorsService
    {
        public ActorsService(AppDbContext context) : base(context) { }
    }
}