using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ExpenseTracker.Models;
using ExpenseTracker.ViewModels;
using ExpenseTracker.Services;

namespace ExpenseTracker.Controllers;

public class IncomeController : Controller
{
    private IService<Income> _service;
    private IService<IncomeCategory> _serviceCategory;

    public IncomeController(IService<Income> service, IService<IncomeCategory> serviceCategory)
    {
        _service = service;
        _serviceCategory = serviceCategory;
    }

    public async Task<IActionResult> Index()
    {
        var listIncomeCategory = await _serviceCategory.GetAll();
        return View(listIncomeCategory.Value);
    }
    [HttpPost]
    public async Task<IActionResult> Create(NewIncome newIncome)
    {
        Income income = new()
        {
            Title = newIncome.Title,
            Amount = newIncome.Amount,
            CategoryID = newIncome.CategoryID,
            Description = newIncome.Description,
            RecordDate = newIncome.RecordDate
        };

        await _service.Add(income);
        return RedirectToAction("Index","Home");
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
