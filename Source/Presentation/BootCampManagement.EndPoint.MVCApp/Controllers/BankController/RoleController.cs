using Domain.Contract.Base;
using Microsoft.AspNetCore.Mvc;

namespace BootCampManagement.EndPoint.MVCApp.Controllers.BankController;

public class RoleController: Controller
{
    private readonly IUnitOfWork _unitOfWork ;
    public RoleController(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }
}
