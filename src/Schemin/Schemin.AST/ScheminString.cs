
namespace Schemin.AST
{
	public class ScheminString : IScheminType
	{
		public string Value;

		public ScheminString(string value)
		{
			this.Value = value;
		}
	}
}
