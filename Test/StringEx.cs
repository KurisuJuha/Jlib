namespace Test;

public partial class Test
{
    [Fact]
    public void StringEx_TryGet()
    {
        string test = "aiueo";

        if (test.TryGetValue(0, out char value)) { }
        Assert.Equal('a', value);

        Assert.False(test.TryGetValue(5, out char _value));
    }
}
