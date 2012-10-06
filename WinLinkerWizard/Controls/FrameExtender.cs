using System;
using System.Windows;

namespace WinLinker.Controls
{
    public class FrameExtender : DependencyObject
    {
        public static readonly DependencyProperty FrameExpanseProperty =
            DependencyProperty.RegisterAttached("FrameExpanse", typeof(Thickness), typeof(FrameExtender), new PropertyMetadata(default(Thickness), ThicknessChanged));

        public static void SetFrameExpanse(UIElement element, Thickness value)
        {
            element.SetValue(FrameExpanseProperty, value);
        }

        public static Thickness GetFrameExpanse(UIElement element)
        {
            return (Thickness) element.GetValue(FrameExpanseProperty);
        }

        private static void ThicknessChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var window = d as Window;
            if (window == null)
                throw new InvalidOperationException("FrameExpanse property could be applied only to windows.");
            
            var newExpanse = (Thickness)e.NewValue;

            if (window.IsLoaded)
                ApplyExpanse(window, newExpanse);
            else
                window.Loaded += (_, __) => ApplyExpanse(window, newExpanse);
        }

        private static void ApplyExpanse(Window window, Thickness newExpanse)
        {
            var isExtendApplied = AeroGlassHelper.ExtendGlassFrame(window, newExpanse);
            if (!isExtendApplied)
                throw new Exception("Unable to apply a frame expanse.");
        }
    }
}
