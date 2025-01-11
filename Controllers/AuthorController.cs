using Microsoft.AspNetCore.Mvc;
using WEB.Repository.Intarfaces;

namespace WEB.Controllers
{
    public class AuthorController : ControllerBase
    {
        private readonly IAuthorRepository _AuthorRepository;

        public AuthorController(IAuthorRepository authorRepository)
        {
            _AuthorRepository = authorRepository;
        }

        public async Task<IActionResult> GetAllAsync()
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            return Ok(await _AuthorRepository.GetAllAsync());

        }
    }
}
