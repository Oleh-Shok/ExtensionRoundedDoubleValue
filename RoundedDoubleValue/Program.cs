//int i = 2.4.Round(); i = 2
//int j = 2.5.Round(); j = 3

Console.WriteLine(2.4.Round());
Console.WriteLine(2.5.Round());

static class ExtensionDouble
{

    public static int Round(this double RoundValue) => Convert.ToInt32(Math.Round(RoundValue, MidpointRounding.AwayFromZero));
}

