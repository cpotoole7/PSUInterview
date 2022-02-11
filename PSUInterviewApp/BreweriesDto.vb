Imports Newtonsoft.Json

<Serializable>
Public Class BreweryDto

    <JsonProperty("id")>
    Public Property id As String

    <JsonProperty("name")>
    Public Property name As String

    <JsonProperty("brewery_type")>
    Public Property brewery_type As String

    <JsonProperty("street")>
    Public Property street As String

    <JsonProperty("address_2")>
    Public Property address_2 As String

    <JsonProperty("address_3")>
    Public Property address_3 As String

    <JsonProperty("city")>
    Public Property city As String

    <JsonProperty("state")>
    Public Property state As String

    <JsonProperty("county_province")>
    Public Property county_province As String

    <JsonProperty("postal_code")>
    Public Property postal_code As String

    <JsonProperty("country")>
    Public Property country As String

    <JsonProperty("longitude")>
    Public Property longitude As String

    <JsonProperty("latitude")>
    Public Property latitude As String

    <JsonProperty("phone")>
    Public Property phone As String

    <JsonProperty("website_url")>
    Public Property website_url As String

    <JsonProperty("updated_at")>
    Public Property updated_at As Date

    <JsonProperty("created_at")>
    Public Property created_at As Date
End Class
