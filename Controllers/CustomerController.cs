using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using stripe_dotnet_example.Entities;

namespace stripe_dotnet_example.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class CustomerController : ControllerBase
	{
		private readonly DbContext _dbContext;

		public CustomerController(DbContext dbContext)
		{
			_dbContext = dbContext;
		}

		[HttpPost]
		public async Task<IActionResult> Create([FromBody] Customer request)
		{
			_dbContext.Add<Customer>(request);
			await _dbContext.SaveChangesAsync();

			return Ok();
		}
	}
}
