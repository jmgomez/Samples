using System;

namespace TemplateRazor
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			var template = new HelloWorld(){Model = new Foo()};
			Console.WriteLine(template.GenerateString());
		}
	}
}
