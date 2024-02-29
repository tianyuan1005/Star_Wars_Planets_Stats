
using System.Text.Json;
using System.Text.Json.Serialization;
using StarWarsPlanetsStats.ApiDataAccess;

IApiDataReader apiDataReader = new ApiDataReader();
var json = await apiDataReader.Read("https://swapi.dev/", "api/planets");

var root = JsonSerializer.Deserialize<Root>(json);
Console.WriteLine("Press any key to close");
Console.ReadKey();

public record Root(
    [property: JsonPropertyName("count")] int count,
    [property: JsonPropertyName("next")] string next,
    [property: JsonPropertyName("previous")] object previous,
    [property: JsonPropertyName("results")] IReadOnlyList<Result> results
);

