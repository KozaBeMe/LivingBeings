public class DominoTile
{
    public int LeftValue { get; }
    public int RightValue { get; }

    public DominoTile(int leftValue, int rightValue)
    {
        LeftValue = leftValue;
        RightValue = rightValue;
    }

    public int[] GetValues()
    {
        return new[] { LeftValue, RightValue };
    }

    public override string ToString()
    {
        return $"[{LeftValue}|{RightValue}]";
    }
}