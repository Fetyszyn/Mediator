using WebApplication2;

namespace WebApplication2
{
    public class Service: Interface
    {
        private readonly IMediator _mediator;
        public Service(IMediator mediator)  {
            _mediator = mediator;
        }

        public String getName()
        {
            return _mediator.Send(new SayHelloRequest { Name = "Adam" }).Result;


        }
    }
}
