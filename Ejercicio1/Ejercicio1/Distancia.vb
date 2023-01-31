Public Class Distancia
    Private X1 As Double
    Private X2 As Double
    Private Y1 As Double
    Private Y2 As Double
    Private Distancia1 As Double

    Public Property punto1() As Double
        Get
            Return X1
        End Get
        Set(value As Double)
            X1 = value
        End Set
    End Property
    Public Property puntoy() As Double
        Get
            Return Y1
        End Get
        Set(value As Double)
            Y1 = value
        End Set
    End Property
    Public Property puntox2() As Double
        Get
            Return X2
        End Get
        Set(value As Double)
            X2 = value
        End Set
    End Property
    Public Property puntoy2() As Double
        Get
            Return Y2
        End Get
        Set(value As Double)
            Y2 = value
        End Set
    End Property
    Public Function CalcularDistancia(X1, Y1, X2, Y2) As Double
        Dim res As Double
        res = Math.Sqrt(((X2 - X1) ^ 2) + ((Y2 - Y1) ^ 2))
        Return res
    End Function
End Class
