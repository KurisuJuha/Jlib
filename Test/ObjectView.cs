namespace Test;

public partial class Test
{
    private class ObjectViewTestClass
    {
        public override string ToString()
        {
            return "aiueo";
        }
    }

    [Fact]
    public void View_ObjectView()
    {
        ObjectViewTestClass testClass = new ObjectViewTestClass();
        Assert.Equal("aiueo", testClass.View());
        Assert.Equal("testclass(Object) : aiueo", testClass.View("testclass"));
    }

    [Fact]
    public void View_StringView()
    {
        Assert.Equal("\"bb\"", "bb".View());
        Assert.Equal("aa(String) : \"bb\"", "bb".View("aa"));
    }

    [Fact]
    public void View_CharView()
    {
        Assert.Equal("\'b\'", 'b'.View());
        Assert.Equal("a(Char) : \'b\'", 'b'.View("a"));
    }

    [Fact]
    public void View_IntView()
    {
        Assert.Equal("256", 256.View());
        Assert.Equal("a(Int) : 256", 256.View("a"));
    }

    [Fact]
    public void View_FloatView()
    {
        Assert.Equal("0.1", 0.1f.View());
        Assert.Equal("a(Float) : 0.1", 0.1f.View("a"));
    }
}
