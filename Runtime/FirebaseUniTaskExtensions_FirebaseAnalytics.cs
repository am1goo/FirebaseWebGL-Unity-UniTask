using Cysharp.Threading.Tasks;
using System;
using System.Threading;

namespace FirebaseWebGL
{
    public static partial class FirebaseUniTaskExtensions
    {
        public static async UniTask<bool> InitializeAsync(this IFirebaseAnalytics sdk, CancellationToken cancellationToken)
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

        public static async UniTask<string> GetGoogleAnalyticsClientIdAsync(this IFirebaseAnalytics sdk, CancellationToken cancellationToken)
        {
            var tcs = new UniTaskCompletionSource<string>();
            await using (cancellationToken.Register(() => tcs.TrySetCanceled()))
            {
                sdk.GetGoogleAnalyticsClientId((callback) =>
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
