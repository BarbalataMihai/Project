using PublicTransport.Models;
using PublicTransport.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace PublicTransport.Services
{
    public class BusService : BaseService
    {
        public BusService(IRepositoryWrapper repositoryWrapper)
            : base(repositoryWrapper)
        {
        }
        public List<Bus> GetBuses()
        {
            return repositoryWrapper.BusRepository.FindAll().ToList();
        }

        public List<Bus> GetBusesByCondition(Expression<Func<Bus, bool>> expression)
        {
            return repositoryWrapper.BusRepository.FindByCondition(expression).ToList();
        }

        public void AddBus(Bus bus)
        {
            repositoryWrapper.BusRepository.Create(bus);
        }

        public void UpdateBus(Bus bus)
        {
            repositoryWrapper.BusRepository.Update(bus);
        }

        public void DeleteBus(Bus bus)
        {
            repositoryWrapper.BusRepository.Delete(bus);
        }
    }
}
