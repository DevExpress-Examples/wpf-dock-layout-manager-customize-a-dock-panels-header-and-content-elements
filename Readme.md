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


