using System.Collections.Generic;
using DependencyInjectionTester.Models;

namespace DependencyInjectionTester.Interfaces
{
    public interface ICharacterRepository
    {
        IEnumerable<Character> ListAll();
        void Add(Character character);
    }
}