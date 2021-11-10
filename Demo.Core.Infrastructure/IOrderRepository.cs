using Demo.Core.Enitites;
using System;
using System.Collections.Generic;

namespace Demo.Core.Contract
{
    public interface IOrderRepository
    {

        int SaveOrder();

        List<Order> GetAllOrder();

        Order GetOrder(int id);



    }
}
