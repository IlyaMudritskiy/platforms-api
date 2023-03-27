using System.Collections.Generic;
using PlatformService.Models;

namespace PlatformService.Data
{
    public class PlatformRepo : IPlatformRepo
    {
        private readonly AppDbContext _context;

        public PlatformRepo(AppDbContext context)
        {
            _context = context;
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }

        public IEnumerable<Platform> GetAllPlatforms()
        {
            throw new System.NotImplementedException();
        }

        public Platform GetPlatformById(int id)
        {
            throw new System.NotImplementedException();
        }
        public void CreatePlatform(Platform plat)
        {
            throw new System.NotImplementedException();
        }
    }
}