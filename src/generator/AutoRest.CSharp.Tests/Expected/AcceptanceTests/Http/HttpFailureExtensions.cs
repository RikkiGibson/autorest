// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Fixtures.AcceptanceTestsHttp
{
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for HttpFailure.
    /// </summary>
    public static partial class HttpFailureExtensions
    {
            /// <summary>
            /// Get empty error form server
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static bool? GetEmptyError(this IHttpFailure operations)
            {
                return operations.GetEmptyErrorAsync().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get empty error form server
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<bool?> GetEmptyErrorAsync(this IHttpFailure operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetEmptyErrorWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get empty error form server
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static bool? GetNoModelError(this IHttpFailure operations)
            {
                return operations.GetNoModelErrorAsync().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get empty error form server
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<bool?> GetNoModelErrorAsync(this IHttpFailure operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetNoModelErrorWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get empty response from server
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static bool? GetNoModelEmpty(this IHttpFailure operations)
            {
                return operations.GetNoModelEmptyAsync().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get empty response from server
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<bool?> GetNoModelEmptyAsync(this IHttpFailure operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetNoModelEmptyWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
