Imports Microsoft.VisualBasic
Imports System.Windows
Imports DevExpress.Xpf.RichEdit

Namespace RichEditTwoControlsOneToolbarWpf
	Partial Public Class MainWindow
		Inherits Window
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub Window_Loaded(ByVal sender As Object, ByVal e As RoutedEventArgs)
			richEditControl1.KeyCodeConverter.Focus()
		End Sub

		Private Sub richEditControl_GotFocus(ByVal sender As Object, ByVal e As RoutedEventArgs)
			Dim richEditControl As RichEditControl = CType(sender, RichEditControl)

			richEditControl1.BarManager = Nothing
			richEditControl2.BarManager = Nothing
			richEditControl.BarManager = barManager1
			richEditControlProvider1.RichEditControl = richEditControl
		End Sub
	End Class
End Namespace
