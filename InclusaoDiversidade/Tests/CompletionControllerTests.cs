public class CompletionControllerTests : IClassFixture<WebApplicationFactory<Program>>
{
private readonly HttpClient _client;


public CompletionControllerTests(WebApplicationFactory<Program> factory)
{
_client = factory.CreateClient();
}


[Fact]
public async Task GetAll_Returns200()
{
var response = await _client.GetAsync("/api/Completion?page=1&pageSize=5");
response.EnsureSuccessStatusCode();
}
}