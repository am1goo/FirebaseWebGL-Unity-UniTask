using Cysharp.Threading.Tasks;
using FirebaseWebGL;
using System;
using System.Threading;

public static partial class FirebaseUniTaskExtensions
{
    public static async UniTask<bool> InitializeAsync(this IFirebaseFunctions sdk, CancellationToken cancellationToken)
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

    public static async UniTask<RESP> RequestAsync<RESP>(this IFirebaseFunctionsHttpsCallable sdk, CancellationToken cancellationToken)
    {
        var tcs = new UniTaskCompletionSource<RESP>();
        await using (cancellationToken.Register(() => tcs.TrySetCanceled()))
        {
            sdk.Request<RESP>((callback) =>
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

    public static async UniTask<RESP> RequestAsync<REQ, RESP>(this IFirebaseFunctionsHttpsCallable sdk, REQ data, CancellationToken cancellationToken)
    {
        var tcs = new UniTaskCompletionSource<RESP>();
        await using (cancellationToken.Register(() => tcs.TrySetCanceled()))
        {
            sdk.Request<REQ, RESP>(data, (callback) =>
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
