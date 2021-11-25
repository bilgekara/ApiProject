using ApiProject.Core.Utilities.Results.ComplexTypes;
using ApiProject.Entities.Dtos;
using ApiProject.Services.Abstract;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ApiProject.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PhotosController : Controller
    {
        IPhotoService _photoService;
        public PhotosController(IPhotoService photoService)
        {
            _photoService = photoService;
        }
        // GET: api/<PhotosController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        [HttpGet("getall")]
        public async Task<IActionResult> GetAll()
        {
            //var result = await _photoService.GetAllByNonDeleted();
            var result = await _photoService.Get(1);

            //var photos = JsonSerializer.Serialize(result.Data, new JsonSerializerOptions
            //{
            //    ReferenceHandler = ReferenceHandler.Preserve
            //});
            return Ok(result);
        }

        [HttpPost("add")]
        public async Task<IActionResult> Add(PhotoAddDto photoAddDto)
        {
            if (ModelState.IsValid)
            {
                var result = await _photoService.Add(photoAddDto);
                if (result.ResultStatus == ResultStatus.Success)
                {
                    return Json(result);
                }
            }
            return Json("error");

        }
        [HttpPost("update")]
        public async Task<IActionResult> Update(PhotoUpdateDto photoUpdateDto)
        {
            if (ModelState.IsValid)
            {
                var result = await _photoService.Update(photoUpdateDto);
                if (result.ResultStatus == ResultStatus.Success)
                {
                    return Json(result);
                }
            }
            return Json("error");
        }

        [HttpPost("delete")]
        public async Task<JsonResult> Delete(int photoId)
        {
            var result = await _photoService.Delete(photoId);
            //var deletedPhoto = JsonSerializer.Serialize(result.Data);
            return Json(result);
        }


    }
}
