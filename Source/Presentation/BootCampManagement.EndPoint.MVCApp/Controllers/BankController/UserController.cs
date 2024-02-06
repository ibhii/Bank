using Domain.Contract.Base;
using Microsoft.AspNetCore.Mvc;

namespace BootCampManagement.EndPoint.MVCApp.Controllers.BankController;

public class UserController : Controller
{
    private readonly IUnitOfWork _unitOfWork ;
    public UserController(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public JsonResult GetById(int id)
    {
        var role = _unitOfWork.UserRepository.Get(id);
        return Json(role);
    }

}
