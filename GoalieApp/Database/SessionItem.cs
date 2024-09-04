// <copyright file="SessionItem.cs" company="Mark Oberg">
// Copyright (c) Mark Oberg. All rights reserved.
// </copyright>

namespace GoalieApp.Database;

using System;
using CommunityToolkit.Mvvm.ComponentModel;
using SQLite;

/// <summary>
/// Database session item class.
/// </summary>
public class SessionItem : ObservableObject
{
    private int id;
    private uint saves;
    private uint goals;
    private SessionTypes sessionTypes;
    private DateTime? started;
    private DateTime? completed;

    /// <summary>
    /// Gets or sets the Id.
    /// </summary>
    [PrimaryKey]
    [AutoIncrement]
    public int Id { get => this.id; set => this.SetProperty(ref this.id, value); }

    /// <summary>
    /// Gets or sets the saves.
    /// </summary>
    public uint Saves { get => this.saves; set => this.SetProperty(ref this.saves, value); }

    /// <summary>
    /// Gets or sets the goals.
    /// </summary>
    public uint Goals { get => this.goals; set => this.SetProperty(ref this.goals, value); }

    /// <summary>
    /// Gets or sets the session type.
    /// </summary>
    public SessionTypes SessionType { get => this.sessionTypes; set => this.SetProperty(ref this.sessionTypes, value); }

    /// <summary>
    /// Gets or sets the started date/time.
    /// </summary>
    public DateTime? Started { get => this.started; set => this.SetProperty(ref this.started, value); }

    /// <summary>
    /// Gets or sets the completed date/time.
    /// </summary>
    public DateTime? Completed { get => this.completed; set => this.SetProperty(ref this.completed, value); }
}
