using DataAccessLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Services.OrderItemService
{
    public class OrderItemService : IOrderItemService
    {
        private readonly IOrderItemRepository _orderItemRepository;
        public OrderItemService(IOrderItemRepository orderItemRepository)
        {
            _orderItemRepository = orderItemRepository;
        }
        public IEnumerable<OrderItem> GetAll()
        {
            return _orderItemRepository.GetAll();   
        }

        public IEnumerable<OrderItem> GetAll(string keyName, int key)
        {
            throw new NotImplementedException();
        }
    }
}
