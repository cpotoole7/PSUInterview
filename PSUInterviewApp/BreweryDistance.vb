Imports System.Device.Location

Public Class BreweryDistance

    Public Sub New()
    End Sub

    Public Sub New(data As BreweryDto)
        Distance = DistanceHelper.CalculateDistance(Double.Parse(data.longitude), Double.Parse(data.latitude))
        Dto = data
    End Sub
    Public Property Distance As Double
    Public Property Dto As BreweryDto
End Class
