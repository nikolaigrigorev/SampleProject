namespace Models
{
	public interface ITimeModel
	{
		float DeltaTime { get; }
		float RealTimeSinceStartup { get; }
	}
}