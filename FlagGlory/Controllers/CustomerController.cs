using Microsoft.AspNetCore.Mvc;

namespace FlagGlory.Controllers
{
    public class CustomerController
    {
        //public object ViewData { get; private set; }

        public async Task<IActionResult> Index(string sortOrder, string searchString)
        {
            ViewData["NameSort"] = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
            //ViewData["DateOrder"] = sortOrder == "Date" ? "date_desc" : "Date";
            //ViewData["OrderNumber"] = searchString;

            var customers = from s in _context.Customers
                            select s;
            if (!String.IsNullOrEmpty(searchString))
            {
                customers = customers.Where(s => s.LastName.Contains(searchString)
                                       || s.FirstMidName.Contains(searchString));
            }
            switch (sortOrder)
            {
                case "name_desc":
                    customers = customers.OrderByDescending(s => s.LastName);
                    break;
                case "Date":
                    customers = customers.OrderBy(s => s.EnrollmentDate);
                    break;
                case "date_desc":
                    customers = customers.OrderByDescending(s => s.EnrollmentDate);
                    break;
                default:
                    customers = customers.OrderBy(s => s.LastName);
                    break;
            }
            return View(await customers.AsNoTracking().ToListAsync());
        }

        private IActionResult View(object p)
        {
            throw new NotImplementedException();
        }
    }
}
