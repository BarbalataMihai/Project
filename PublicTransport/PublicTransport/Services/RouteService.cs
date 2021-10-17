using PublicTransport.Repositories;
using PublicTransport.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Linq.Expressions;

namespace PublicTransport.Services
{
    public class RouteService:BaseService
    {
        public RouteService(IRepositoryWrapper repositoryWrapper)
            : base(repositoryWrapper)
        {
        }

        public List<Route> GetRoutes()
        {
            return repositoryWrapper.RouteRepository.FindAll().ToList();
        }

        public List<Route> GetRoutesByCondition(Expression<Func<Route, bool>> expression)
        {
            return repositoryWrapper.RouteRepository.FindByCondition(expression).ToList();
        }

        public void AddRoute(Route route)
        {
            repositoryWrapper.RouteRepository.Create(route);
        }

        public void UpdateRoute(Route route)
        {
            repositoryWrapper.RouteRepository.Update(route);
        }

        public void DeleteRoute(Route route)
        {
            repositoryWrapper.RouteRepository.Delete(route);
        }
    }
}
