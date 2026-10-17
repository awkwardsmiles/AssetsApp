using AssetsApp.Data;

// Method to display list of assets
static void displayAssets(List<Asset> assets)
{
    foreach (Asset asset in assets)
    {
        Console.WriteLine(asset);
    }
}

// Connect and open database
using var db = new AssetsDbContext();

// ---- LOAD: all asset records ----
Console.WriteLine("=== All assets ===");
var assets = db.Assets.ToList();
displayAssets(assets);
