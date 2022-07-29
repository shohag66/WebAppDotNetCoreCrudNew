using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WebAppDotNetCoreCrudNew.Models;

namespace WebAppDotNetCoreCrudNew.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}




//"ConnectionStrings": {
//    "DefaultConnection": "Server=DESKTOP-DLB3GM6;Database=InventoryManagement;Trusted_Connection=True; MultipleActiveResultSets=true"

//  },

//public class ApplicationDbContext : IdentityDbContext
//{
//    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
//       : base(options)
//    {
//    }

//    public DbSet<Customer> Customers { get; set; }
//    public DbSet<Product> Products { get; set; }
//    public DbSet<Category> Categories { get; set; }
//    public DbSet<Order> Orders { get; set; }
//    public DbSet<OrderDetail> OrderDetails { get; set; }
//    public DbQuery<VWOrderInfo> VwOrderInfos { get; set; }
//}


//{


//    public void ConfigureServices(IServiceCollection services)
//    {

//        services.AddDbContext<ApplicationDbContext>(options =>
//        options.UseSqlServer(
//            Configuration.GetConnectionString("DefaultConnection")));

//        services.AddTransient<ICustomerService, CustomerService>();
//        services.AddTransient<ICustomerRepository, CustomerRepository>();

//        services.AddTransient<ICategoryService, CategoryService>();
//        services.AddTransient<ICategoryRepository, CategoryRepository>(
//        services.AddAutoMapper();

//        services.AddControllersWithViews();
//    }


//    Microsoft.EntityFrameworkCore.Design(2.2.0)
//Microsoft.EntityFrameworkCore.SqlServer(2.2.0)
//Microsoft.EntityFrameworkCore.Tools(2.2.0)
//Microsoft.EntityFrameworkCore.SqlServer.Design(1.1.6)