using Microsoft.AspNetCore.Mvc;
using Angular4SPA.ViewModels;
using Angular4SPA.Data;
using System.Linq;

namespace A2SPA.Api
{
    [Route("api/[controller]")]
    public class SampleDataController : Controller
    {
        private readonly Angular4SPAContext _context;

        public SampleDataController(Angular4SPAContext context)
        {
            _context = context;
        }

        // GET: api/values
        [HttpGet]
        public TestData Get()
        {
            // pick up the last value
            return _context.TestData.DefaultIfEmpty(null as TestData).LastOrDefault();
        }

        // POST api/values
        [HttpPost]
        public TestData Post([FromBody]TestData value)
        {
            // it's valid isn't it? ToDO: add server-side validation here
            value.Id = 0;
            var newTestData = _context.Add(value);
            _context.SaveChanges();
            return newTestData.Entity as TestData;
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]TestData value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}