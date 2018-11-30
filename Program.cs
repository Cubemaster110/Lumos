using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using Antlr4.Runtime;

namespace Lumos
{
	class Program
	{
		static void Main(string[] args)
		{

			//string input = "10■4-2■(4^2/4)/2/(1/2)+9"; //41
			//string input = "♫";
			string input = Console.ReadLine();
			while (input != "exit")
			{

				AntlrInputStream inputStream = new AntlrInputStream(input);
				LumosLexer lumosLexer = new LumosLexer(inputStream);
				CommonTokenStream commonTokenStream = new CommonTokenStream

					(lumosLexer);
				LumosParser lumosParser = new LumosParser(commonTokenStream);

				LumosParser.ExprContext expressionContext = lumosParser.expr();
				LumosVisitor visitor = new LumosVisitor();
				Console.WriteLine($">> {visitor.Visit(expressionContext)}");
				input = Console.ReadLine();
			}

		}
	}
}











