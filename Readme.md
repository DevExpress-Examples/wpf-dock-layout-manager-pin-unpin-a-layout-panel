<!-- default badges list -->
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E2890)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
# WPF Dock Layout Manager - Pin/Unpin a LayoutPanel

You can add or remove a layout panel to or from [AutoHideGroup](https://docs.devexpress.com/WPF/DevExpress.Xpf.Docking.AutoHideGroup). In this case, the [AutoHideGroup.Items](https://docs.devexpress.com/WPF/DevExpress.Xpf.Docking.AutoHideGroup.Items) collection is changed. You can handle the `AutoHideGroup.Items.CollectionChanged` event to track these changes. Use the read-only [BaseLayoutItem.IsAutoHidden](https://docs.devexpress.com/WPF/DevExpress.Xpf.Docking.BaseLayoutItem.IsAutoHidden) property to check whether the panel is placed in [AutoHideGroup](https://docs.devexpress.com/WPF/DevExpress.Xpf.Docking.AutoHideGroup).

<img src="https://user-images.githubusercontent.com/12169834/175360696-a08a9c82-7013-465f-8a0b-6a67721b2458.png" width=705px/>

Call the [DockManager.DockController.Dock](https://docs.devexpress.com/WPF/DevExpress.Xpf.Docking.DockControllerBase.Dock.overloads) method to unpin a panel and dock it to the specified group.

To pin/add a panel, you should call the [DockController.Dock](https://docs.devexpress.com/WPF/DevExpress.Xpf.Docking.DockControllerBase.Dock.overloads) method to dock it to an existing [AutoHideGroup](https://docs.devexpress.com/WPF/DevExpress.Xpf.Docking.AutoHideGroup).

Another way to "pin" a panel is to call the [DockController.Hide](https://docs.devexpress.com/WPF/DevExpress.Xpf.Docking.DockControllerBase.Hide.overloads) method. In this case, a new [AutoHideGroup](https://docs.devexpress.com/WPF/DevExpress.Xpf.Docking.AutoHideGroup) with this panel is created.

<!-- default file list -->
## Files to Look At

* [Window1.xaml](./CS/CreateAutoHiddenPanels/Window1.xaml) (VB: [Window1.xaml](./VB/CreateAutoHiddenPanels/Window1.xaml))
* [Window1.xaml.cs](./CS/CreateAutoHiddenPanels/Window1.xaml.cs) (VB: [Window1.xaml.vb](./VB/CreateAutoHiddenPanels/Window1.xaml.vb))
<!-- default file list end -->

