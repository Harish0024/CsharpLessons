﻿using Microsoft.EntityFrameworkCore;
using NWind.Models;

namespace NWind.Models
{
    public class RepositoryOrders
    {
        private NorthwindContext _context;
        public RepositoryOrders(NorthwindContext context)
        {
            _context = context;
        }
        //(from o in _context.Orders select o.OrderId).ToList();
        public List<int> GetAllOrderId()
        {
            try
            {
                List<int> OrdersIDs = (from o in _context.Orders select o.OrderId).ToList(); //_context.Orders.Select(o => o.OrderId).ToList();
                return OrdersIDs;
            }
            catch (Exception ex)
            {
                // Log the exception or handle it as needed
                // For debugging purposes, you can also throw it again here
                throw ex;
            }
        }



        public List<Order> GetAllOrders()
        {
            return _context.Orders.ToList();



        }
        public Order FindOrderById(int ID)
        {
            Order order = _context.Orders.Find(ID);
            return order;
        }
        public List<Order> FindOrderByCustomerID(string customerID)
        {
            List<Order> customerorders = (from o in _context.Orders where o.CustomerId == customerID select o).ToList();
            return customerorders;
        }
        public List<OrderDetail> FindOrderDetailById(int orderID)
        {
            List<OrderDetail> orderDetails = (from od in _context.OrderDetails where od.OrderId == orderID select od).ToList();
            return orderDetails;
        }
        public List<OrderDetail> FindOrderDetailByOrderId(int id)
        {
            //List<OrderDetail> orderDetails = (from od in _context.OrderDetails where od.OrderId == orderID select od).ToList();
            //return orderDetails;
            List<Order>OrdersWithOrderDetails=_context.Orders.Include(d=>d.OrderDetails).ToList();
            Order order = OrdersWithOrderDetails.FirstOrDefault(x => x.OrderId == id);
            
            return order.OrderDetails.ToList();
        }
       
    }
}