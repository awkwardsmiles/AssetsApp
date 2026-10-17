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

// ---- SELECT: assets currently in use, most expensive first ----
Console.WriteLine();
Console.WriteLine("=== Assets in use (most expensive first) ===");
var inUse = db.Assets
    .Where(a => a.InUse)
    .OrderByDescending(a => a.PurchasePrice)
    .ToList();
displayAssets(inUse);


//  add a new asset  
// var newAsset = new Asset(0, "Tablet", "Reception", DateOnly.FromDateTime(DateTime.Now), true, 329.00);
//db.Assets.Add(newAsset);
//db.SaveChanges();