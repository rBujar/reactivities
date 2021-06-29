using System;
using System.Threading;
using System.Threading.Tasks;
using Domain;
using MediatR;
using Persistence;

namespace Application.Activities
{
    public class Details
    {
        public class Query : IRequest<Publisher>
        {
            public Guid Id { get; set; }
        }
        public class Handler : IRequestHandler<Query, Publisher>
        {
            private readonly DataContext _context;
            public Handler(DataContext context)
            {
                _context = context;
            }

            public async Task<Publisher> Handle(Query request, CancellationToken cancellationToken)
            {
                return await _context.Publishers.FindAsync(request.Id);
            }
        }
    }
}