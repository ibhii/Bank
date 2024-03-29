﻿using Domain.Contract.Base;
using Microsoft.AspNetCore.Mvc;

namespace BootCampManagement.EndPoint.MVCApp.Controllers.BankController;

[Route("User")]
public class UserController : Controller
{
    private readonly IUnitOfWork _unitOfWork;

    public UserController(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    /// <summary>
    /// اطلاعات هر کاربر رو با استفاده از آی دی واکشی می کند
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    [HttpGet("GetById")]
    public Task<JsonResult> GetById(int id)
    {
        return Task.FromResult(Json(_unitOfWork.UserRepository.GetById(id)));
    }

    /// <summary>
    /// چک می کند که اطلاعات کاربر صحیح وارد شده باشد
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    [HttpGet("ValidationCheck")]
    public async Task<bool> ValidationCheck(int id)
    {
        return await _unitOfWork.UserRepository.ValidationCheckById(id);
    }

    /// <summary>
    /// یکی بیشتر از مقدار آخرین آی دی ثبت شده در جدول را به منظور ساخت کلید اصلی بر می گرداند
    /// </summary>
    /// <returns></returns>
    [HttpGet("GetNextValue")]
    public async Task<int> GetNextValue()
    {
        
        return await _unitOfWork.UserRepository.GetNextValue("User");
    }

}
