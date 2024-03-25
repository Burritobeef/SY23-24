Public Class Price
    Public Property Price As Integer
    Public Property Increment As Integer = 1
    Public Sub Add()
        Price = Price + 1
    End Sub
    Public Sub Remove()
        Price = Price - 1
    End Sub
    Public Sub Clear()
        Price = 0
    End Sub
End Class
