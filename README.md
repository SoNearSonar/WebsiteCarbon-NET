# WebsiteCarbon-NET
## A C# API wrapper for the website websitecarbon.com. A website that calculates carbon emissions of websites using a rough estimate

## Features
- Get information for websites and number of bytes passed
- Asynchronous method calls

## Credits:
- [Website Carbon Calculator](https://www.websitecarbon.com/) - [Website Carbon API](https://api.websitecarbon.com/)
- [ReactiveUI](https://github.com/reactiveui/) - [Refit](https://github.com/reactiveui/refit)

## Notes:
- Getting a result from this API takes a bit of time to calculate the first time. Future calls for the same URL / information within 24 hours will be much faster
- Exceptions come from Refit in the form of APIException

## Example Use:
### Getting information from a website
```csharp
WebsiteCarbonClient client = new WebsiteCarbonClient();
WebsiteCarbon carbon = await client.GetWebsiteInformationAsync("https://github.com/");
Console.WriteLine(carbon.Bytes);
Console.WriteLine(carbon.Green);
Console.WriteLine(carbon.CleanerThan);
Console.WriteLine(carbon.Statistics.CO2.Grid.Grams);
Console.WriteLine(carbon.Statistics.CO2.Renewable.Litres);
Console.WriteLine(carbon.Timestamp);
```

### Getting information from a number of bytes
```csharp
WebsiteCarbonClient client = new WebsiteCarbonClient();
WebsiteCarbon carbon = await client.GetDataInBytesInformationAsync(100, 1); // 100 is # of bytes, 1 is green status (can be any number, preferably 0 or 1 representing False and True respectively)
Console.WriteLine(carbon.CleanerThan);
Console.WriteLine(carbon.Statistics.AdjustedBytes);
Console.WriteLine(carbon.Statistics.CO2.Grid.Grams);
Console.WriteLine(carbon.Statistics.CO2.Renewable.Litres);
Console.WriteLine(carbon.Timestamp);
```