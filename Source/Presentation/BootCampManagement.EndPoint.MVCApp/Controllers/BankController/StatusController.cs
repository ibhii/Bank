using Domain.Contract.Base;
using Microsoft.AspNetCore.Mvc;

namespace BootCampManagement.EndPoint.MVCApp.Controllers.BankController;

public class StatusController: Controller
{
    private readonly IUnitOfWork _unitOfWork ;
    public StatusController(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }
}
