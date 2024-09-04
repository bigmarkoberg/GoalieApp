// <copyright file="MainActivity.cs" company="Mark Oberg">
// Copyright (c) Mark Oberg. All rights reserved.
// </copyright>

namespace GoalieApp;

using Android.App;
using Android.Content.PM;

/// <summary>
/// Main activity class.
/// </summary>
[Activity(Theme = "@style/Maui.SplashTheme", MainLauncher = true, LaunchMode = LaunchMode.SingleTop, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation | ConfigChanges.UiMode | ConfigChanges.ScreenLayout | ConfigChanges.SmallestScreenSize | ConfigChanges.Density)]
public class MainActivity : MauiAppCompatActivity
{
}
