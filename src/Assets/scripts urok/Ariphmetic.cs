
public class Ariphmetic
{
    public float? TryGetValue(float v1, float v2 , Operation operation)
    {
        switch(operation)
        {
            case Operation.Sum: return v1 + v2;

            case Operation.Sub: return v1 - v2;

            case Operation.Mul: return v1 * v2;

            case Operation.Div: return v1 / v2;
        }

        return null;
    }
}
public enum Operation
{
    Sum,
    Sub,
    Mul,
    Div,
}