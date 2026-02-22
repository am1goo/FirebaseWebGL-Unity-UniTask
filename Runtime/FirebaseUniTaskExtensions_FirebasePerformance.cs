using Cysharp.Threading.Tasks;
using FirebaseWebGL;
using System;
using System.Threading;

public static partial class FirebaseUniTaskExtensions
{
    public static async UniTask<bool> InitializeAsync(this IFirebasePerformance sdk, CancellationToken cancellationToken)
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
}
