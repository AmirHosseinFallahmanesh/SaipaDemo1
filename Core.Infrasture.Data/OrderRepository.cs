using Demo.Core.Contract;
using Demo.Core.Enitites;
using System;
using System.Collections.Generic;

namespace Core.Infrasture.Data
{
    public class OrderRepository : IOrderRepository
    {
        public List<Order> GetAllOrder()
        {
            return null;
        }

        public Order GetOrder(int id)
        {
            return null;
        }

        public int SaveOrder()
        {
            return 0;
        }
    }
}
