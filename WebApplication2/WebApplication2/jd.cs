namespace WebApplication2
{
  
    public class SayHelloRequest : IRequest<String> {
       public String Name { get; set; }

        public class SayHelloHandler : IRequestHandler<SayHelloRequest, String>
        {

            async Task<String> IRequestHandler<SayHelloRequest, String>.Handle(SayHelloRequest request, CancellationToken cancellationToken)
            {
                return request.Name;
            }
        }
    }
  
}
