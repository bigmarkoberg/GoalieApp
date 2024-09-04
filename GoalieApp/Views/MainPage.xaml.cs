// <copyright file="MainPage.xaml.cs" company="Mark Oberg">
// Copyright (c) Mark Oberg. All rights reserved.
// </copyright>

namespace GoalieApp;

using GoalieApp.ViewModels;

/// <summary>
/// Main page class.
/// </summary>
public partial class MainPage : ContentPage
{
    ////private int count = 0;

    /// <summary>
    /// Initializes a new instance of the <see cref="MainPage"/> class.
    /// </summary>
    /// <param name="viewModel">View model.</param>
    public MainPage(MainPageViewModel viewModel)
    {
        this.InitializeComponent();
        this.BindingContext = viewModel;
    }

    ////private void OnCounterClicked(object sender, EventArgs e)
    ////{
    ////    this.count++;

    ////    if (this.count == 1)
    ////    {
    ////        this.CounterBtn.Text = $"Clicked {count} time";
    ////    }
    ////    else
    ////    {
    ////        this.CounterBtn.Text = $"Clicked {count} times";
    ////    }

    ////    SemanticScreenReader.Announce(this.CounterBtn.Text);
    ////}
}
