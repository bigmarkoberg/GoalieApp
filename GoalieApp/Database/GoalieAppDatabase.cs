// <copyright file="GoalieAppDatabase.cs" company="Mark Oberg">
// Copyright (c) Mark Oberg. All rights reserved.
// </copyright>

namespace GoalieApp.Database;

using System.Threading.Tasks;
using SQLite;

/// <summary>
/// Database class for the application.
/// </summary>
public class GoalieAppDatabase
{
    private SQLiteAsyncConnection? database;

    /// <summary>
    /// Initializes a new instance of the <see cref="GoalieAppDatabase"/> class.
    /// </summary>
    public GoalieAppDatabase()
    {
    }

    /// <summary>
    /// Initializes the database.
    /// </summary>
    /// <returns>Asynchronous task.</returns>
    public async Task Init()
    {
        if (this.database is not null)
        {
            return;
        }

        this.database = new SQLiteAsyncConnection(Constants.DatabasePath, Constants.Flags);
        _ = await this.database.CreateTableAsync<SessionItem>();
    }

    /// <summary>
    /// Gets all the sessions.
    /// </summary>
    /// <returns>List of session items or null.</returns>
    public async Task<List<SessionItem>?> GetSessions()
    {
        await this.Init();
        if (this.database?.Table<SessionItem>() is AsyncTableQuery<SessionItem> query)
        {
            return await query.ToListAsync();
        }

        return null;
    }

    /// <summary>
    /// Save session.
    /// </summary>
    /// <param name="item">Session to save.</param>
    /// <returns>Id of session saved or -1.</returns>
    public async Task<int> SaveSessionAsync(SessionItem item)
    {
        await this.Init();
        if (this.database is null)
        {
            return -1;
        }

        if (item.Id != 0)
        {
            return await this.database.UpdateAsync(item);
        }
        else
        {
            return await this.database.InsertAsync(item);
        }
    }

    /// <summary>
    /// Delete session.
    /// </summary>
    /// <param name="item">Session to delete.</param>
    /// <returns>Id of of session deleted or -1.</returns>
    public async Task<int> DeleteSessionAsync(SessionItem item)
    {
        await this.Init();
        if (this.database is null)
        {
            return -1;
        }

        return await this.database.DeleteAsync(item);
    }
}
