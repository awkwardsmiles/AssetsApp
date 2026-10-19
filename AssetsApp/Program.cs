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

# region MOST USED
// ---- SELECT: assets currently in use, most expensive first ----
Console.WriteLine();
Console.WriteLine("=== Assets in use (most expensive first) ===");
var inUse = db.Assets
    .Where(a => a.InUse)
    .OrderByDescending(a => a.PurchasePrice)
    .ToList();
displayAssets(inUse);
#endregion

# region UPDATE db
//  add a new asset  
// var newAsset = new Asset(0, "Tablet", "Reception", DateOnly.FromDateTime(DateTime.Now), true, 329.00);
//db.Assets.Add(newAsset);
//db.SaveChanges();
#endregion

#region Modify data
// ---- UPDATE: change the purchase price of asset with id 3 ----
var asset3 = db.Assets
    .Where(a => a.ID == 3)
    .SingleOrDefault(); // get a single record or NULL

if (asset3 != null)
{
    Console.WriteLine();
    Console.WriteLine($"Before change: {asset3}");
    asset3.PurchasePrice = 505.00;
    asset3.InUse = false;
    Console.WriteLine($"After change:  {asset3}");

    // Save change to memory objects to the database
    db.SaveChanges();
}
#endregion