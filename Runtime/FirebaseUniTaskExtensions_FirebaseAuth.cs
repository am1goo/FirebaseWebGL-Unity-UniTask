using Cysharp.Threading.Tasks;
using FirebaseWebGL;
using System;
using System.Collections.Generic;
using System.Threading;

public static partial class FirebaseUniTaskExtensions
{
    public static async UniTask<bool> InitializeAsync(this IFirebaseAuth sdk, CancellationToken cancellationToken)
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

    public static async UniTask<bool> ApplyActionCodeAsync(this IFirebaseAuth sdk, string oobCode, CancellationToken cancellationToken)
    {
        var tcs = new UniTaskCompletionSource<bool>();
        await using (cancellationToken.Register(() => tcs.TrySetCanceled()))
        {
            sdk.ApplyActionCode(oobCode, (callback) =>
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

    public static async UniTask<FirebaseAuthActionCodeInfo> CheckActionCodeAsync(this IFirebaseAuth sdk, string oobCode, CancellationToken cancellationToken)
    {
        var tcs = new UniTaskCompletionSource<FirebaseAuthActionCodeInfo>();
        await using (cancellationToken.Register(() => tcs.TrySetCanceled()))
        {
            sdk.CheckActionCode(oobCode, (callback) =>
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

    public static async UniTask<bool> ConfirmPasswordResetAsync(this IFirebaseAuth sdk, string oobCode, string newPassword, CancellationToken cancellationToken)
    {
        var tcs = new UniTaskCompletionSource<bool>();
        await using (cancellationToken.Register(() => tcs.TrySetCanceled()))
        {
            sdk.ConfirmPasswordReset(oobCode, newPassword, (callback) =>
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

    public static async UniTask<FirebaseAuthUserCredential> CreateUserWithEmailAndPasswordAsync(this IFirebaseAuth sdk, string email, string password, CancellationToken cancellationToken)
    {
        var tcs = new UniTaskCompletionSource<FirebaseAuthUserCredential>();
        await using (cancellationToken.Register(() => tcs.TrySetCanceled()))
        {
            sdk.CreateUserWithEmailAndPassword(email, password, (callback) =>
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

    public static async UniTask<string[]> FetchSignInMethodsForEmailAsync(this IFirebaseAuth sdk, string email, CancellationToken cancellationToken)
    {
        var tcs = new UniTaskCompletionSource<string[]>();
        await using (cancellationToken.Register(() => tcs.TrySetCanceled()))
        {
            sdk.FetchSignInMethodsForEmail(email, (callback) =>
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

    public static async UniTask<bool> InitializeRecaptchaConfigAsync(this IFirebaseAuth sdk, CancellationToken cancellationToken)
    {
        var tcs = new UniTaskCompletionSource<bool>();
        await using (cancellationToken.Register(() => tcs.TrySetCanceled()))
        {
            sdk.InitializeRecaptchaConfig((callback) =>
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

    public static async UniTask<bool> RevokeAccessTokenAsync(this IFirebaseAuth sdk, string token, CancellationToken cancellationToken)
    {
        var tcs = new UniTaskCompletionSource<bool>();
        await using (cancellationToken.Register(() => tcs.TrySetCanceled()))
        {
            sdk.RevokeAccessToken(token, (callback) =>
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

    public static async UniTask<bool> SendPasswordResetEmailAsync(this IFirebaseAuth sdk, string email, FirebaseAuthActionCodeSettings actionCodeSettings, CancellationToken cancellationToken)
    {
        var tcs = new UniTaskCompletionSource<bool>();
        await using (cancellationToken.Register(() => tcs.TrySetCanceled()))
        {
            sdk.SendPasswordResetEmail(email, actionCodeSettings, (callback) =>
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

    public static async UniTask<bool> SendSignInLinkToEmailAsync(this IFirebaseAuth sdk, string email, FirebaseAuthActionCodeSettings actionCodeSettings, CancellationToken cancellationToken)
    {
        var tcs = new UniTaskCompletionSource<bool>();
        await using (cancellationToken.Register(() => tcs.TrySetCanceled()))
        {
            sdk.SendSignInLinkToEmail(email, actionCodeSettings, (callback) =>
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

    public static async UniTask<FirebaseAuthUserCredential> SignInAnonymouslyAsync(this IFirebaseAuth sdk, CancellationToken cancellationToken)
    {
        var tcs = new UniTaskCompletionSource<FirebaseAuthUserCredential>();
        await using (cancellationToken.Register(() => tcs.TrySetCanceled()))
        {
            sdk.SignInAnonymously((callback) =>
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

    public static async UniTask<FirebaseAuthUserCredential> SignInWithCredentialAsync(this IFirebaseAuth sdk, FirebaseAuthCredential credential, CancellationToken cancellationToken)
    {
        var tcs = new UniTaskCompletionSource<FirebaseAuthUserCredential>();
        await using (cancellationToken.Register(() => tcs.TrySetCanceled()))
        {
            sdk.SignInWithCredential(credential, (callback) =>
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

    public static async UniTask<FirebaseAuthUserCredential> SignInWithCustomTokenAsync(this IFirebaseAuth sdk, string customToken, CancellationToken cancellationToken)
    {
        var tcs = new UniTaskCompletionSource<FirebaseAuthUserCredential>();
        await using (cancellationToken.Register(() => tcs.TrySetCanceled()))
        {
            sdk.SignInWithCustomToken(customToken, (callback) =>
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

    public static async UniTask<FirebaseAuthUserCredential> SignInWithEmailAndPasswordAsync(this IFirebaseAuth sdk, string email, string password, CancellationToken cancellationToken)
    {
        var tcs = new UniTaskCompletionSource<FirebaseAuthUserCredential>();
        await using (cancellationToken.Register(() => tcs.TrySetCanceled()))
        {
            sdk.SignInWithEmailAndPassword(email, password, (callback) =>
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

    public static async UniTask<FirebaseAuthUserCredential> SignInWithEmailLinkAsync(this IFirebaseAuth sdk, string email, string emailLink, CancellationToken cancellationToken)
    {
        var tcs = new UniTaskCompletionSource<FirebaseAuthUserCredential>();
        await using (cancellationToken.Register(() => tcs.TrySetCanceled()))
        {
            sdk.SignInWithEmailLink(email, emailLink, (callback) =>
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

    public static async UniTask<FirebaseAuthUserCredential> SignInWithPopupAsync(this IFirebaseAuth sdk, string providerId, CancellationToken cancellationToken)
    {
        var tcs = new UniTaskCompletionSource<FirebaseAuthUserCredential>();
        await using (cancellationToken.Register(() => tcs.TrySetCanceled()))
        {
            sdk.SignInWithPopup(providerId, (callback) =>
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

    public static async UniTask<FirebaseAuthUserCredential> SignInWithPopupAsync(this IFirebaseAuth sdk, string providerId, Dictionary<string, string> customParameters, CancellationToken cancellationToken)
    {
        var tcs = new UniTaskCompletionSource<FirebaseAuthUserCredential>();
        await using (cancellationToken.Register(() => tcs.TrySetCanceled()))
        {
            sdk.SignInWithPopup(providerId, customParameters, (callback) =>
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

    public static async UniTask<bool> SignOutAsync(this IFirebaseAuth sdk, CancellationToken cancellationToken)
    {
        var tcs = new UniTaskCompletionSource<bool>();
        await using (cancellationToken.Register(() => tcs.TrySetCanceled()))
        {
            sdk.SignOut((callback) =>
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

    public static async UniTask<bool> UpdateCurrentUserAsync(this IFirebaseAuth sdk, FirebaseAuthUser user, CancellationToken cancellationToken)
    {
        var tcs = new UniTaskCompletionSource<bool>();
        await using (cancellationToken.Register(() => tcs.TrySetCanceled()))
        {
            sdk.UpdateCurrentUser(user, (callback) =>
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

    public static async UniTask<FirebaseAuthPasswordValidationStatus> ValidatePasswordAsync(this IFirebaseAuth sdk, string password, CancellationToken cancellationToken)
    {
        var tcs = new UniTaskCompletionSource<FirebaseAuthPasswordValidationStatus>();
        await using (cancellationToken.Register(() => tcs.TrySetCanceled()))
        {
            sdk.ValidatePassword(password, (callback) =>
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

    public static async UniTask<string> VerifyPasswordResetCodeAsync(this IFirebaseAuth sdk, string password, CancellationToken cancellationToken)
    {
        var tcs = new UniTaskCompletionSource<string>();
        await using (cancellationToken.Register(() => tcs.TrySetCanceled()))
        {
            sdk.VerifyPasswordResetCode(password, (callback) =>
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
