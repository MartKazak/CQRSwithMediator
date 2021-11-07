using MediatR;

namespace DemoApp.Types.Abstractions
{
    public interface IQuery<out TResponse> : IRequest<TResponse>
    {
    }
}
