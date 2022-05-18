using parkareSolution.Domain;
using parkareSolution.Domain.Interfaces;

namespace parkareSolution.Application
{
    public class Main
    {
        private readonly IRepository<GenericClass> _repository;
        public Main(IRepository<GenericClass> repository)
        {
            _repository = repository;
        }

        public void Save(GenericClass[] genericClasses)
        {
            foreach (GenericClass item in genericClasses)
            {
                _repository.Save(item);
            }
        }
    }
}
