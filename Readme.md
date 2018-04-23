# How to customize header and content elements of the DockPanel in the DockManager


<p>It's necessary to respecify templates corresponding to the defined resource keys. The DockPanel Header and Content are placed in the DockPaneElementsThemeKey. The resource keys for the Header and the Content and Header and Content keys respectively. These are the keys you should respecify:</p><p><DataTemplate x:Key="{dxt:DockPaneElementsThemeKey ResourceKey=Header}"><br />
<DataTemplate x:Key="{dxt:DockPaneElementsThemeKey ResourceKey=ContentHostTemplate}"></p>

<br/>


