﻿using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Udemy.TodoAppNTier.Business.Interfaces;
using Udemy.TodoAppNTier.Dto.WorkDtos;

namespace Udemy.TodoAppNTier.UI.Controllers
{
    public class HomeController : Controller
    {
        private readonly IWorkService _workService;

        public HomeController(IWorkService workService)
        {
            _workService = workService;
        }

        public async Task<IActionResult> Index()
        {
            var worklist = await _workService.GetAll();
            return View(worklist);
        }

        public IActionResult Create()
        {
            return View(new WorkCreateDto());
        }

        [HttpPost]
        public async Task<IActionResult> Create(WorkCreateDto dto)
        {
                await _workService.Create(dto);
                return RedirectToAction("Index");   
        }

        public async Task<IActionResult> Update(int id)
        {
            return View(await _workService.GetById<WorkUpdateDto>(id));
        }

        [HttpPost]
        public async Task<IActionResult> Update(WorkUpdateDto dto)
        {
                await _workService.Update(dto);
                return RedirectToAction("Index");
        }

        public async Task<IActionResult> Remove(int id)
        {
            await _workService.Remove(id);
            return RedirectToAction("Index");
        }
    }
}
