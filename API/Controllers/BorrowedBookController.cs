using System;
using System.Threading.Tasks;
using backend.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace backend.Controllers
{
    [ApiController]
    [Route("api/borrowedbook")]
    public class BorrowedBookController : ControllerBase
    {
        private readonly DataContext _data;
        public BorrowedBookController(DataContext data)
        {
            _data = data;


        }
        [HttpGet("{id}")]
        public async Task<IActionResult> getAuthors(int id)
        {

            try
            {
                Author  author = await _data.Authors.FirstOrDefaultAsync(authori => authori.Id==id );
                return Ok(author);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
        [HttpPost()]
        public async Task<IActionResult> addAuthor(Author author)
        {

            try
            {
                 await _data.Authors.AddAsync(author);
                await _data.SaveChangesAsync();
                return Ok(author);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
         [HttpDelete("{id}")]
        public async Task<IActionResult> deleteAuthor(int id)
        {

            try
            {
                Author  author = await _data.Authors.FirstOrDefaultAsync(authori => authori.Id==id );
                 _data.Authors.Remove(author);
                 await _data.SaveChangesAsync();
                                 return Ok(author);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
         [HttpPut]
        public async Task<IActionResult> updateAuthor(Author authorUpdate)
        {

            try
            {
                Author  author = await _data.Authors.FirstOrDefaultAsync(authori => authori.Id==authorUpdate.Id );
                author.Emri= authorUpdate.Emri;
                author.Mbiemri=authorUpdate.Mbiemri;
                 _data.Authors.Update(author);
                 await _data.SaveChangesAsync();
                                 return Ok(author);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}