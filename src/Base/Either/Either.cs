using System.Text.Json.Serialization;

namespace Base.Either;

public record Either<T>
{
    public Error? Left  { get; }
    public T?     Right { get; }

    private Either()
    {
    }

    [JsonConstructor]
    public Either(Error left, T right)
    {
        Left  = left;
        Right = right;
    }

    public Either(T right) => Right = right;
    public Either(Error left) => Left = left;

    public static implicit operator Either<T>(T right) => new(right);

    public static implicit operator Either<T>(Error left) => new(left);
}