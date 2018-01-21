# UWP Radial Time Picker Control
Radial Style TimePicker Control for UWP

## How to use in a UWP app
If you want to include this control in an app, you can look at the sample project for guidance, but essentially the control has the following bindable properties:

### `UnSelectedBackgroundBrush`

This brush by default is set to the standard background theme brush for the application, but can be set to any brush in your code. This brush paints the background of any dial elements that aren't selected.

### `UnSelectedForegroundBrush`

This brush by default is set to the standard foreground theme brush for the application, but can be set to any brush in your code. This brush paints the foreground text of any dial elements that aren't selected.

### `SelectedBackgroundBrush`

This brush by default is set to the standard foreground theme brush for the application, but can be set to any brush in your code. This brush paints the background of any dial elements that ARE selected. This should be contrasted to the `UnSelectedBackgroundBrush` visually.

### `UnSelectedForegroundBrush`

This brush by default is set to the standard background theme brush for the application, but can be set to any brush in your code. This brush paints the foreground text of any dial elements that ARE selected. This should be contrasted to the `UnSelectedForegroundBrush` visually.

### `Time`

The Time property is set to the `TimeSpan` and supports 2-way binding


![Image of TimePicker in app](https://github.com/deanchalk/UWPTimePicker/blob/master/docs/images/screenshot.gif)


