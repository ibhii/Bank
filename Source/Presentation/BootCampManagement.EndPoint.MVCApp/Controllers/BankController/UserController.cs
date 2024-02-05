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

    public void Test()
    {
        var users = _unitOfWork.BankUserRepository.GetAll().ToList();
    }
}
