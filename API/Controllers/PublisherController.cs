using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Application.Activities;
using Application.Publishers;
using Domain;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    public class PublishersController : BaseApiController
    {
         
        [HttpGet]

        public async Task<ActionResult<List<Publisher>>> GetPublishers()
        {
            return await Mediator.Send(new List.Query());
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<Publisher>> GetPublisher(Guid id)
        {
            return await Mediator.Send(new Details.Query{Id = id});
        }

        [HttpPost]

        public async Task<IActionResult> CreatePublisher(Publisher Publisher)
        {
            return Ok(await Mediator.Send(new Create.Command {Publisher = Publisher}));
        }
        [HttpPut("{id}")]

        public async Task<IActionResult> EditPublisher(Guid id, Publisher Publisher) 
        {
            Publisher.Id= id;
            return Ok(await Mediator.Send(new Edit.Command{Publisher = Publisher}));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePublisher(Guid id)
        {
            return Ok(await Mediator.Send(new Delete.Command{Id = id}));
        }
    }
}