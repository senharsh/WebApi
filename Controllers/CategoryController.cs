using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.Helpers;
using WebApi.Interface;
using WebApi.Models;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CategoryController : ControllerBase
    {
        private ICategory _categoryMaster;
        private IMapper _mapper;
        private readonly AppSettings _appSettings;
        public CategoryController(
            ICategory categoryService,
           IMapper mapper,
           IOptions<AppSettings> appSettings)
        {
            _categoryMaster = categoryService;
            _mapper = mapper;
            _appSettings = appSettings.Value;
        }
        [HttpGet]
        [Route ("GetAllCategory")]
        public IActionResult GetAllCategory()
        {
            var category = _categoryMaster.GetAllCategory();
            var model = _mapper.Map<IList<CategoryMasterModel>>(category);
            return Ok(model);
        }
    }
}
