using Cysharp.Threading.Tasks;
using FirebaseWebGL;
using System;
using System.Collections.Generic;
using System.Threading;

public static partial class FirebaseUniTaskExtensions
{
    public static async UniTask<bool> DeleteUserAsync(this IFirebaseAuthLoggedUser sdk, CancellationToken cancellationToken)
    {
        var tcs = new UniTaskCompletionSource<bool>();
        await using (cancellationToken.Register(() => tcs.TrySetCanceled()))
        {
            sdk.DeleteUser((callback) =>
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

    public static async UniTask<string> GetIdTokenAsync(this IFirebaseAuthLoggedUser sdk, bool forceRefresh, CancellationToken cancellationToken)
    {
        var tcs = new UniTaskCompletionSource<string>();
        await using (cancellationToken.Register(() => tcs.TrySetCanceled()))
        {
            sdk.GetIdToken(forceRefresh, (callback) =>
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

    public static async UniTask<FirebaseAuthIdTokenResult> GetIdTokenResultAsync(this IFirebaseAuthLoggedUser sdk, bool forceRefresh, CancellationToken cancellationToken)
    {
        var tcs = new UniTaskCompletionSource<FirebaseAuthIdTokenResult>();
        await using (cancellationToken.Register(() => tcs.TrySetCanceled()))
        {
            sdk.GetIdTokenResult(forceRefresh, (callback) =>
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

    public static async UniTask<bool> ReloadAsync(this IFirebaseAuthLoggedUser sdk, CancellationToken cancellationToken)
    {
        var tcs = new UniTaskCompletionSource<bool>();
        await using (cancellationToken.Register(() => tcs.TrySetCanceled()))
        {
            sdk.Reload((callback) =>
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

    public static async UniTask<FirebaseAuthUserCredential> LinkWithCredentialAsync(this IFirebaseAuthLoggedUser sdk, FirebaseAuthCredential credential, CancellationToken cancellationToken)
    {
        var tcs = new UniTaskCompletionSource<FirebaseAuthUserCredential>();
        await using (cancellationToken.Register(() => tcs.TrySetCanceled()))
        {
            sdk.LinkWithCredential(credential, (callback) =>
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

    public static async UniTask<FirebaseAuthUserCredential> LinkInWithPopupAsync(this IFirebaseAuthLoggedUser sdk, string providerId, CancellationToken cancellationToken)
    {
        var tcs = new UniTaskCompletionSource<FirebaseAuthUserCredential>();
        await using (cancellationToken.Register(() => tcs.TrySetCanceled()))
        {
            sdk.LinkInWithPopup(providerId, (callback) =>
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

    public static async UniTask<FirebaseAuthUserCredential> LinkInWithPopupAsync(this IFirebaseAuthLoggedUser sdk, string providerId, Dictionary<string, string> customParameters, CancellationToken cancellationToken)
    {
        var tcs = new UniTaskCompletionSource<FirebaseAuthUserCredential>();
        await using (cancellationToken.Register(() => tcs.TrySetCanceled()))
        {
            sdk.LinkInWithPopup(providerId, customParameters, (callback) =>
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

    public static async UniTask<FirebaseAuthUserCredential> ReauthenticateInWithPopupAsync(this IFirebaseAuthLoggedUser sdk, string providerId, CancellationToken cancellationToken)
    {
        var tcs = new UniTaskCompletionSource<FirebaseAuthUserCredential>();
        await using (cancellationToken.Register(() => tcs.TrySetCanceled()))
        {
            sdk.ReauthenticateInWithPopup(providerId, (callback) =>
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

    public static async UniTask<FirebaseAuthUserCredential> ReauthenticateInWithPopupAsync(this IFirebaseAuthLoggedUser sdk, string providerId, Dictionary<string, string> customParameters, CancellationToken cancellationToken)
    {
        var tcs = new UniTaskCompletionSource<FirebaseAuthUserCredential>();
        await using (cancellationToken.Register(() => tcs.TrySetCanceled()))
        {
            sdk.ReauthenticateInWithPopup(providerId, customParameters, (callback) =>
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

    public static async UniTask<bool> SendEmailVerificationAsync(this IFirebaseAuthLoggedUser sdk, string providerId, CancellationToken cancellationToken)
    {
        var tcs = new UniTaskCompletionSource<bool>();
        await using (cancellationToken.Register(() => tcs.TrySetCanceled()))
        {
            sdk.SendEmailVerification((callback) =>
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

    public static async UniTask<bool> SendEmailVerificationAsync(this IFirebaseAuthLoggedUser sdk, FirebaseAuthActionCodeSettings actionCodeSettings, CancellationToken cancellationToken)
    {
        var tcs = new UniTaskCompletionSource<bool>();
        await using (cancellationToken.Register(() => tcs.TrySetCanceled()))
        {
            sdk.SendEmailVerification(actionCodeSettings, (callback) =>
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

    public static async UniTask<FirebaseAuthUser> UnlinkAsync(this IFirebaseAuthLoggedUser sdk, string providerId, CancellationToken cancellationToken)
    {
        var tcs = new UniTaskCompletionSource<FirebaseAuthUser>();
        await using (cancellationToken.Register(() => tcs.TrySetCanceled()))
        {
            sdk.Unlink(providerId, (callback) =>
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

    public static async UniTask<bool> UpdateEmailAsync(this IFirebaseAuthLoggedUser sdk, string newEmail, CancellationToken cancellationToken)
    {
        var tcs = new UniTaskCompletionSource<bool>();
        await using (cancellationToken.Register(() => tcs.TrySetCanceled()))
        {
            sdk.UpdateEmail(newEmail, (callback) =>
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

    public static async UniTask<bool> UpdatePasswordAsync(this IFirebaseAuthLoggedUser sdk, string newPassword, CancellationToken cancellationToken)
    {
        var tcs = new UniTaskCompletionSource<bool>();
        await using (cancellationToken.Register(() => tcs.TrySetCanceled()))
        {
            sdk.UpdatePassword(newPassword, (callback) =>
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

    public static async UniTask<bool> UpdateProfileAsync(this IFirebaseAuthLoggedUser sdk, string displayName, string photoURL, CancellationToken cancellationToken)
    {
        var tcs = new UniTaskCompletionSource<bool>();
        await using (cancellationToken.Register(() => tcs.TrySetCanceled()))
        {
            sdk.UpdateProfile(displayName, photoURL, (callback) =>
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

    public static async UniTask<bool> VerifyBeforeUpdateEmailAsync(this IFirebaseAuthLoggedUser sdk, string newEmail, CancellationToken cancellationToken)
    {
        var tcs = new UniTaskCompletionSource<bool>();
        await using (cancellationToken.Register(() => tcs.TrySetCanceled()))
        {
            sdk.VerifyBeforeUpdateEmail(newEmail, (callback) =>
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

    public static async UniTask<bool> VerifyBeforeUpdateEmailAsync(this IFirebaseAuthLoggedUser sdk, string newEmail, FirebaseAuthActionCodeSettings actionCodeSettings, CancellationToken cancellationToken)
    {
        var tcs = new UniTaskCompletionSource<bool>();
        await using (cancellationToken.Register(() => tcs.TrySetCanceled()))
        {
            sdk.VerifyBeforeUpdateEmail(newEmail, actionCodeSettings, (callback) =>
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
