

using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace UserControlExceptions
{
  public class ViewExcept : UserControl
  {
    
    public ViewExcept()
    {
      try
      {
        var TB = new TextBlock
        {
          Text = "This is a test."
        };
        Content = TB;
        Loaded += ViewExcept_Loaded;
      }
      catch (Exception ex)
      {
        Debug.WriteLine($"Caught in Constructor{ex}");
      }
    }

    private void ViewExcept_Loaded(object sender, RoutedEventArgs e)
    {
       throw new Exception("Test exception was thrown");
    }

    
  }
}
