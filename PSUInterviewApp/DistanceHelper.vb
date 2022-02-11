Imports System.Device.Location

''' <summary>
''' Helper class used to calculate distance (in miles) between to different points on Earth using Haversine formula.
''' </summary>
Public Class DistanceHelper
    Private Const stadium_long As Double = -77.856102
    Private Const stadium_lat As Double = 40.812195

    Public Shared Function CalculateDistance(longitude As Double, latitude As Double) As Double
        Dim stadiumcoord As New GeoCoordinate(stadium_lat, stadium_long)
        Dim brewerycoord As New GeoCoordinate(latitude, longitude)

        Dim kmdist As Double = stadiumcoord.GetDistanceTo(brewerycoord) / 1000

        Return kmdist
    End Function

End Class
