using Cadastro.Domain.Entities;
using System.Collections.Generic;

namespace Cadastro.Domain.Interfaces
{
    public interface ICategoryRepository
    {
        public Category Get(int id);
        public IEnumerable<Category> GetAll();
    }
}
