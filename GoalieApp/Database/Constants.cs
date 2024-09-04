// <copyright file="Constants.cs" company="Mark Oberg">
// Copyright (c) Mark Oberg. All rights reserved.
// </copyright>

namespace GoalieApp.Database;

/// <summary>
/// Constants for database.
/// </summary>
internal class Constants
{
    /// <summary>
    /// Database filename.
    /// </summary>
    internal const string DatabaseFilename = "GoalieAppSQLite.db3";

    /// <summary>
    /// Database flags.
    /// </summary>
    internal const SQLite.SQLiteOpenFlags Flags =
        SQLite.SQLiteOpenFlags.ReadWrite | // open the database in read/write mode
        SQLite.SQLiteOpenFlags.Create | // create the database if it doesn't exist
        SQLite.SQLiteOpenFlags.SharedCache; // enable multi-threaded database access

    /// <summary>
    /// Gets the database path.
    /// </summary>
    internal static string DatabasePath =>
        Path.Combine(FileSystem.AppDataDirectory, DatabaseFilename);
}
