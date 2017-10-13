using System.Collections.Generic;
using System.Linq;
using DependencyInjectionTester.Interfaces;

namespace DependencyInjectionTester.Models
{
    public class CharacterRepository : ICharacterRepository
    {
        private readonly ApplicationDbContext _dbContext;

        public CharacterRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IEnumerable<Character> ListAll()
        {
            return _dbContext.Characters.AsEnumerable();
        }

        public void Add(Character character)
        {
            try
            {


            _dbContext.Characters.Add(character);
            _dbContext.SaveChanges();
            }
            catch (System.Exception e)
            {

                throw;
            }
        }
    }
}