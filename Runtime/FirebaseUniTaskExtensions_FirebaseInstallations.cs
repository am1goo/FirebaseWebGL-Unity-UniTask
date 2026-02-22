using Cysharp.Threading.Tasks;
using FirebaseWebGL;
using System;
using System.Threading;

public static partial class FirebaseUniTaskExtensions
{
    public static async UniTask<bool> InitializeAsync(this IFirebaseInstallations sdk, CancellationToken cancellationToken)
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

    public static async UniTask<bool> DeleteInstallationsAsync(this IFirebaseInstallations sdk, CancellationToken cancellationToken)
    {
        var tcs = new UniTaskCompletionSource<bool>();
        await using (cancellationToken.Register(() => tcs.TrySetCanceled()))
        {
            sdk.DeleteInstallations((callback) =>
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

    public static async UniTask<string> GetIdAsync(this IFirebaseInstallations sdk, CancellationToken cancellationToken)
    {
        var tcs = new UniTaskCompletionSource<string>();
        await using (cancellationToken.Register(() => tcs.TrySetCanceled()))
        {
            sdk.GetId((callback) =>
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

    public static async UniTask<string> GetTokenAsync(this IFirebaseInstallations sdk, bool forceRefresh, CancellationToken cancellationToken)
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
