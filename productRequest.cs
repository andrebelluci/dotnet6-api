
//Dto = data transference object
public record productRequest(string Code, string Name, string Description, int CategoryId, List<string> Tags);