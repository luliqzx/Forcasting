using Forcasting.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Dapper;

namespace Forcasting.Repo
{
    public interface IOrderHeaderRepo : IBaseRepo<OrderHeader>
    {

    }
    public class OrderHeaderRepo : BaseRepo<OrderHeader>, IOrderHeaderRepo
    {
        public OrderHeaderRepo(SimpleCRUD.Dialect dbtype) : base(dbtype)
        {
        }
        public OrderHeaderRepo()
        {
        }
    }
}
