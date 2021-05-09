using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BusinessLayer.Concrete;
using BusinessLayer.FluentValidation.ValidationRules;
using DataAccessLayer.Concrete.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;

namespace MvcProjectKampi.Controllers
{
    public class CategoryController : Controller
    {
        CategoryManager _categoryManager = new CategoryManager(new EfCategoryDal());

        public ActionResult Index()
        {
            var categoryValues = _categoryManager.GetList();
            return View(categoryValues);
        }
        
        public ActionResult GetCategoryList()
        {
            var categoryValues = _categoryManager.GetList();
            return View(categoryValues);
        }

        public ActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Add(Category category)
        {
            CategoryValidation categoryValidation = new CategoryValidation();
            ValidationResult results = categoryValidation.Validate(category);
            if (results.IsValid)
            {
                _categoryManager.Add(category);
                return RedirectToAction("GetCategoryList");
            }
            else
            {
                foreach (var errorItem in results.Errors)
                {
                    ModelState.AddModelError(errorItem.PropertyName,errorItem.ErrorMessage);
                }
            }
            return View();
        }
    }
}