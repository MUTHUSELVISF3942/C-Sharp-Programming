namespace TDD;
[TestFixture]
public class Tests
{
    Maths operation=null;
  
    [SetUp]
    public void Setup()
    {
        operation=new Maths(); //Object creation
       
    }

    [Test]
    public void Test1()
    {
        int result=operation.Addition(10,20);
        Assert.That(result,Is.EqualTo(30));
    }
    [TestCase(10,20,30)]  //Multiple test case input1,intpu2,
    [TestCase(1,2,3)]
    public void IsAddition(int num1,int num2,int result)
    {
        int output=operation.Addition(num1,num2);
        Assert.AreEqual(output,result);
    }
     [TestCase(1.2,2.1,3.3)]
    public void IsAdditionok(double num1,double num2,double result)
    {
        double output=operation.Addition(num1,num2);
        Assert.AreEqual(output,result);
    }
     [TestCase("Ravi","Chandran","RaviChandran")]
    public void IsAddition(double num1,double num2,double result)
    {
        double output=operation.Addition(num1,num2);
        Assert.AreEqual(output,result);
    }
    
}