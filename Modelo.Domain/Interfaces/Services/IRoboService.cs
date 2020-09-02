using Modelo.Domain.Entities;


namespace Modelo.Domain.Interfaces.Services
{
    public interface IRoboService
    {
        Robo NextMove(Robo robo);
    }
}
