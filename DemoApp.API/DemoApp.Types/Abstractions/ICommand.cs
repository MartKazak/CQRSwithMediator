using MediatR;

namespace DemoApp.Types.Abstractions
{
    public interface ICommand<out TResponse> : IRequest<TResponse>
    {
    }
}
