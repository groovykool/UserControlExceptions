using System;
using System.Diagnostics;
using Windows.UI.Xaml.Controls;

namespace UserControlExceptions
{

  public sealed partial class MainPage : Page
  {
    public MainPage()
    {
      try
      {
        this.InitializeComponent();
      }
      catch (Exception ex)
      {
        Debug.WriteLine($"Caught in Page Constructor::{ex.Message}");
      }
    }
    private void ViewExcept_LoadFailed(object sender, Exception e)
    {
      Debug.WriteLine($"Exception caught from LoadFailed Event::{e.Message}");
    }

    private void VE_Loaded(object sender, Windows.UI.Xaml.RoutedEventArgs e)
    {
      Debug.WriteLine($"VE Control was loaded");
    }

    private void Page_Loaded(object sender, Windows.UI.Xaml.RoutedEventArgs e)
    {
      Debug.WriteLine($"MainPage was loaded");
    }
  }
}
