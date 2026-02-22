using Cysharp.Threading.Tasks;
using FirebaseWebGL;
using System;
using System.Threading;

public static partial class FirebaseUniTaskExtensions
{
    public static async UniTask<bool> InitializeAsync(this IFirebaseRemoteConfig sdk, CancellationToken cancellationToken)
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

    public static async UniTask<bool> ActivateAsync(this IFirebaseRemoteConfig sdk, CancellationToken cancellationToken)
    {
        var tcs = new UniTaskCompletionSource<bool>();
        await using (cancellationToken.Register(() => tcs.TrySetCanceled()))
        {
            sdk.Activate((callback) =>
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

    public static async UniTask<bool> EnsureInitializedAsync(this IFirebaseRemoteConfig sdk, CancellationToken cancellationToken)
    {
        var tcs = new UniTaskCompletionSource<bool>();
        await using (cancellationToken.Register(() => tcs.TrySetCanceled()))
        {
            sdk.EnsureInitialized((callback) =>
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

    public static async UniTask<bool> FetchAndActivateAsync(this IFirebaseRemoteConfig sdk, CancellationToken cancellationToken)
    {
        var tcs = new UniTaskCompletionSource<bool>();
        await using (cancellationToken.Register(() => tcs.TrySetCanceled()))
        {
            sdk.FetchAndActivate((callback) =>
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

    public static async UniTask<bool> FetchConfigAsync(this IFirebaseRemoteConfig sdk, CancellationToken cancellationToken)
    {
        var tcs = new UniTaskCompletionSource<bool>();
        await using (cancellationToken.Register(() => tcs.TrySetCanceled()))
        {
            sdk.FetchConfig((callback) =>
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
