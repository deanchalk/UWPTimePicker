using System;
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
        private readonly Dictionary<Path, NumberControl> _hourNumberControls = new Dictionary<Path, NumberControl>();
        private readonly Dictionary<Path, NumberControl> _minuteNumberControls = new Dictionary<Path, NumberControl>();
        private NumberControl _hourSelected;
        private bool _isPm;
        private NumberControl _minuteSelected;

        public static DependencyProperty TimeProperty { get; } =
            DependencyProperty.Register("Time", typeof(TimeSpan), typeof(TimePicker), new PropertyMetadata(TimeSpan.Parse("0:00"), OnTimePropertyChanged));

        public static DependencyProperty UnSelectedBackgroundBrushProperty { get; } =
            DependencyProperty.Register("UnSelectedBackgroundBrush", typeof(Brush), typeof(TimePicker),
                new PropertyMetadata(null));

        public static DependencyProperty UnSelectedForegroundBrushProperty { get; } =
            DependencyProperty.Register("UnSelectedForegroundBrush", typeof(Brush), typeof(TimePicker),
                new PropertyMetadata(null));

        public static DependencyProperty SelectedBackgroundBrushProperty { get; } =
            DependencyProperty.Register("SelectedBackgroundBrush", typeof(Brush), typeof(TimePicker),
                new PropertyMetadata(null, OnSelectedColorChange));

        public static DependencyProperty SelectedForegroundBrushProperty { get; } =
            DependencyProperty.Register("SelectedForegroundBrush", typeof(Brush), typeof(TimePicker),
                new PropertyMetadata(null, OnSelectedColorChange));

        public TimePicker()
        {
            DefaultStyleKey = typeof(TimePicker);
        }

        public TimeSpan Time
        {
            get => (TimeSpan) GetValue(TimeProperty);
            set => SetValue(TimeProperty, value);
        }

        public Brush UnSelectedForegroundBrush
        {
            get => (Brush)GetValue(UnSelectedForegroundBrushProperty);
            set => SetValue(UnSelectedForegroundBrushProperty, value);
        }

        public Brush UnSelectedBackgroundBrush
        {
            get => (Brush)GetValue(UnSelectedBackgroundBrushProperty);
            set => SetValue(UnSelectedBackgroundBrushProperty, value);
        }

        public Brush SelectedForegroundBrush
        {
            get => (Brush)GetValue(SelectedForegroundBrushProperty);
            set => SetValue(SelectedForegroundBrushProperty, value);
        }

        public Brush SelectedBackgroundBrush
        {
            get => (Brush)GetValue(SelectedBackgroundBrushProperty);
            set => SetValue(SelectedBackgroundBrushProperty, value);
        }

        private static void OnTimePropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            ((TimePicker)d).ChangeControlsFromNewTime();
        }

        private static void OnSelectedColorChange(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var picker = d as TimePicker;
            picker?.ResetColors();
        }

        private void ChangeControlsFromNewTime()
        {
            if (!_hasAppliedTemplate)
                return;
            var fmin = TimeSpan.FromMinutes(5);
            var timeRounded = new TimeSpan(((Time.Ticks + fmin.Ticks - 1) / fmin.Ticks) * fmin.Ticks);
            SetHourControlFromTime(timeRounded);
            SetMinuteControlFromTime(timeRounded);
            _isPm = timeRounded.Hours > 11;
            SetAmPmControl();
        }

        private void ChangeTimeFromSelectedControls()
        {
            var hours = _hourSelected.Value;
            if (hours == 12)
                hours = _isPm ? 12 : 0;
            else if (_isPm)
                hours += 12;
            var mins = _minuteSelected.Value;
            var timeSpan = new TimeSpan(0,hours,mins,0);
            SetValue(TimeProperty,timeSpan);
        }

        private void SetHourControlFromTime(TimeSpan time)
        {
            var hours = time.Hours;
            if (hours == 0)
                hours = 12;
            if (hours > 12)
                hours -= 12;
            var hourControl = _hourNumberControls.Values.Single(c => c.Value == hours);
            _hourSelected = hourControl;
            SetHourControl();
        }

        private void SetMinuteControlFromTime(TimeSpan time)
        {
            var minuteControl = _minuteNumberControls.Values.Single(c => c.Value == time.Minutes);
            _minuteSelected = minuteControl;
            SetMinuteControl();
        }

        private void OnMinuteTapped(object sender, TappedRoutedEventArgs e)
        {
            if (!(sender is Path path))
                return;
            _minuteSelected = _minuteNumberControls[path];
            SetMinuteControl();
            ChangeTimeFromSelectedControls();
        }

        private void SetMinuteControl()
        {
            var otherControls = _minuteNumberControls.Where(kp => kp.Key != _minuteSelected.ForegroundCircle).Select(kp => kp.Value);
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
            SetHourControl();
            ChangeTimeFromSelectedControls();
        }

        private void SetHourControl()
        {
            var otherControls = _hourNumberControls.Where(kp => kp.Key != _hourSelected.ForegroundCircle).Select(kp => kp.Value);
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
            _isPm = !_isPm;
            SetAmPmControl();
            ChangeTimeFromSelectedControls();
        }

        private void SetAmPmControl()
        {
            _p_AMPM_TextBlock.Text = _isPm ?  "PM" : "AM";
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

        private class NumberControl
        {
            public Path BackgroundCircle { get; set; }
            public Path ForegroundCircle { get; set; }
            public TextBlock TextBlock { get; set; }
            public int Value { get; set; }
        }
    }
}