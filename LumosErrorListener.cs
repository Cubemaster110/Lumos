using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Antlr4.Runtime;

namespace Lumos
{
	class LumosErrorListener : BaseErrorListener
	{
		public String Symbol { get; private set; }
		public StringWriter Writer { get; private set; }

		public LumosErrorListener(StringWriter writer)
		{
			Writer = writer;
		}

		// if you are generating the parser with the Java tool change the signature to the following
		// public override void SyntaxError(TextWriter output, IRecognizer recognizer, IToken offendingSymbol, int line, int charPositionInLine, string msg, RecognitionException e)
		public override void SyntaxError(IRecognizer recognizer, IToken offendingSymbol, int line, int charPositionInLine, string msg, RecognitionException e)
		{
			Writer.WriteLine(msg);

			Symbol = offendingSymbol.Text;
		}
	}
}
