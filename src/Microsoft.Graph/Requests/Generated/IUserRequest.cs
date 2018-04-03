// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Requests\IEntityRequest.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The interface IUserRequest.
    /// </summary>
    public partial interface IUserRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified User using PUT.
        /// </summary>
        /// <param name="userToCreate">The User to create.</param>
        /// <returns>The created User.</returns>
        System.Threading.Tasks.Task<User> CreateAsync(User userToCreate);        /// <summary>
        /// Creates the specified User using PUT.
        /// </summary>
        /// <param name="userToCreate">The User to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created User.</returns>
        System.Threading.Tasks.Task<User> CreateAsync(User userToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified User.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified User.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified User.
        /// </summary>
        /// <returns>The User.</returns>
        System.Threading.Tasks.Task<User> GetAsync();

        BatchPart<User> BatchPartGet(IBatchPart batchPart);

        /// <summary>
        /// Gets the specified User.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The User.</returns>
        System.Threading.Tasks.Task<User> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified User using PATCH.
        /// </summary>
        /// <param name="userToUpdate">The User to update.</param>
        /// <returns>The updated User.</returns>
        System.Threading.Tasks.Task<User> UpdateAsync(User userToUpdate);

        /// <summary>
        /// Updates the specified User using PATCH.
        /// </summary>
        /// <param name="userToUpdate">The User to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The updated User.</returns>
        System.Threading.Tasks.Task<User> UpdateAsync(User userToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IUserRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IUserRequest Expand(Expression<Func<User, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IUserRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IUserRequest Select(Expression<Func<User, object>> selectExpression);

    }
}
