// <copyright file="MainPageViewModel.cs" company="Mark Oberg">
// Copyright (c) Mark Oberg. All rights reserved.
// </copyright>

namespace GoalieApp.ViewModels;

using CommunityToolkit.Mvvm.ComponentModel;

/// <summary>
/// Main page view model.
/// </summary>
public partial class MainPageViewModel : ObservableObject
{
    private uint saves = 0;
    private uint goals = 0;

    /// <summary>
    /// Initializes a new instance of the <see cref="MainPageViewModel"/> class.
    /// </summary>
    public MainPageViewModel()
    {
        this.GoalsChangeCommand = new(
        (value) =>
        {
            if (!int.TryParse(value?.ToString() ?? string.Empty, out var i) ||
            (this.Goals == 0 && i < 0))
            {
                return;
            }

            this.Goals = (uint)(this.Goals + i);
        });
        this.SavesChangeCommand = new(
        (value) =>
        {
            if (!int.TryParse(value?.ToString() ?? string.Empty, out var i) ||
            (this.Saves == 0 && i < 0))
            {
                return;
            }

            this.Saves = (uint)(this.Saves + i);
        });
        this.ResetCommand = new(() =>
        {
            this.Saves = 0;
            this.Goals = 0;
        });
    }

    /// <summary>
    /// Gets the reset command.
    /// </summary>
    public Command ResetCommand { get; }

    /// <summary>
    /// Gets the goals change command.
    /// </summary>
    public Command GoalsChangeCommand { get; }

    /// <summary>
    /// Gets the saves change command.
    /// </summary>
    public Command SavesChangeCommand { get; }

    /// <summary>
    /// Gets the total.
    /// </summary>
    public uint Total
    {
        get => this.Saves + this.Goals;
    }

    /// <summary>
    /// Gets the percentage.
    /// </summary>
    public decimal Percentage
    {
        get => this.Total == 0 ? 0 : Math.Round((decimal)this.Saves / (decimal)this.Total, 3);
    }

    /// <summary>
    /// Gets or sets the saves.
    /// </summary>
    public uint Saves
    {
        get => this.saves;
        set => this.SetProperty(
            this.saves,
            value,
            (v) =>
            {
                this.saves = v;
                this.OnPropertyChanged(nameof(this.Total));
                this.OnPropertyChanged(nameof(this.Percentage));
            });
    }

    /// <summary>
    /// Gets or sets the goals.
    /// </summary>
    public uint Goals
    {
        get => this.goals;
        set => this.SetProperty(
            this.goals,
            value,
            (v) =>
            {
                this.goals = v;
                this.OnPropertyChanged(nameof(this.Total));
                this.OnPropertyChanged(nameof(this.Percentage));
            });
    }
}
