using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using DemoApp.DataAccess.Contracts.Users;
using DemoApp.DataAccess.Users.Queries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DemoApp.API.Controllers
{
    /// <summary>
    /// The users controller.
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public sealed class UsersInMemoryController : ControllerBase
    {
        private readonly ISender _sender;

        /// <summary>
        /// Initializes a new instance of the <see cref="UsersController"/> class.
        /// </summary>
        /// <param name="sender"></param>
        public UsersInMemoryController(ISender sender)
        {
            _sender = sender;
        }

        /// <summary>
        /// Gets all of the users.
        /// </summary>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>The collection of users.</returns>
        [HttpGet]
        [ProducesResponseType(typeof(List<UserDTO>), StatusCodes.Status200OK)]
        public async Task<IActionResult> GetUsers(CancellationToken cancellationToken)
        {
            var query = new GetUsersFromMemoryQuery();

            var users = await _sender.Send(query, cancellationToken);

            return Ok(users);
        }

        /// <summary>
        /// Gets the user with the specified identifier, if it exists.
        /// </summary>
        /// <param name="userId">The user identifier.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>The user with the specified identifier, if it exists.</returns>
        [HttpGet("{userId:int}")]
        [ProducesResponseType(typeof(UserDTO), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> GetUserById(int userId, CancellationToken cancellationToken)
        {
            var query = new GetUserByIdFromMemoryQuery(userId);

            var user = await _sender.Send(query, cancellationToken);

            return Ok(user);
        }

        ///// <summary>
        ///// Creates a new user based on the specified request.
        ///// </summary>
        ///// <param name="command">The create user request.</param>
        ///// <param name="cancellationToken">The cancellation token.</param>
        ///// <returns>The newly created user.</returns>
        //[HttpPost]
        //[ProducesResponseType(typeof(UserDTO), StatusCodes.Status201Created)]
        //public async Task<IActionResult> CreateUser([FromBody] CreateUserCommand command, CancellationToken cancellationToken)
        //{
        //    var user = await _sender.Send(command, cancellationToken);

        //    return CreatedAtAction(nameof(GetUserById), new { userId = user.Id }, user);
        //}

        ///// <summary>
        ///// Updates the user with the specified identifier based on the specified request, if it exists.
        ///// </summary>
        ///// <param name="userId">The user identifier.</param>
        ///// <param name="command">The update user request.</param>
        ///// <param name="cancellationToken">The cancellation token.</param>
        ///// <returns>No content.</returns>
        //[HttpPut("{userId:int}")]
        //[ProducesResponseType(StatusCodes.Status204NoContent)]
        //[ProducesResponseType(StatusCodes.Status404NotFound)]
        //public async Task<IActionResult> UpdateUser(int userId, [FromBody] UpdateUserCommand command, CancellationToken cancellationToken)
        //{
        //    command.Id = userId;

        //    await _sender.Send(command, cancellationToken);

        //    return NoContent();
        //}
    }
}
