using Cysharp.Threading.Tasks;
using FirebaseWebGL;
using System;
using System.Threading;

public static partial class FirebaseUniTaskExtensions
{
    public static async UniTask<byte[]> GetBytesAsync(this IFirebaseStorageReference sdk, CancellationToken cancellationToken)
    {
        var tcs = new UniTaskCompletionSource<byte[]>();
        await using (cancellationToken.Register(() => tcs.TrySetCanceled()))
        {
            sdk.GetBytes((callback) =>
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

    public static async UniTask<byte[]> GetBytesAsync(this IFirebaseStorageReference sdk, int maxDownloadSizeBytes, CancellationToken cancellationToken)
    {
        var tcs = new UniTaskCompletionSource<byte[]>();
        await using (cancellationToken.Register(() => tcs.TrySetCanceled()))
        {
            sdk.GetBytes(maxDownloadSizeBytes, (callback) =>
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

    public static async UniTask<string> GetDownloadURLAsync(this IFirebaseStorageReference sdk, CancellationToken cancellationToken)
    {
        var tcs = new UniTaskCompletionSource<string>();
        await using (cancellationToken.Register(() => tcs.TrySetCanceled()))
        {
            sdk.GetDownloadURL((callback) =>
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

    public static async UniTask<FirebaseStorageReferenceFullMetadata> GetMetadataAsync(this IFirebaseStorageReference sdk, CancellationToken cancellationToken)
    {
        var tcs = new UniTaskCompletionSource<FirebaseStorageReferenceFullMetadata>();
        await using (cancellationToken.Register(() => tcs.TrySetCanceled()))
        {
            sdk.GetMetadata((callback) =>
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

    public static async UniTask<FirebaseStorageReferenceFullMetadata> UpdateMetadataAsync(this IFirebaseStorageReference sdk, FirebaseStorageReferenceFullMetadata metadata, CancellationToken cancellationToken)
    {
        var tcs = new UniTaskCompletionSource<FirebaseStorageReferenceFullMetadata>();
        await using (cancellationToken.Register(() => tcs.TrySetCanceled()))
        {
            sdk.UpdateMetadata(metadata, (callback) =>
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

    public static async UniTask<FirebaseStorageReferenceListResult> ListAsync(this IFirebaseStorageReference sdk, CancellationToken cancellationToken)
    {
        var tcs = new UniTaskCompletionSource<FirebaseStorageReferenceListResult>();
        await using (cancellationToken.Register(() => tcs.TrySetCanceled()))
        {
            sdk.List((callback) =>
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

    public static async UniTask<FirebaseStorageReferenceListResult> ListAsync(this IFirebaseStorageReference sdk, FirebaseStorageReferenceListOptions options, CancellationToken cancellationToken)
    {
        var tcs = new UniTaskCompletionSource<FirebaseStorageReferenceListResult>();
        await using (cancellationToken.Register(() => tcs.TrySetCanceled()))
        {
            sdk.List(options, (callback) =>
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

    public static async UniTask<FirebaseStorageReferenceUploadResult> UploadBytesAsync(this IFirebaseStorageReference sdk, byte[] data, CancellationToken cancellationToken)
    {
        var tcs = new UniTaskCompletionSource<FirebaseStorageReferenceUploadResult>();
        await using (cancellationToken.Register(() => tcs.TrySetCanceled()))
        {
            sdk.UploadBytes(data, (callback) =>
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

    public static async UniTask<FirebaseStorageReferenceUploadResult> UploadBytesAsync(this IFirebaseStorageReference sdk, byte[] data, FirebaseStorageReferenceUploadMetadata metadata, CancellationToken cancellationToken)
    {
        var tcs = new UniTaskCompletionSource<FirebaseStorageReferenceUploadResult>();
        await using (cancellationToken.Register(() => tcs.TrySetCanceled()))
        {
            sdk.UploadBytes(data, metadata, (callback) =>
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

    public static async UniTask<FirebaseStorageReferenceUploadResult> UploadStringAsync(this IFirebaseStorageReference sdk, string value, FirebaseStorageReferenceStringFormat? format, CancellationToken cancellationToken)
    {
        var tcs = new UniTaskCompletionSource<FirebaseStorageReferenceUploadResult>();
        await using (cancellationToken.Register(() => tcs.TrySetCanceled()))
        {
            sdk.UploadString(value, format, (callback) =>
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

    public static async UniTask<FirebaseStorageReferenceUploadResult> UploadStringAsync(this IFirebaseStorageReference sdk, string value, FirebaseStorageReferenceStringFormat? format, FirebaseStorageReferenceUploadMetadata metadata, CancellationToken cancellationToken)
    {
        var tcs = new UniTaskCompletionSource<FirebaseStorageReferenceUploadResult>();
        await using (cancellationToken.Register(() => tcs.TrySetCanceled()))
        {
            sdk.UploadString(value, format, metadata, (callback) =>
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
