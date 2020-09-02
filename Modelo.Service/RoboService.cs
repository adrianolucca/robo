using Modelo.Domain.Entities;
using Modelo.Domain.Interfaces.Repositories;
using Modelo.Domain.Interfaces.Services;


namespace Modelo.Service
{
    public class RoboService:  IRoboService
    {
        private readonly IRoboRepository _roboRepository;

        public RoboService(IRoboRepository roboRepository) 
        {
            _roboRepository = roboRepository;
        }

       public Robo  NextMove(Robo robo)
        {
           return  _roboRepository.NextMove(robo);
        }

    }
}
