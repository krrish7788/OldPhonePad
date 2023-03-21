using Xunit;

public class ProgramTests {

    [Theory]
    [InlineData("E", "33#")]
    [InlineData("B", "227*#")]
    [InlineData("HELLO", "4433555 555666#")]
    [InlineData("TURING", "8 88777444666*664#")]
    [InlineData("HELLO WORLD", "4433555 555666096667775553#")]
    [InlineData("MY NAME IS BOB", "699906626330444777702266622#")]
    [InlineData("GOODBYE", "4666 66632299933#")]
    public void TestTheory(string outputSent, string inputSeq) {
        Assert.Equal(outputSent, MyApplication.MobileProgram.OldPhonePad(inputSeq));
    }

}
