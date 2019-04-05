<!-- default file list -->
*Files to look at*:

* **[Window1.xaml](./CS/CreateAutoHiddenPanels/Window1.xaml) (VB: [Window1.xaml](./VB/CreateAutoHiddenPanels/Window1.xaml))**
* [Window1.xaml.cs](./CS/CreateAutoHiddenPanels/Window1.xaml.cs) (VB: [Window1.xaml.vb](./VB/CreateAutoHiddenPanels/Window1.xaml.vb))
<!-- default file list end -->
# How to pin/unpin a layout panel


<p>LayoutPanel cannot be pinned/unpinned in a general meaning of this word. The panel can be placed in one of groups' type or another one. </p><p>The correct statement is the following: you can add or remove a layout panel to/from AutoHideGroup. In this case, the AutoHideGroup.Items collection will be changed. These changes can be tracked by handling AutoHideGroup.Items.CollectionChanged. To check whether the panel is placed in AutoHideGroup, use the readonly BaseLayoutItem.IsAutoHidden property.</p><p>To unpin/remove a panel, you should dock it to any other group. This can be done by calling the DockManager.DockController.Dock method.</p><p>To pin/add a panel, you should dock it to an existing AutoHideGroup by calling the DockManager.DockController.Dock method. Another way to "pin" a panel is to call the DockManager.DockController.Hide method, a new AutoHideGroup with this panel will be created.</p>

<br/>


