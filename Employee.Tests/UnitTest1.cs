using challengeapp;

namespace ConsoleApp;
public class UnitTest1
{
    [Test]
    public void test1()
    {
        var emp = new Employee("Adam", "Kowalski", 21) ;
        emp.AddGrade(7);
        emp.AddGrade(8);
        emp.AddGrade(9);
        var result = emp.Result;
        Assert.AreEqual(24, result);
    }
}