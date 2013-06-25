namespace NancyDash
{
	using Nancy;

	public class HelloModule : NancyModule
	{
		public HelloModule()
		{
			Get["/"] = parameters => View["grid.html"];
		}
	}
}