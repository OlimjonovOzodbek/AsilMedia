using AsilMedia.Application.DataTransferObjects;
using AsilMedia.Application.Services.FilmMakers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AsilMedia.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FilmController : ControllerBase
    {
        private readonly IFilmMakerService _filmMakerService;

        public FilmController(IFilmMakerService filmMakerService)
        {
            _filmMakerService = filmMakerService;
        }
        [HttpPost]
        public async Task<IActionResult> PostAsync(FilmMakerDTO filmmakerDTO)
        {
            var filmMaker = await _filmMakerService.InsertAsync(filmmakerDTO);

            return Ok(filmMaker);
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var films = await _filmMakerService.SelectAllAsync();

            return Ok(films);
        }

        [HttpGet]
        public async Task<IActionResult> GetByIdAsync(long id)
        {
            var films = await _filmMakerService.SelectByIdAsync(id);

            return Ok(films);
        }

        [HttpPut]
        public async Task<IActionResult> PutAsync(FilmMakerDTO filmMakerDTO, long id)
        {
            var films = await _filmMakerService.UpdateAsync(filmMakerDTO, id);

            return Ok(films);
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteAsync(long id)
        {
            var film = await _filmMakerService.DeleteAsync(id);

            return Ok(film);
        }
    }
}

