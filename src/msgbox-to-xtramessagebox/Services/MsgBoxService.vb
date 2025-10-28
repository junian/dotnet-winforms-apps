Public Class MsgBoxService Implements IMessageBoxService
    Public Function ShowMessage(message As String, title As String) As DialogResult Implements IMessageBoxService.ShowMessage
        Return MsgBox(message, MsgBoxStyle.OkOnly, title)
    End Function

End Class
