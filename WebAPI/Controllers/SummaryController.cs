using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DTO;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class SummaryController : BaseController
    {
        // GET: api/<SummaryController>
        [HttpGet]
        public string Get()
        {
            return "value";
        }

        // GET api/<SummaryController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        [HttpGet]
        public List<Summary_RPT> RPT_DoanhThuHaiNamGanNhat()
        {
            return app.SummaryRpt.RPT_DoanhThuHaiNamGanNhat();
        }

        [HttpPost]
        public List<Summary> GetAllByTimeCategories([FromBody] Summary input)
        {
            return app.Summary.GetSummaryCategories(input);
        }

        [HttpPost]
        public List<Summary> RPT_TrangThaiDonHang([FromBody] Summary input)
        {
            return app.Summary.RPT_TrangThaiDonHang(input);
        }

        // POST api/<SummaryController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<SummaryController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<SummaryController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
