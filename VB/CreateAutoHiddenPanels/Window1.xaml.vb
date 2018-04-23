Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Windows
Imports System.Windows.Controls
Imports System.Windows.Data
Imports System.Windows.Documents
Imports System.Windows.Input
Imports System.Windows.Media
Imports System.Windows.Media.Imaging
Imports System.Windows.Navigation
Imports System.Windows.Shapes
Imports DevExpress.Xpf.Docking
Imports DevExpress.Xpf.Layout.Core

Namespace CreateAutoHiddenPanels
	''' <summary>
	''' Interaction logic for Window1.xaml
	''' </summary>
	Partial Public Class Window1
		Inherits Window
		Public Sub New()
			InitializeComponent()
			AddHandler auotHideGroup.Items.CollectionChanged, AddressOf Items_CollectionChanged

		End Sub

		Private Sub Items_CollectionChanged(ByVal sender As Object, ByVal e As System.Collections.Specialized.NotifyCollectionChangedEventArgs)
            MessageBox.Show(String.Format("The panel is {0}d to/from the AutoHideGroup", e.Action.ToString()))
		End Sub

        Private Sub button1_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
            dockManager1.DockController.Dock(paneProperties, documentGroup1, DockType.Right)
        End Sub

        Private Sub button2_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
            dockManager1.DockController.Dock(paneProperties, auotHideGroup, DockType.Bottom)
            'dockManager1.DockController.Hide(paneProperties) a new auto hide group will be created
        End Sub

		Private Sub button3_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
			MessageBox.Show("IsAutoHidden = " & paneProperties.IsAutoHidden.ToString())
		End Sub





	End Class
End Namespace
