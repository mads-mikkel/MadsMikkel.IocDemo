using MadsMikkel.IocDemo.NorthwindEntities;

namespace MadsMikkel.IocDemo.DataAccess
{
    public class RepositoryBase
    {
        protected INorthwindContext northwindContext;

        public RepositoryBase(INorthwindContext northwindContext)
        {
            this.northwindContext = northwindContext;
        }
    }
}