using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using eManager.Models;
using eManager.Services.Helpers;
using eManager.WebModels;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using X.PagedList;
using NToastNotify;
using eManager.Domain;
using eManager.DataAccess;

namespace eManager.Controllers
{

    public class EmployeeController : Controller
    {
        private readonly IEmployeeService _employeeService;
        private readonly IUserService _userService;
        private readonly IClientService _clientService;
        private readonly IActivityService _activityService;
        private readonly IHostingEnvironment _hostingEnvironment;
        private readonly IToastNotification _toastNotification;
    
        public EmployeeController(IEmployeeService employeeService, IToastNotification toastNotification, IUserService userService, IHostingEnvironment hostingEnvironment, IClientService clientService, IActivityService activityService)
        {
            _employeeService = employeeService;
            _userService = userService;
            _clientService = clientService;
            _hostingEnvironment = hostingEnvironment;
            _activityService = activityService;
            _toastNotification = toastNotification;
           
        }



        public ActionResult ShowEmployees(int? page, string search, string filter)
        {
            var employees = _employeeService.ShowEmployees().ToList();

            if (search != null)
            {
                page = 1;
            }
            else
            {
                search = filter;
            }
            ViewBag.CurrentFilter = search;

            if (!String.IsNullOrEmpty(search))
            {
                employees = employees.Where(i => i.FirstName == search || i.LastName == search || i.EmployeeNumber == search).ToList();

            }


            int pageSize = 10;
            int pageNumber = (page ?? 1);
            ViewBag.invoiceList = employees.ToPagedList(pageNumber, pageSize);
            return View(employees.ToPagedList(pageNumber, pageSize));


        }

        public ActionResult EmployeeInfo(int id)
        {
            var employee = _employeeService.ShowEmployees().Where(x => x.Id == id).FirstOrDefault();
            if (employee == null) return View("_Error");

            EmployeeViewModel employeeToView = new EmployeeViewModel()
            {
                Id = employee.Id,
                EmployeeNumber = employee.EmployeeNumber,
                FirstName = employee.FirstName,
                LastName = employee.LastName,
                Username = employee.Username,
                Password = employee.Password,
                Address = employee.Address,
                DateOfBirth = employee.DateOfBirth,
                Department = employee.Department,
                Phone = employee.Phone,
                Salary = employee.Salary,
                IdCard = employee.IdCard,
                Medical = employee.Medical,
                M1M2 = employee.M1M2,
                HSafety = employee.HSafety

            };

            return View(employeeToView);
        }

        [HttpGet]
        public ActionResult AddEmployee()
        {

            return View(new EmployeeViewModel());
        }

        [HttpPost]
        public ActionResult AddEmployee(EmployeeViewModel employee)
        {
           
            int addedEmployee = _employeeService.AddNewEmployee(employee);
            string message = String.Format("New employee {0} is successfully created!", addedEmployee);
            _toastNotification.AddSuccessToastMessage(message);
            return RedirectToAction("ShowEmployees", "Employee");
        }

        [HttpGet]
        public IActionResult UpdateEmployeeInfo(int id)
        {

            var employee = _employeeService.ShowEmployees().Find(x => x.Id == id);
            if (employee == null)
            {
                ErrorViewModel error = new ErrorViewModel
                {
                    RequestId = id.ToString()
                };
                return View("Error", error);
            }

            EmployeeViewModel employeeToView = new EmployeeViewModel()
            {
                Id = employee.Id,
                EmployeeNumber = employee.EmployeeNumber,
                FirstName = employee.FirstName,
                LastName = employee.LastName,
                Address = employee.Address,
                DateOfBirth = employee.DateOfBirth,
                Department = employee.Department,
                Phone = employee.Phone,
                Salary = employee.Salary,
                IdCard = employee.IdCard,
                Medical = employee.Medical,
                M1M2 = employee.M1M2,
                HSafety = employee.HSafety

            };

            return View(employeeToView);
        }

        [HttpPost]
        public IActionResult UpdateEmployeeInfo(EmployeeViewModel employeeToView, IFormFile Medical, IFormFile IdCard, IFormFile M1M2, IFormFile HSafety)
        {

            if (Medical != null)
            {
                var path = Path.Combine(_hostingEnvironment.WebRootPath, "UploadedFiles", Medical.FileName);
                using (var stream = new FileStream(path, FileMode.Create))
                {
                    Medical.CopyToAsync(stream);
                }
                employeeToView.Medical = Medical.FileName;
                ViewBag.Message = "Medical is successfully uploaded!";
                var obj = _employeeService.ShowEmployees().Where(x => x.Medical == employeeToView.Medical).FirstOrDefault();
                if (obj != null)
                {
                    employeeToView.Medical = obj.Medical;

                }
            }

            if (M1M2 != null)
            {
                var path = Path.Combine(_hostingEnvironment.WebRootPath, "UploadedFiles", M1M2.FileName);
                using (var stream = new FileStream(path, FileMode.Create))
                {
                    M1M2.CopyToAsync(stream);
                }
                employeeToView.M1M2 = M1M2.FileName;
                ViewBag.Message = "M1M2 is successfully uploaded!";
                var obj = _employeeService.ShowEmployees().Where(x => x.M1M2 == employeeToView.M1M2).FirstOrDefault();
                if (obj != null)
                {
                    employeeToView.M1M2 = obj.M1M2;

                }
            }

            if (HSafety != null)
            {
                var path = Path.Combine(_hostingEnvironment.WebRootPath, "UploadedFiles", HSafety.FileName);
                using (var stream = new FileStream(path, FileMode.Create))
                {
                    HSafety.CopyToAsync(stream);
                }
                employeeToView.HSafety = HSafety.FileName;
                ViewBag.Message = "Healt&Safety is successfully uploaded!";
                var obj = _employeeService.ShowEmployees().Where(x => x.HSafety == employeeToView.HSafety).FirstOrDefault();
                if (obj != null)
                {
                    employeeToView.HSafety = obj.HSafety;

                }
            }

            if (IdCard != null)
            {
                var path = Path.Combine(_hostingEnvironment.WebRootPath, "UploadedFiles", IdCard.FileName);
                using (var stream = new FileStream(path, FileMode.Create))
                {
                    IdCard.CopyToAsync(stream);
                }
                employeeToView.IdCard = IdCard.FileName;
                ViewBag.Message = "IdCard is successfully uploaded!";
                var obj = _employeeService.ShowEmployees().Where(x => x.IdCard == employeeToView.IdCard).FirstOrDefault();
                if (obj != null)
                {
                    employeeToView.IdCard = obj.IdCard;

                }
            }



            var modified = _employeeService.UpdateEmployeeInfo(employeeToView);
            return RedirectToAction("ShowEmployees");


        }


        [HttpGet]
        public IActionResult RemoveEmployee(int id)
        {
            var employee = _employeeService.ShowEmployees().SingleOrDefault(x => x.Id == id);

            return View(employee);
        }

        [HttpPost]
        public IActionResult RemoveEmployee(EmployeeViewModel viewModel)
        {
            _employeeService.RemoveEmployee(viewModel.Id);
            string message = String.Format("Employee {0} is removed!", viewModel.FirstName);
            _toastNotification.AddWarningToastMessage(message);
            return RedirectToAction("ShowEmployees", "Employee");
        }


        public IEnumerable<SelectListItem> GetEmployeesList()
        {
            var employeesList = _employeeService.ShowEmployees().Select(x => new SelectListItem
            {
                Value = x.Id.ToString(),
                Text = x.FirstName + ' ' + x.LastName,
                Selected = false

            });
            return new SelectList(employeesList, "Value", "Text");
        }


        public IEnumerable<SelectListItem> GetClientsList()
        {
            var clientsList = _clientService.ShowClients().Select(x => new SelectListItem
            {
                Value = x.ClientId.ToString(),
                Text = x.Name,
                Selected = false

            });
            return new SelectList(clientsList, "Value", "Text");
        }


        [HttpGet]
        public IActionResult AddActivity()
        {
            return View(new ActivityViewModel() { Clients = GetClientsList(), AllEmployees = _employeeService.ShowEmployees().ToList()});
        }

        [HttpPost]
        public IActionResult AddActivity(ActivityViewModel activityModel)
        {

            activityModel.Clients = GetClientsList();
            var selectedClientId = activityModel.Clients.SingleOrDefault(x => x.Value == activityModel.ClientSelected.ToString());
            if (selectedClientId != null)
            {

                selectedClientId.Selected = true;
                ViewBag.Message = "Activity for client: " + selectedClientId.Text;

            }

            var clientModel = _clientService.GetClient(activityModel.ClientSelected);
            ClientViewModel activityClient = new ClientViewModel() { ClientId = clientModel.ClientId, Address = clientModel.Address, BankAccount = clientModel.BankAccount, Description = clientModel.Description, Email = clientModel.Email, LogoImage = clientModel.LogoImage, Name = clientModel.Name, Phone = clientModel.Phone, TaxNumber = clientModel.TaxNumber };
            activityModel.Client = activityClient; 
           activityModel.ClientName = activityClient.Name;           
            activityModel.User = _userService.GetCurrentUser(User.Identity.Name);
            activityModel.ActivityStatusViewModel = ActivityStatusViewModel.Processing;

            int addedActivity = _activityService.AddActivity(activityModel);
            string message = String.Format("Activity {0} is successfully created!", addedActivity);
            _toastNotification.AddSuccessToastMessage(message);
            return RedirectToAction("EmployeesActivities", "Employee");
        }

        [HttpGet]
        public IActionResult RemoveActivity(int id)
        {
            var activity = _activityService.ShowActivities().FirstOrDefault(x => x.ActivityId == id);

            return View(activity);
        }

        [HttpPost]
        public IActionResult RemoveActivity(ActivityViewModel viewModel)
        {
            _activityService.RemoveActivity(viewModel.ActivityId);
            return RedirectToAction("EmployeesActivities", "Employee");
        }


        public ActionResult EmployeesActivities(int? page, string search, string filter)
        {
            var activities = _activityService.ShowActivities().ToList();


            
            if (search != null)
            {
                page = 1;
            }
            else
            {
                search = filter;
            }
            ViewBag.CurrentFilter = search;

            if (!String.IsNullOrEmpty(search))
            {
                activities = activities.Where(i => i.ClientName == search || i.Description == search || i.EmployeeActivities.Any(x => x.FirstName.Contains(search)) || i.EmployeeActivities.Any(x => x.LastName.Contains(search))).ToList();

            }
            foreach (var a in activities)
            {
                if (a.Client == null)
                {
                    a.Client = new ClientViewModel() { ClientId = a.ClientSelected };
                }

                var clientActivity = _clientService.GetClient(a.ClientSelected);
                a.Client = clientActivity;
                a.ClientName = clientActivity.Name;

      
            }

            int pageSize = 10;
            int pageNumber = (page ?? 1);
            ViewBag.activitiesList = activities.ToPagedList(pageNumber, pageSize);
            return View(activities.ToPagedList(pageNumber, pageSize));


        }



        [HttpGet]
        public IActionResult UpdateActivityInfo(int id)
        {

            var activity = _activityService.ShowActivities().Find(x => x.ActivityId == id);
            if (activity == null)
            {
                ErrorViewModel error = new ErrorViewModel
                {
                    RequestId = id.ToString()
                };
                return View("Error", error);
            }

            UserViewModel user = _userService.GetCurrentUser(User.Identity.Name);




            ActivityViewModel activityToView = new ActivityViewModel()
            {
                ActivityId = activity.ActivityId,
                ClientSelected = activity.ClientSelected,
                Duration = activity.Duration,
                Date = activity.Date,
                ClientName = activity.ClientName,
                Description = activity.Description,
                Client = activity.Client,
                EmployeeActivities = activity.EmployeeActivities,
                AllEmployees = _employeeService.ShowEmployees().ToList(),
                User = user,
                Clients = GetClientsList(),
                ActivityStatusViewModel = (ActivityStatusViewModel)activity.ActivityStatusViewModel

            };
          

            return View(activityToView);
        }

        [HttpPost]
        public IActionResult UpdateActivityInfo(ActivityViewModel activityToView)
        {

            UserViewModel user = _userService.GetCurrentUser(User.Identity.Name);
            activityToView.User = user;
            
           
            var modified = _activityService.UpdateActivityInfo(activityToView);
            return RedirectToAction("EmployeesActivities");


        }


        public IActionResult AddEmployeesToActivity(int activityId, int employeeId)
        {
            UserViewModel user = _userService.GetCurrentUser(User.Identity.Name);            
            var currentActivity = _activityService.ShowActivities().Find(x=>x.ActivityId == activityId);
            foreach(var i in _employeeService.ShowEmployees())
            {
                
                    currentActivity.AllEmployees.Add(new EmployeeViewModel() { Id = i.Id, Address = i.Address, DateOfBirth = i.DateOfBirth, Department = i.Department, EmployeeNumber = i.EmployeeNumber, FirstName = i.FirstName, HSafety = i.HSafety, IdCard = i.IdCard, LastName = i.LastName, M1M2 = i.M1M2, Medical = i.Medical, Password = i.Password, Phone = i.Phone, Salary = i.Salary, Username = i.Username });
   
            };
            string employeeName;
            if (currentActivity.EmployeeActivities.Count() == 0)
            {
                int id = _activityService.PickEmployee(currentActivity.ActivityId, employeeId, user.Id, out employeeName);
            }
            foreach (var i in currentActivity.EmployeeActivities)
            {
                if (i.Id != employeeId)
                {
                    int id = _activityService.PickEmployee(currentActivity.ActivityId, employeeId, user.Id, out employeeName);
                }
            }


           
           
            

            return RedirectToAction("EmployeesActivities", "Employee");


        }

        public IActionResult RemoveEmployeeFromActivity(int activityId, int employeeId)
        {
            UserViewModel user = _userService.GetCurrentUser(User.Identity.Name);
            var currentActivity = _activityService.ShowActivities().Find(x => x.ActivityId == activityId);
            foreach (var i in _employeeService.ShowEmployees())
            {
                currentActivity.AllEmployees.Add(new EmployeeViewModel() { Id = i.Id, Address = i.Address, DateOfBirth = i.DateOfBirth, Department = i.Department, EmployeeNumber = i.EmployeeNumber, FirstName = i.FirstName, HSafety = i.HSafety, IdCard = i.IdCard, LastName = i.LastName, M1M2 = i.M1M2, Medical = i.Medical, Password = i.Password, Phone = i.Phone, Salary = i.Salary, Username = i.Username });
            };

            string employeeName;

            int id = _activityService.RemoveEmployee(currentActivity.ActivityId, employeeId, user.Id, out employeeName);
            return RedirectToAction("EmployeesActivities", "Employee");


        }

        public IActionResult ConfirmActivity(int activityId)
        {

            UserViewModel user = _userService.GetCurrentUser(User.Identity.Name);
           ActivityViewModel activityModel = _activityService.ShowActivities().FirstOrDefault(x=>x.ActivityId==activityId);
                                                                                                                                                                                                                                                                                                    
           _activityService.CompleteActivity(activityId, user.Id, ActivityStatusViewModel.Finished);
            
            return RedirectToAction("EmployeesActivities");
        }

       
        public IActionResult PickEmployees(int id)
        {
            var activity = _activityService.ShowActivities().Find(x => x.ActivityId == id);
            if (activity == null)
            {
                ErrorViewModel error = new ErrorViewModel
                {
                    RequestId = activity.ActivityId.ToString()
                };
                return View("Error", error);
            }
            UserViewModel user = _userService.GetCurrentUser(User.Identity.Name);
            ActivityViewModel activityToView = new ActivityViewModel()
            {
                ActivityId = activity.ActivityId,
                ClientSelected = activity.ClientSelected,
                Duration = activity.Duration,
                Date = activity.Date,
                ClientName = activity.ClientName,
                Description = activity.Description,
                Client = activity.Client,
                EmployeeActivities = activity.EmployeeActivities,
                AllEmployees = _employeeService.ShowEmployees().ToList(),
                User = user,
                Clients = GetClientsList(),
                ActivityStatusViewModel = (ActivityStatusViewModel)activity.ActivityStatusViewModel

            };
            //var client = _clientService.GetClient(activityModel.ClientSelected);
            //ClientViewModel clientModel = new ClientViewModel() { ClientId = client.ClientId, Address = client.Address, BankAccount = client.BankAccount, Description = client.Description, Email = client.Email, LogoImage = client.LogoImage, Name = client.Name, Phone = client.Phone, TaxNumber = client.TaxNumber };
          

            return View(activityToView);


        }

    }
}