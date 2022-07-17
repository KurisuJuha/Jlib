namespace Test;

public class Test
{
    [Fact]
    public void ArrayEx_TryGetValue()
    {
        int[] test = new int[]
        {
            10,
            20,
            30,
            40,
        };

        if (test.TryGetValue(0 ,out int value)) { }
        Assert.Equal(10, value);
        Assert.True(!test.TryGetValue(5, out int _value));
    }

    [Fact]
    public void StringEx_TryGet()
    {
        string test = "aiueo";

        if (test.TryGetValue(0,out char value)) { }
        Assert.Equal('a', value);

        Assert.True(!test.TryGetValue(5, out char _value));
    }
}
