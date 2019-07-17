using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    class Order
    {
        public enum OrderStatus
        {
            Initialized,
            Approved,
            Cancelled,
            Completed

        }

        private int orderNumber;
        private OrderStatus status;

        public Order()
        {
            orderNumber = 0;
            status = 0;
        }
    }
}
