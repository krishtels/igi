﻿using Microsoft.AspNetCore.Mvc;
using Web_053501_Krishtafovich.Entities;
using Web_053501_Krishtafovich.Extensions;
using Web_053501_Krishtafovich.Models;
using Web_053501_Krishtafovich.Data;


namespace Web_053501_Krishtafovich.Controllers
{
    public class ProductController : Controller
    {
        int _pageSize;
        ApplicationDbContext _context;
        private ILogger _logger;
        public ProductController(ApplicationDbContext context, ILogger<ProductController> logger)
        {
            _pageSize = 3;
            _context = context;
            _logger = logger;
        }

        [Route("Catalog")]
        [Route("Catalog/Page_{pageNo}")]
        public IActionResult Index(int? group, int pageNo = 1)
        {
            /*_logger.LogInformation($"info: group={group}, page={pageNo}");*/
            var dishesFiltered = _context.Dishes.Where(d => !group.HasValue || d.DishGroupId == group.Value);
            // Поместить список групп во ViewData
            ViewData["Groups"] = _context.DishGroups;
            ViewData["CurrentGroup"] = group ?? 0;
            var model = ListViewModel<Dish>.GetModel(dishesFiltered, pageNo, _pageSize);
            if (Request.IsAjaxRequest())
                return PartialView("_listpartial", model);
            else
                return View(model);
        }
        
    }
}
