

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

    //Use event to pass exception due to a flaw in the try/catch exception scheme
    public event EventHandler<Exception> LoadFailed;

    public void RaiseLoadFailedEvent(Exception ex)
    {
      this.LoadFailed?.Invoke(this, ex);
    }


    private void ViewExcept_Loaded(object sender, RoutedEventArgs e)
    {
      try
      {
        throw new Exception("Test exception was thrown");
      }
      catch (Exception ex)
      {
        RaiseLoadFailedEvent(ex);
      }
    }

    
  }
}
