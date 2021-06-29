using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Application.Activities;
using Domain;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    public class AuthorController : BaseApiController
    {
         
        [HttpGet]

        public async Task<ActionResult<List<Author>>> GetActivities()
        {
            return await Mediator.Send(new List.Query());
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<Author>> GetActivity(Guid id)
        {
            return await Mediator.Send(new Details.Query{Id = id});
        
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