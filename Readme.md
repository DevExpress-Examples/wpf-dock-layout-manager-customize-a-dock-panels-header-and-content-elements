<!-- default badges list -->
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E1918)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->

# WPF Dock Layout Manager - Customize a DockPanel's Header and Content Elements

This example changes the appearance of the [DocumentPanel](https://docs.devexpress.com/WPF/DevExpress.Xpf.Docking.DocumentPanel)'s Header and Content Elements. To do this, specify the following `DockPaneElementsThemeKey` keys:

* `<DataTemplate x:Key="{dxt:DockPaneElementsThemeKey ResourceKey=Header}">`
* `<DataTemplate x:Key="{dxt:DockPaneElementsThemeKey ResourceKey=ContentHostTemplate}">`

<img src="https://user-images.githubusercontent.com/12169834/175347160-f9b2a92d-ed48-4f53-8643-3863abd7a02f.png" width=375px/>

<!-- default file list -->
## Files to Look At

* [DockPane.xaml](./CS/CustomTheme/DockPane.xaml) (VB: [DockPane.xaml](./VB/CustomTheme/DockPane.xaml))
* [Window1.xaml](./CS/CustomTheme/Window1.xaml) (VB: [Window1.xaml](./VB/CustomTheme/Window1.xaml))
* [Window1.xaml.cs](./CS/CustomTheme/Window1.xaml.cs) (VB: [Window1.xaml.vb](./VB/CustomTheme/Window1.xaml.vb))
<!-- default file list end -->

## Documentation 
- [Appearance Customization](https://docs.devexpress.com/WPF/403610/controls-and-libraries/layout-management/dock-windows/appearance-customization)
- [DocumentPanel](https://docs.devexpress.com/WPF/DevExpress.Xpf.Docking.DocumentPanel)
