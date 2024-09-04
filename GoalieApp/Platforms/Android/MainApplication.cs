// <copyright file="MainApplication.cs" company="Mark Oberg">
// Copyright (c) Mark Oberg. All rights reserved.
// </copyright>

namespace GoalieApp;

using Android.App;
using Android.Runtime;

/// <summary>
/// Main application class.
/// </summary>
[Application]
public class MainApplication : MauiApplication
{
    /// <summary>
    /// Initializes a new instance of the <see cref="MainApplication"/> class.
    /// </summary>
    /// <param name="handle">Handle.</param>
    /// <param name="ownership">Owner.</param>
    public MainApplication(IntPtr handle, JniHandleOwnership ownership)
        : base(handle, ownership)
    {
    }

    /// <inheritdoc/>
    protected override MauiApp CreateMauiApp() => MauiProgram.CreateMauiApp();
}
