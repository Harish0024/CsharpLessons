
using Microsoft.AspNetCore.Mvc;
using NWind.Models;





namespace NWindMVC.Controllers
{
    public class OrderController : Controller
    {
        private RepositoryOrders _repositoryOrders;
        public OrderController(RepositoryOrders repository)
        {
            _repositoryOrders = repository;
        }
        // GET: OrderController
        public IActionResult Index()
        {
            //List<int> OrdersIds = _repositoryOrders.GetAllOrderId();
            //                                   //ViewBag.OrderIds = new SelectList(OrdersIds);
            //return View(OrdersIds);
            List<int> OrdersIds = _repositoryOrders.GetAllOrderId();
            OrderIdViewModel idsViewModel = new OrderIdViewModel(OrdersIds);
            return View(idsViewModel);
        }

        // GET: OrderController/Details/5
        //[HttpGet]
        public ActionResult Details(int id)
        {
            Order order = _repositoryOrders.FindOrderById(id);
            List<OrderDetail> detail = _repositoryOrders.FindOrderDetailByOrderId(id);
            ViewData["OrderDetail"] = detail;
            return View(order);
        }
    }
}