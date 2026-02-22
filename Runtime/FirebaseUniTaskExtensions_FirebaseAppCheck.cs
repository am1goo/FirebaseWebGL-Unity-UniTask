using Cysharp.Threading.Tasks;
using System;
using System.Threading;

namespace FirebaseWebGL
{
    public static partial class FirebaseUniTaskExtensions
    {
        public static async UniTask<bool> InitializeAsync(this IFirebaseAppCheck sdk, CancellationToken cancellationToken)
        {
            var tcs = new UniTaskCompletionSource<bool>();
            await using (cancellationToken.Register(() => tcs.TrySetCanceled()))
            {
                sdk.Initialize((callback) =>
                {
                    if (callback.success)
                    {
                        tcs.TrySetResult(callback.result);
                    }
                    else
                    {
                        tcs.TrySetException(new Exception(callback.error));
                    }
                });
                return await tcs.Task;
            }
        }

        public static async UniTask<string> GetLimitedUseTokenAsync(this IFirebaseAppCheck sdk, CancellationToken cancellationToken)
        {
            var tcs = new UniTaskCompletionSource<string>();
            await using (cancellationToken.Register(() => tcs.TrySetCanceled()))
            {
                sdk.GetLimitedUseToken((callback) =>
                {
                    if (callback.success)
                    {
                        tcs.TrySetResult(callback.result);
                    }
                    else
                    {
                        tcs.TrySetException(new Exception(callback.error));
                    }
                });
                return await tcs.Task;
            }
        }

        public static async UniTask<string> GetTokenAsync(this IFirebaseAppCheck sdk, bool forceRefresh, CancellationToken cancellationToken)
        {
            var tcs = new UniTaskCompletionSource<string>();
            await using (cancellationToken.Register(() => tcs.TrySetCanceled()))
            {
                sdk.GetToken(forceRefresh, (callback) =>
                {
                    if (callback.success)
                    {
                        tcs.TrySetResult(callback.result);
                    }
                    else
                    {
                        tcs.TrySetException(new Exception(callback.error));
                    }
                });
                return await tcs.Task;
            }
        }
    }
}
