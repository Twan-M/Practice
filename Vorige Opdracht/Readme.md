![image](https://github.com/user-attachments/assets/66c1106c-83be-439b-a544-aa267bd59714)


Unit Test:

namespace FietsExample.Tests;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void AccuPrijsBerekenenJuist()
    {
        var accu = new Accu("Accu", 250f, 250);
        float kostprijs = accu.BerekenKostprijs();
        
        Assert.That(kostprijs, Is.EqualTo(250));
    }
    
    [Test]
    public void AccuPrijsBerekenenFout()
    {
        var accu = new Accu("Accu", 250f, 250);
        float kostprijs = accu.BerekenKostprijs() + 5;

        Assert.That(kostprijs, Is.Not.EqualTo(250));
    }
}
