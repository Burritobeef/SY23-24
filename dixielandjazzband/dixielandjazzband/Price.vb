Public Class Price
    Public Property Price As Decimal
    Public Property Increment As Decimal
    Dim _total As Decimal

    Public ReadOnly Property total As Decimal
        Get
            _total = Price * 125
            Return _total
        End Get
    End Property
    Public Sub Add()
        Price = Price + 1
    End Sub
    Public Sub Remove()
        Price = Price - 1
    End Sub
End Class
