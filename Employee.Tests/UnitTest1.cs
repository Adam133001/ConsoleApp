using challengeapp;

namespace ConsoleApp;
public class UnitTest1
{
    [Test]
    public void test1()
    {
        var emp = new Employee() ;
        emp.AddGrade(7);
        emp.AddGrade(8);
        emp.AddGrade(9);
        var result = emp.AddGrade;
        Assert.AreEqual(expected, actual);
    }
}