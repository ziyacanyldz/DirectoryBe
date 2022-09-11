using Business.Abstract;
using Business.Concrate;
using DataAccess.Concrete;
using Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KayitApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KayitController : ControllerBase
    {
        private IKayitlarService kayitlarManager;
        public KayitController()
        {
            kayitlarManager = new KayitlarManager();
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var kayitlar = kayitlarManager.GetAll();
            return Ok(kayitlar); //200 + data
        }

        [HttpGet("getbyid/{id}")]
        public IActionResult GetById(int id)
        {
            var kayit = kayitlarManager.GetById(id);
            if(kayit != null)
            {
                return Ok(kayit); //200 + data
            }
            return NotFound(); //404
        }

        [HttpGet("getbyname/{name}")]
        public IActionResult GetByName(string name)
        {
            var kayit = kayitlarManager.GetByName(name);
            if (kayit != null)
            {
                return Ok(kayit); //200 + data
            }
            return NotFound(); //404
        }

        [HttpPost("Add")]
        public IActionResult Add(Kayit kayit)
        {
            if (ModelState.IsValid)
            {
                kayitlarManager.Add(kayit); 
                return Ok(); //200
            }
            return BadRequest(ModelState); //400 + validation errors
        }

        [HttpPost("Update")]
        public IActionResult Update(Kayit kayit)
        {
            if(kayitlarManager.GetById(kayit.KayitId) != null)
            {
                kayitlarManager.Update(kayit);
                return Ok(); //200
            }
            return NotFound(); //404
        }

        [HttpPost("Delete{id}")]
        public IActionResult Delete(int id)
        {
            if(kayitlarManager.GetById(id) != null)
            {
                kayitlarManager.Delete(id);
                return Ok(); //200
            }
            return NotFound(); //404
        }


    }
}
