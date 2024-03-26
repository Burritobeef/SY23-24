Public Class Price
    Public Property Price As Decimal
    Public Property Increment As Decimal
    Public Sub Add()
        Price = Price + 30
    End Sub
    Public Sub Remove()
        Price = Price - 30
    End Sub
    Public Sub Clear()
        Price = 0
    End Sub
End Class
