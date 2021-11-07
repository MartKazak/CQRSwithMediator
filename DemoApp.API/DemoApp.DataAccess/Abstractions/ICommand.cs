using MediatR;

namespace DemoApp.DataAccess.Abstractions
{
    public interface ICommand<out TResponse> : IRequest<TResponse>
    {
    }
}
