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
  }
}
