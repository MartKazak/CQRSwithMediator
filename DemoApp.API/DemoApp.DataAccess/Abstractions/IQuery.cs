using MediatR;

namespace DemoApp.DataAccess.Abstractions
{
    public interface IQuery<out TResponse> : IRequest<TResponse>
    {
    }
}
