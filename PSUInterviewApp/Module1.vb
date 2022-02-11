Imports System
Imports System.Device
Imports System.Threading.Tasks
Imports System.Linq
Imports System.Net.Http
Imports System.Net.Http.Headers
Imports Newtonsoft.Json

Module Module1

    Private ReadOnly client As HttpClient = New HttpClient()
    Private Const apiquery As String = "https://api.openbrewerydb.org/breweries/search?query=pennsylvania"

    Sub Main()
        Console.WriteLine("PSU Interview Challenge - Breweries Closest to Beaver Statium")

        For Each brewery As BreweryDistance In GetThreeClosestBreweriesToStadium()
            Console.WriteLine("Name: " & brewery.Dto.name & "City: " & brewery.Dto.city & " Distance: " & brewery.Distance.ToString())
        Next

        Console.WriteLine("Press any key to exit...")
        Dim val = Console.ReadLine()

    End Sub

    Private Function GetAllBreweriesInPA() As IEnumerable(Of BreweryDto)
        Dim webresults = client.GetStringAsync(apiquery)
        Dim raw As String = webresults.Result
        Dim results = JsonConvert.DeserializeObject(Of List(Of BreweryDto))(raw)
        Return results
    End Function

    Private Function GetThreeClosestBreweriesToStadium() As IEnumerable(Of BreweryDistance)
        Dim distances As IEnumerable(Of BreweryDistance) = CalculateDistances().OrderBy(Function(x) x.Distance)
        Return distances
    End Function

    Private Function CalculateDistances() As IEnumerable(Of BreweryDistance)
        'get all breqeries in PA what have a long and lat value.
        Dim allbreweriesinpa As IEnumerable(Of BreweryDto) = GetAllBreweriesInPA().Where(Function(x) x.latitude <> String.Empty AndAlso x.longitude <> String.Empty)
        Dim brewerieswithlonglat As IEnumerable(Of BreweryDto) = allbreweriesinpa.Where(Function(x) x.latitude <> String.Empty AndAlso x.longitude <> String.Empty)
        Dim results As List(Of BreweryDistance) = New List(Of BreweryDistance)

        For Each brewery As BreweryDto In allbreweriesinpa
            results.Add(New BreweryDistance(brewery))
        Next

        Return results.OrderBy(Function(x) x.Distance).Take(3)
    End Function

End Module
