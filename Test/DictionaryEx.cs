namespace Test;

public partial class Test
{
    [Fact]
    public void DictionaryEx_GetOrDefault()
    {
        Dictionary<string, string> dict = new Dictionary<string, string>()
        {
            {"a" , "_a" },
            {"b" , "_b" },
            {"c" , "_c" },
            {"d" , "_d" }
        };

        Assert.Null(dict.GetOrDefault("e"));
        Assert.Equal("_a", dict.GetOrDefault("a"));
    }
}
