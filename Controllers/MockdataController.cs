using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SampleWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MockdataController : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> GetMockData()
        {
            IList<MockDatatModel> mockData = MockDatatModel.BooksList();
            return Ok(mockData);
        }
    }
}