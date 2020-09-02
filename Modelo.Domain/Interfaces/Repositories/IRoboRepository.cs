using Modelo.Domain.Entities;


namespace Modelo.Domain.Interfaces.Repositories
{
    public interface IRoboRepository 
    {
        Robo NextMove(Robo robo);
    }
}
