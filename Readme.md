<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128643367/10.1.4%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E1918)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [DockPane.xaml](./CS/CustomTheme/DockPane.xaml) (VB: [DockPane.xaml](./VB/CustomTheme/DockPane.xaml))
* [Window1.xaml](./CS/CustomTheme/Window1.xaml) (VB: [Window1.xaml.vb](./VB/CustomTheme/Window1.xaml.vb))
* [Window1.xaml.cs](./CS/CustomTheme/Window1.xaml.cs) (VB: [Window1.xaml.vb](./VB/CustomTheme/Window1.xaml.vb))
<!-- default file list end -->
# How to customize header and content elements of the DockPanel in the DockManager


<p>It's necessary to respecify templates corresponding to the defined resource keys. The DockPanel Header and Content are placed in the DockPaneElementsThemeKey. The resource keys for the Header and the Content and Header and Content keys respectively. These are the keys you should respecify:</p><p><DataTemplate x:Key="{dxt:DockPaneElementsThemeKey ResourceKey=Header}"><br />
<DataTemplate x:Key="{dxt:DockPaneElementsThemeKey ResourceKey=ContentHostTemplate}"></p>

<br/>


