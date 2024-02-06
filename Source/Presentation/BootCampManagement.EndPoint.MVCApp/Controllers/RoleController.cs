using Domain.Contract.Base;
using Microsoft.AspNetCore.Mvc;

namespace BootCampManagement.EndPoint.MVCApp.Controllers
{
    public class RoleController : Controller
    {
        private readonly IUnitOfWork _unitOfWork ;
        public RoleController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // public JsonResult Index()
        // {
        //     // var roles = _unitOfWork.RoleRepository.GetAll();
        //     // return Json(roles);
        // }

        // public JsonResult Get(int id)
        // {
        //     var role = _unitOfWork.RoleRepository.Get(id);
        //     return Json(role);
        // }

        // public IActionResult Create()
        // {
        //     // var role1 = new HRRole
        //     // {
        //     //     Code = 3,
        //     //     Title = "Admin101"
        //     // };
        //     //
        //     // var role2 = new HRRole
        //     // {
        //     //     Code = 4,
        //     //     Title = "User201"
        //     };


            // _unitOfWork.RoleRepository.Insert(role1);
            // _unitOfWork.RoleRepository.Insert(role2);
            //
            // _unitOfWork.Commit();
            //
            //
            // return Ok();
        // }
    }
}
