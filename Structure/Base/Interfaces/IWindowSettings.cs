using System.Windows;

namespace Structure.Base.Interfaces
{
    interface IWindowSettings
    {
        SizeToContent WindowSizeToContent { get; set; }
        ResizeMode WindowReSizeMode { get; set; }
        WindowState WindowsState { get; set; }
    }
}
