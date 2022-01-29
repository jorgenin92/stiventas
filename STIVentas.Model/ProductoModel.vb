Public Class ProductoModel
    Private RecordId As Integer
    Public Property Id() As Integer
        Get
            Return RecordId
        End Get
        Set(ByVal value As Integer)
            RecordId = value
        End Set
    End Property
End Class
