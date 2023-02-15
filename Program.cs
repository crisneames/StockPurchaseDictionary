

Dictionary<string, string> stocks = new Dictionary<string, string>();
stocks.Add("GM", "General Motors");
stocks.Add("CAT", "Caterpillar");
stocks.Add("TGT", "Target");
//stocks.Add("GOOGL", "Googles");


string GM = stocks["GM"]; //find value in dictionary - use square bracket notion - like JS object key lookup

// Create list of ValueTuples that represents stock purchases. Properties will be ticker, shares, price.

List<(string ticker, int shares, double price)> purchases = new List<(string, int, double)>();

purchases.Add((ticker: "GM", shares: 150, price: 23.21));
purchases.Add((ticker: "CAT", shares: 32, price: 17.87));
purchases.Add((ticker: "TGT", shares: 80, price: 19.02));

//Create a total ownership report that computes the total value of each stock that you have purchased.
//This is the basic relational database join algorithm between two tables.

// TotalOwnership Report

Dictionary<string, double>aggregatedPurchases = new Dictionary<string, double>();
string purchaseKey;
double sum;

foreach ((string ticker, int shares, double price) purchase in purchases)
{
    if (!stocks.ContainsKey(purchase.ticker))
    {
        string company = "";
        Console.Write("Please enter the Company Name: ");
        company = Console.ReadLine();
        stocks.Add(purchase.ticker, company);
        purchaseKey = stocks[purchase.ticker];
        sum = purchase.shares * purchase.price;
        aggregatedPurchases.Add(purchaseKey, sum);

    }
    else if (stocks.ContainsKey(purchase.ticker))
    {
        purchaseKey = stocks[purchase.ticker];
        sum = purchase.shares * purchase.price;
        aggregatedPurchases.Add(purchaseKey, sum);
        Console.WriteLine(aggregatedPurchases["General Motors"]);
       //Console.WriteLine(String.Format("{0.0.00}", aggregatedPurchases[purchaseKey]));
    }
}


/*
 * Define a new Dictionary to hold the aggregated purchase information. - The key should be a string that is the full company name.
 * The value will be the valuation of each stock (price*amount) { "General Electric": 35900, "AAPL": 8445, ... }
*/
//Dictionary<string, double> purchaseInfo = new Dictionary<string, double>();

// Iterate over the purchases and update the valuation for each stock
//foreach ((string ticker, int shares, double price) purchase in purchases)




