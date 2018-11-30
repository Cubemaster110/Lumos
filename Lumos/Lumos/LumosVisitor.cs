using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;

namespace Lumos
{
	class LumosVisitor : LumosBaseVisitor<double>
	{
		public override double VisitNumber(LumosParser.NumberContext context)
		{
			return double.Parse(context.NUMBER().GetText(),System.Globalization.CultureInfo.InvariantCulture);
		}

		public override double VisitParentheses(LumosParser.ParenthesesContext context)
		{
			return Visit(context.expr());
		}

		public override double VisitExponents(LumosParser.ExponentsContext context)
		{
			double left = Visit(context.expr(0));
			double right = Visit(context.expr(1));
			double result = 0;

			if (context.POW() != null)
				result = Math.Pow(left, right);
			return result;
		}

		public override double VisitAdditionOrSubtraction(LumosParser.AdditionOrSubtractionContext context)
		{

			double left = Visit(context.expr(0));
			double right = Visit(context.expr(1));
			double result = 0;

			if (context.MIN() != null)
				result = left - right;
			if (context.PLUS() != null)
				result = left + right;
			return result;
		}

		public override double VisitMultiplicationOrDivision(LumosParser.MultiplicationOrDivisionContext context)
		{
			double left = Visit(context.expr(0));
			double right = Visit(context.expr(1));
			double result = 0;

			if (context.DIV() != null)
				result = left / right;
			if (context.TIMES() != null)
				result = left * right;
			return result;
		}

		public override double VisitTrigFunction(LumosParser.TrigFunctionContext context)
		{
			double expr = Visit(context.expr());
			double result = 0;

			if (context.SIN() != null)
				result = Math.Sin(expr);
			if (context.COS() != null)
				result = Math.Cos(expr);
			if (context.TAN() != null)
				result = Math.Tan(expr);
			if (context.ASIN() != null)
				result = Math.Asin(expr);
			if (context.ACOS() != null)
				result = Math.Atan(expr);
			if (context.ATAN() != null)
				result = Math.Atan(expr);

			return result;
		}

		public override double VisitMethodCall(LumosParser.MethodCallContext context)
		{
			var methodName = Visit(context.methodName());
			var methodCallArguments = Visit(context.methodCallArguments());

			if (methodName.Equals("Print"))
			{
				Console.WriteLine(methodCallArguments);
			}

			return 0.0;
		}

		public override double VisitPrint(LumosParser.PrintContext context)
		{
			string output = "";
			if (context.DIGIT() != null)
				output = context.GetText();
			if (context.LETTER() != null)
				output = context.LETTER().ToString();
			Console.WriteLine(output);
			//if (context.DIGIT() != null)
			//	Console.WriteLine(content);
			//if (context.LETTER() != null)
			//	Console.WriteLine(content);
			return 0.0;
		}

	}
}





