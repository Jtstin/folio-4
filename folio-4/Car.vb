Public Class Car
    Private _registration As String
    Public Property Registration() As String
        Get
            Return _registration
        End Get
        Set(value As String)
            _registration = value
        End Set
    End Property

    Private _make As String
    Public Property Make() As String
        Get
            Return _make
        End Get
        Set(value As String)
            _make = value
        End Set
    End Property

    Private _model As String
    Public Property Model() As String
        Get
            Return _model
        End Get
        Set(value As String)
            _model = value
        End Set
    End Property

    Private _year As String
    Public Property Year() As Int16
        Get
            Return _year
        End Get
        Set(value As Int16)
            _year = value
        End Set
    End Property

    Private _odometer As String
    Public Property Odometer() As String
        Get
            Return _odometer
        End Get
        Set(value As String)
            _odometer = value
        End Set
    End Property

    Private _cost As String
    Public Property Cost() As Decimal
        Get
            Return _cost
        End Get
        Set(value As Decimal)
            _cost = value
        End Set
    End Property
End Class
