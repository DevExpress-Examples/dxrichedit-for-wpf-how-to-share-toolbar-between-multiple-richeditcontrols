Imports System.Windows
Imports DevExpress.Xpf.RichEdit

Namespace RichEditTwoControlsOneToolbarWpf

    Public Partial Class MainWindow
        Inherits Window

        Public Sub New()
            Me.InitializeComponent()
        End Sub

        Private Sub Window_Loaded(ByVal sender As Object, ByVal e As RoutedEventArgs)
            Me.richEditControl1.KeyCodeConverter.Focus()
        End Sub

        Private Sub richEditControl_GotFocus(ByVal sender As Object, ByVal e As RoutedEventArgs)
            Dim richEditControl As RichEditControl = CType(sender, RichEditControl)
            Me.richEditControl1.BarManager = Nothing
            Me.richEditControl2.BarManager = Nothing
            richEditControl.BarManager = Me.barManager1
            Me.richEditControlProvider1.RichEditControl = richEditControl
        End Sub
    End Class
End Namespace
