// <copyright file="Program.cs" company="Mark Oberg">
// Copyright (c) Mark Oberg. All rights reserved.
// </copyright>

namespace GoalieApp;

using UIKit;

/// <summary>
/// Program class.
/// </summary>
public class Program
{
    /// <summary>
    /// This is the main entry point of the application.
    /// </summary>
    /// <param name="args">Arguments.</param>
    public static void Main(string[] args)
    {
        // if you want to use a different Application Delegate class from "AppDelegate"
        // you can specify it here.
        UIApplication.Main(args, null, typeof(AppDelegate));
    }
}
