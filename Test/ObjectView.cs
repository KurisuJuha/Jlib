namespace Test;

public partial class Test
{
    class ObjectViewTestClass
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
        Assert.Equal("testclass : aiueo", testClass.View("testclass"));
    }

    [Fact]
    public void View_StringView()
    {
        Assert.Equal("aa : \"bb\"", "bb".View("aa"));
    }

    [Fact]
    public void View_CharView()
    {
        Assert.Equal("a : \'b\'", 'b'.View("a"));
    }
}
