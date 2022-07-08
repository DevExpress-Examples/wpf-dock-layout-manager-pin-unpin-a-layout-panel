Imports System
Imports System.Windows
Imports System.Windows.Controls
Imports DevExpress.Xpf.Layout.Core

Namespace CreateAutoHiddenPanels

    ''' <summary>
    ''' Interaction logic for Window1.xaml
    ''' </summary>
    Public Partial Class Window1
        Inherits Window

        Public Sub New()
            Me.InitializeComponent()
            AddHandler Me.auotHideGroup.Items.CollectionChanged, New Collections.Specialized.NotifyCollectionChangedEventHandler(AddressOf Items_CollectionChanged)
        End Sub

        Private Sub Items_CollectionChanged(ByVal sender As Object, ByVal e As Collections.Specialized.NotifyCollectionChangedEventArgs)
            Call MessageBox.Show(String.Format("The panel is {0}d to/from the AutoHideGroup", e.Action.ToString()))
        End Sub

        Private Sub button1_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
            Me.dockManager1.DockController.Dock(Me.paneProperties, Me.documentGroup1, DockType.Right)
        End Sub

        Private Sub button2_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
            Me.dockManager1.DockController.Dock(Me.paneProperties, Me.auotHideGroup, DockType.Bottom)
        'dockManager1.DockController.Hide(paneProperties); a new auto hide group will be created
        End Sub

        Private Sub button3_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
            Call MessageBox.Show("IsAutoHidden = " & Me.paneProperties.IsAutoHidden.ToString())
        End Sub
    End Class
End Namespace
