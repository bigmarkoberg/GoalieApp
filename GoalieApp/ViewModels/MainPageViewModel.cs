// <copyright file="MainPageViewModel.cs" company="Mark Oberg">
// Copyright (c) Mark Oberg. All rights reserved.
// </copyright>

namespace GoalieApp.ViewModels;

using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Android.OS.Strictmode;
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
        value =>
        {
            if (this.Goals == 0 && value < 0)
            {
                return;
            }

            this.Goals = (uint)(this.Goals + value);
        });
        this.SavesChangeCommand = new(
        value =>
        {
            if (this.Saves == 0 && value < 0)
            {
                return;
            }

            this.Saves = (uint)(this.Saves + value);
        });
    }

    /// <summary>
    /// Gets the goals change command.
    /// </summary>
    public Command<int> GoalsChangeCommand { get; }

    /// <summary>
    /// Gets the saves change command.
    /// </summary>
    public Command<int> SavesChangeCommand { get; }

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
        get => this.Saves / this.Total;
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
