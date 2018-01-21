using System.Collections.Generic;
using System.Linq;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Shapes;

namespace DeanChalk.UWP.TimePicker
{

    public sealed partial class TimePicker : Control
    {
        private bool _isPM;
        private NumberControl _hourSelected;
        private NumberControl _minuteSelected;
        private readonly Dictionary<Path, NumberControl> _hourNumberControls = new Dictionary<Path, NumberControl>();
        private readonly Dictionary<Path, NumberControl> _minuteNumberControls = new Dictionary<Path, NumberControl>();


        public TimePicker()
        {
            DefaultStyleKey = typeof(TimePicker);
        }


        public Brush UnSelectedForegroundBrush
        {
            get => (Brush)GetValue(UnSelectedForegroundBrushProperty);
            set => SetValue(UnSelectedForegroundBrushProperty, value);
        }

        public static DependencyProperty UnSelectedForegroundBrushProperty { get; } =
            DependencyProperty.Register("UnSelectedForegroundBrush", typeof(Brush), typeof(TimePicker),
                new PropertyMetadata(null));


        public Brush UnSelectedBackgroundBrush
        {
            get => (Brush)GetValue(UnSelectedBackgroundBrushProperty);
            set => SetValue(UnSelectedBackgroundBrushProperty, value);
        }


        public static DependencyProperty UnSelectedBackgroundBrushProperty { get; } =
            DependencyProperty.Register("UnSelectedBackgroundBrush", typeof(Brush), typeof(TimePicker),
                new PropertyMetadata(null));

        public static DependencyProperty SelectedBackgroundBrushProperty { get; } =
            DependencyProperty.Register("SelectedBackgroundBrush", typeof(Brush), typeof(TimePicker),
                new PropertyMetadata(null, OnSelectedColorChange));

        private static void OnSelectedColorChange(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var picker = d as TimePicker;
            picker?.ResetColors();
        }


        public Brush SelectedForegroundBrush
        {
            get => (Brush)GetValue(SelectedForegroundBrushProperty);
            set => SetValue(SelectedForegroundBrushProperty, value);
        }

        public static DependencyProperty SelectedForegroundBrushProperty { get; } =
            DependencyProperty.Register("SelectedForegroundBrush", typeof(Brush), typeof(TimePicker),
                new PropertyMetadata(null, OnSelectedColorChange));


        public Brush SelectedBackgroundBrush
        {
            get => (Brush)GetValue(SelectedBackgroundBrushProperty);
            set => SetValue(SelectedBackgroundBrushProperty, value);
        }

        private void OnMinuteTapped(object sender, TappedRoutedEventArgs e)
        {
            if (!(sender is Path path))
                return;
            _minuteSelected = _minuteNumberControls[path];
            var otherControls = _minuteNumberControls.Where(kp => kp.Key != path).Select(kp => kp.Value);
            foreach (var other in otherControls)
            {
                other.BackgroundCircle.Fill = UnSelectedBackgroundBrush;
                other.TextBlock.Foreground = UnSelectedForegroundBrush;
            }

            _minuteSelected.BackgroundCircle.Fill = SelectedBackgroundBrush;
            _minuteSelected.TextBlock.Foreground = SelectedForegroundBrush;
        }

        private void OnHourTapped(object sender, TappedRoutedEventArgs e)
        {
            if (!(sender is Path path))
                return;
            _hourSelected = _hourNumberControls[path];
            var otherControls = _hourNumberControls.Where(kp => kp.Key != path).Select(kp => kp.Value);
            foreach (var other in otherControls)
            {
                other.BackgroundCircle.Fill = UnSelectedBackgroundBrush;
                other.TextBlock.Foreground = UnSelectedForegroundBrush;
            }

            _hourSelected.BackgroundCircle.Fill = SelectedBackgroundBrush;
            _hourSelected.TextBlock.Foreground = SelectedForegroundBrush;
        }

        private void OnAmPmTapped(object sender, TappedRoutedEventArgs e)
        {
            _p_AMPM_TextBlock.Text = _isPM ? "AM" : "PM";
            _isPM = !_isPM;
        }

        private class NumberControl
        {
            public Path BackgroundCircle { get; set; }
            public Path ForegroundCircle { get; set; }
            public TextBlock TextBlock { get; set; }
        }

        private void ResetColors()
        {
            if (_hourSelected == null || _minuteSelected == null)
                return;
            _hourSelected.BackgroundCircle.Fill = SelectedBackgroundBrush;
            _hourSelected.TextBlock.Foreground = SelectedForegroundBrush;
            _minuteSelected.BackgroundCircle.Fill = SelectedBackgroundBrush;
            _minuteSelected.TextBlock.Foreground = SelectedForegroundBrush;
        }


    }
}