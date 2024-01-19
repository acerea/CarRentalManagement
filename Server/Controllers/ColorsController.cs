using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CarRentalManagement.Server.Data;
using CarRentalManagement.Shared.Domain;
using CarRentalManagement.Server.IRepository;
using Duende.IdentityServer.Validation;

namespace CarRentalManagement.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ColorsController : ControllerBase
    {
		//private readonly ApplicationDbContext _context;
		private readonly IUnitOfWork _unitOfWork;

		//public ColorsController(ApplicationDbContext context)
		public ColorsController(IUnitOfWork unitOfWork)
		{
            //_context = context;
            _unitOfWork = unitOfWork;
        }

        // GET: api/Colors
        [HttpGet]
		/*
        public async Task<ActionResult<IEnumerable<Color>>> GetColors()
        {
          if (_context.Colors == null)
          {
              return NotFound();
          }
            return await _context.Colors.ToListAsync();
        }
        */
		public async Task<IActionResult> GetColors()
		{
            //return NotFound();
            var Colors = await _unitOfWork.Colors.GetAll();
			return Ok(Colors);
		}
		// GET: api/Colors/5
		[HttpGet("{id}")]
		/*public async Task<ActionResult<Color>> GetColor(int id)
        {
          if (_context.Colors == null)
          {
              return NotFound();
          }
            var Color = await _context.Colors.FindAsync(id);

            if (Color == null)
            {
                return NotFound();
            }

            return Color;
        }*/

		public async Task<IActionResult> GetColor(int id)
		{
			var Color = await _unitOfWork.Colors.Get(q => q.Id == id);

			if (Color == null)
			{
				return NotFound();
			}

			return Ok(Color);
		}

		// PUT: api/Colors/5
		// To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
		[HttpPut("{id}")]
        public async Task<IActionResult> PutColor(int id, Color Color)
        {
            if (id != Color.Id)
            {
                return BadRequest();
            }

            //_context.Entry(Color).State = EntityState.Modified;
            _unitOfWork.Colors.Update(Color);

            try
            {
                //await _context.SaveChangesAsync();
                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
				//if (!ColorExists(id))
				if (!await ColorExists(id))
				{
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Colors
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Color>> PostColor(Color Color)
        {
            /*
          if (_context.Colors == null)
          {
              return Problem("Entity set 'ApplicationDbContext.Colors'  is null.");
          }
            //_context.Colors.Add(Color);
            //await _context.SaveChangesAsync();
        */
            await _unitOfWork.Colors.Insert(Color);
            await _unitOfWork.Save(HttpContext);

            return CreatedAtAction("GetColor", new { id = Color.Id }, Color);
        }

        // DELETE: api/Colors/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteColor(int id)
        {
            /*
            if (_context.Colors == null)
            {
                return NotFound();
            }
            var Color = await _context.Colors.FindAsync(id);
            if (Color == null)
            {
                return NotFound();
            }

            _context.Colors.Remove(Color);
            await _context.SaveChangesAsync();
            */

            var Color = await _unitOfWork.Colors.Get(q => q.Id == id);
            if (Color == null)
            {
                return NotFound();
            }

            await _unitOfWork.Colors.Delete(id);
            await _unitOfWork.Save(HttpContext);

            return NoContent();
        }

		//private bool ColorExists(int id)
		private async Task<bool> ColorExists(int id)
		{
            //return (_context.Colors?.Any(e => e.Id == id)).GetValueOrDefault();
            var Color = await _unitOfWork.Colors.Get(q => q.Id == id);
            return Color == null;
        }
    }
}
