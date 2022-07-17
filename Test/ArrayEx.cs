namespace Test;

public partial class Test
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
        Assert.False(test.TryGetValue(5, out int _value));
    }
}
