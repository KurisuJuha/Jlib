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
        Assert.Equal("aa(String) : \"bb\"", "bb".View("aa"));
    }

    [Fact]
    public void View_CharView()
    {
        Assert.Equal("a(Char) : \'b\'", 'b'.View("a"));
    }


}
