//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.6.6-SNAPSHOT
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from C:\Users\Winship\Desktop\Senior Project\SENIOR PROJ\Lumos\Lumos\Lumos.g4 by ANTLR 4.6.6-SNAPSHOT

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

namespace Lumos {
using Antlr4.Runtime;
using Antlr4.Runtime.Atn;
using Antlr4.Runtime.Misc;
using DFA = Antlr4.Runtime.Dfa.DFA;

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.6.6-SNAPSHOT")]
[System.CLSCompliant(false)]
public partial class LumosLexer : Lexer {
	public const int
		T__0=1, SIN=2, COS=3, TAN=4, ASIN=5, ACOS=6, ATAN=7, LN=8, LOG=9, SQRT=10, 
		LPAREN=11, RPAREN=12, POW=13, PLUS=14, MIN=15, DIV=16, TIMES=17, MOD=18, 
		GE=19, GT=20, LE=21, LT=22, EQ=23, NE=24, ASSEQ=25, ASSDIVEQ=26, ASSMULTEQ=27, 
		ASSSUBEQ=28, ASSPLUSEQ=29, PLUSPLUS=30, MINUSMINUS=31, DISPLAY=32, NAME=33, 
		NUMBER=34, WS=35, NEWLINE=36, STRING=37;
	public static string[] modeNames = {
		"DEFAULT_MODE"
	};

	public static readonly string[] ruleNames = {
		"T__0", "LETTER", "DIGIT", "S", "I", "N", "C", "O", "T", "A", "L", "G", 
		"Q", "R", "SIN", "COS", "TAN", "ASIN", "ACOS", "ATAN", "LN", "LOG", "SQRT", 
		"LPAREN", "RPAREN", "POW", "PLUS", "MIN", "DIV", "TIMES", "MOD", "GE", 
		"GT", "LE", "LT", "EQ", "NE", "ASSEQ", "ASSDIVEQ", "ASSMULTEQ", "ASSSUBEQ", 
		"ASSPLUSEQ", "PLUSPLUS", "MINUSMINUS", "DISPLAY", "NAME", "NUMBER", "WS", 
		"NEWLINE", "STRING"
	};


	public LumosLexer(ICharStream input)
		: base(input)
	{
		_interp = new LexerATNSimulator(this,_ATN);
	}

	private static readonly string[] _LiteralNames = {
		null, "','", null, null, null, null, null, null, null, null, null, "'('", 
		"')'", "'^'", "'+'", "'-'", "'/'", "'■'", "'%'", null, "'>'", null, "'<'", 
		null, null, "'='", null, null, null, null, null, null, "'Display'"
	};
	private static readonly string[] _SymbolicNames = {
		null, null, "SIN", "COS", "TAN", "ASIN", "ACOS", "ATAN", "LN", "LOG", 
		"SQRT", "LPAREN", "RPAREN", "POW", "PLUS", "MIN", "DIV", "TIMES", "MOD", 
		"GE", "GT", "LE", "LT", "EQ", "NE", "ASSEQ", "ASSDIVEQ", "ASSMULTEQ", 
		"ASSSUBEQ", "ASSPLUSEQ", "PLUSPLUS", "MINUSMINUS", "DISPLAY", "NAME", 
		"NUMBER", "WS", "NEWLINE", "STRING"
	};
	public static readonly IVocabulary DefaultVocabulary = new Vocabulary(_LiteralNames, _SymbolicNames);

	[System.Obsolete("Use Vocabulary instead.")]
	public static readonly string[] tokenNames = GenerateTokenNames(DefaultVocabulary, _SymbolicNames.Length);

	private static string[] GenerateTokenNames(IVocabulary vocabulary, int length) {
		string[] tokenNames = new string[length];
		for (int i = 0; i < tokenNames.Length; i++) {
			tokenNames[i] = vocabulary.GetLiteralName(i);
			if (tokenNames[i] == null) {
				tokenNames[i] = vocabulary.GetSymbolicName(i);
			}

			if (tokenNames[i] == null) {
				tokenNames[i] = "<INVALID>";
			}
		}

		return tokenNames;
	}

	[System.Obsolete("Use IRecognizer.Vocabulary instead.")]
	public override string[] TokenNames
	{
		get
		{
			return tokenNames;
		}
	}

	[NotNull]
	public override IVocabulary Vocabulary
	{
		get
		{
			return DefaultVocabulary;
		}
	}

	public override string GrammarFileName { get { return "Lumos.g4"; } }

	public override string[] RuleNames { get { return ruleNames; } }

	public override string[] ModeNames { get { return modeNames; } }

	public override string SerializedAtn { get { return _serializedATN; } }

	public static readonly string _serializedATN =
		"\x3\xAF6F\x8320\x479D\xB75C\x4880\x1605\x191C\xAB37\x2\'\x111\b\x1\x4"+
		"\x2\t\x2\x4\x3\t\x3\x4\x4\t\x4\x4\x5\t\x5\x4\x6\t\x6\x4\a\t\a\x4\b\t\b"+
		"\x4\t\t\t\x4\n\t\n\x4\v\t\v\x4\f\t\f\x4\r\t\r\x4\xE\t\xE\x4\xF\t\xF\x4"+
		"\x10\t\x10\x4\x11\t\x11\x4\x12\t\x12\x4\x13\t\x13\x4\x14\t\x14\x4\x15"+
		"\t\x15\x4\x16\t\x16\x4\x17\t\x17\x4\x18\t\x18\x4\x19\t\x19\x4\x1A\t\x1A"+
		"\x4\x1B\t\x1B\x4\x1C\t\x1C\x4\x1D\t\x1D\x4\x1E\t\x1E\x4\x1F\t\x1F\x4 "+
		"\t \x4!\t!\x4\"\t\"\x4#\t#\x4$\t$\x4%\t%\x4&\t&\x4\'\t\'\x4(\t(\x4)\t"+
		")\x4*\t*\x4+\t+\x4,\t,\x4-\t-\x4.\t.\x4/\t/\x4\x30\t\x30\x4\x31\t\x31"+
		"\x4\x32\t\x32\x4\x33\t\x33\x3\x2\x3\x2\x3\x3\x3\x3\x3\x4\x3\x4\x3\x5\x3"+
		"\x5\x3\x6\x3\x6\x3\a\x3\a\x3\b\x3\b\x3\t\x3\t\x3\n\x3\n\x3\v\x3\v\x3\f"+
		"\x3\f\x3\r\x3\r\x3\xE\x3\xE\x3\xF\x3\xF\x3\x10\x3\x10\x3\x10\x3\x10\x3"+
		"\x11\x3\x11\x3\x11\x3\x11\x3\x12\x3\x12\x3\x12\x3\x12\x3\x13\x3\x13\x3"+
		"\x13\x3\x13\x3\x13\x3\x14\x3\x14\x3\x14\x3\x14\x3\x14\x3\x15\x3\x15\x3"+
		"\x15\x3\x15\x3\x15\x3\x16\x3\x16\x3\x16\x3\x17\x3\x17\x3\x17\x3\x17\x3"+
		"\x18\x3\x18\x3\x18\x3\x18\x3\x18\x3\x19\x3\x19\x3\x1A\x3\x1A\x3\x1B\x3"+
		"\x1B\x3\x1C\x3\x1C\x3\x1D\x3\x1D\x3\x1E\x3\x1E\x3\x1F\x3\x1F\x3 \x3 \x3"+
		"!\x3!\x3!\x3\"\x3\"\x3#\x3#\x3#\x3$\x3$\x3%\x3%\x3%\x3&\x3&\x3&\x3\'\x3"+
		"\'\x3(\x3(\x3(\x3)\x3)\x3)\x3*\x3*\x3*\x3+\x3+\x3+\x3,\x3,\x3,\x3-\x3"+
		"-\x3-\x3.\x3.\x3.\x3.\x3.\x3.\x3.\x3.\x3/\x3/\a/\xE9\n/\f/\xE/\xEC\v/"+
		"\x3\x30\x6\x30\xEF\n\x30\r\x30\xE\x30\xF0\x3\x30\x3\x30\x6\x30\xF5\n\x30"+
		"\r\x30\xE\x30\xF6\x5\x30\xF9\n\x30\x3\x31\x3\x31\x3\x31\x3\x31\x3\x32"+
		"\x5\x32\x100\n\x32\x3\x32\x3\x32\x6\x32\x104\n\x32\r\x32\xE\x32\x105\x3"+
		"\x32\x3\x32\x3\x33\x3\x33\x6\x33\x10C\n\x33\r\x33\xE\x33\x10D\x3\x33\x3"+
		"\x33\x2\x2\x2\x34\x3\x2\x3\x5\x2\x2\a\x2\x2\t\x2\x2\v\x2\x2\r\x2\x2\xF"+
		"\x2\x2\x11\x2\x2\x13\x2\x2\x15\x2\x2\x17\x2\x2\x19\x2\x2\x1B\x2\x2\x1D"+
		"\x2\x2\x1F\x2\x4!\x2\x5#\x2\x6%\x2\a\'\x2\b)\x2\t+\x2\n-\x2\v/\x2\f\x31"+
		"\x2\r\x33\x2\xE\x35\x2\xF\x37\x2\x10\x39\x2\x11;\x2\x12=\x2\x13?\x2\x14"+
		"\x41\x2\x15\x43\x2\x16\x45\x2\x17G\x2\x18I\x2\x19K\x2\x1AM\x2\x1BO\x2"+
		"\x1CQ\x2\x1DS\x2\x1EU\x2\x1FW\x2 Y\x2![\x2\"]\x2#_\x2$\x61\x2%\x63\x2"+
		"&\x65\x2\'\x3\x2\x13\x4\x2\x43\\\x63|\x3\x2\x32;\x4\x2UUuu\x4\x2KKkk\x4"+
		"\x2PPpp\x4\x2\x45\x45\x65\x65\x4\x2QQqq\x4\x2VVvv\x4\x2\x43\x43\x63\x63"+
		"\x4\x2NNnn\x4\x2IIii\x4\x2SSss\x4\x2TTtt\x5\x2\x32;\x43\\\x63|\x3\x2\x30"+
		"\x30\x5\x2\v\v\xE\xE\"\"\x3\x2$$\x10B\x2\x3\x3\x2\x2\x2\x2\x1F\x3\x2\x2"+
		"\x2\x2!\x3\x2\x2\x2\x2#\x3\x2\x2\x2\x2%\x3\x2\x2\x2\x2\'\x3\x2\x2\x2\x2"+
		")\x3\x2\x2\x2\x2+\x3\x2\x2\x2\x2-\x3\x2\x2\x2\x2/\x3\x2\x2\x2\x2\x31\x3"+
		"\x2\x2\x2\x2\x33\x3\x2\x2\x2\x2\x35\x3\x2\x2\x2\x2\x37\x3\x2\x2\x2\x2"+
		"\x39\x3\x2\x2\x2\x2;\x3\x2\x2\x2\x2=\x3\x2\x2\x2\x2?\x3\x2\x2\x2\x2\x41"+
		"\x3\x2\x2\x2\x2\x43\x3\x2\x2\x2\x2\x45\x3\x2\x2\x2\x2G\x3\x2\x2\x2\x2"+
		"I\x3\x2\x2\x2\x2K\x3\x2\x2\x2\x2M\x3\x2\x2\x2\x2O\x3\x2\x2\x2\x2Q\x3\x2"+
		"\x2\x2\x2S\x3\x2\x2\x2\x2U\x3\x2\x2\x2\x2W\x3\x2\x2\x2\x2Y\x3\x2\x2\x2"+
		"\x2[\x3\x2\x2\x2\x2]\x3\x2\x2\x2\x2_\x3\x2\x2\x2\x2\x61\x3\x2\x2\x2\x2"+
		"\x63\x3\x2\x2\x2\x2\x65\x3\x2\x2\x2\x3g\x3\x2\x2\x2\x5i\x3\x2\x2\x2\a"+
		"k\x3\x2\x2\x2\tm\x3\x2\x2\x2\vo\x3\x2\x2\x2\rq\x3\x2\x2\x2\xFs\x3\x2\x2"+
		"\x2\x11u\x3\x2\x2\x2\x13w\x3\x2\x2\x2\x15y\x3\x2\x2\x2\x17{\x3\x2\x2\x2"+
		"\x19}\x3\x2\x2\x2\x1B\x7F\x3\x2\x2\x2\x1D\x81\x3\x2\x2\x2\x1F\x83\x3\x2"+
		"\x2\x2!\x87\x3\x2\x2\x2#\x8B\x3\x2\x2\x2%\x8F\x3\x2\x2\x2\'\x94\x3\x2"+
		"\x2\x2)\x99\x3\x2\x2\x2+\x9E\x3\x2\x2\x2-\xA1\x3\x2\x2\x2/\xA5\x3\x2\x2"+
		"\x2\x31\xAA\x3\x2\x2\x2\x33\xAC\x3\x2\x2\x2\x35\xAE\x3\x2\x2\x2\x37\xB0"+
		"\x3\x2\x2\x2\x39\xB2\x3\x2\x2\x2;\xB4\x3\x2\x2\x2=\xB6\x3\x2\x2\x2?\xB8"+
		"\x3\x2\x2\x2\x41\xBA\x3\x2\x2\x2\x43\xBD\x3\x2\x2\x2\x45\xBF\x3\x2\x2"+
		"\x2G\xC2\x3\x2\x2\x2I\xC4\x3\x2\x2\x2K\xC7\x3\x2\x2\x2M\xCA\x3\x2\x2\x2"+
		"O\xCC\x3\x2\x2\x2Q\xCF\x3\x2\x2\x2S\xD2\x3\x2\x2\x2U\xD5\x3\x2\x2\x2W"+
		"\xD8\x3\x2\x2\x2Y\xDB\x3\x2\x2\x2[\xDE\x3\x2\x2\x2]\xE6\x3\x2\x2\x2_\xEE"+
		"\x3\x2\x2\x2\x61\xFA\x3\x2\x2\x2\x63\x103\x3\x2\x2\x2\x65\x109\x3\x2\x2"+
		"\x2gh\a.\x2\x2h\x4\x3\x2\x2\x2ij\t\x2\x2\x2j\x6\x3\x2\x2\x2kl\t\x3\x2"+
		"\x2l\b\x3\x2\x2\x2mn\t\x4\x2\x2n\n\x3\x2\x2\x2op\t\x5\x2\x2p\f\x3\x2\x2"+
		"\x2qr\t\x6\x2\x2r\xE\x3\x2\x2\x2st\t\a\x2\x2t\x10\x3\x2\x2\x2uv\t\b\x2"+
		"\x2v\x12\x3\x2\x2\x2wx\t\t\x2\x2x\x14\x3\x2\x2\x2yz\t\n\x2\x2z\x16\x3"+
		"\x2\x2\x2{|\t\v\x2\x2|\x18\x3\x2\x2\x2}~\t\f\x2\x2~\x1A\x3\x2\x2\x2\x7F"+
		"\x80\t\r\x2\x2\x80\x1C\x3\x2\x2\x2\x81\x82\t\xE\x2\x2\x82\x1E\x3\x2\x2"+
		"\x2\x83\x84\x5\t\x5\x2\x84\x85\x5\v\x6\x2\x85\x86\x5\r\a\x2\x86 \x3\x2"+
		"\x2\x2\x87\x88\x5\xF\b\x2\x88\x89\x5\x11\t\x2\x89\x8A\x5\t\x5\x2\x8A\""+
		"\x3\x2\x2\x2\x8B\x8C\x5\x13\n\x2\x8C\x8D\x5\x15\v\x2\x8D\x8E\x5\r\a\x2"+
		"\x8E$\x3\x2\x2\x2\x8F\x90\x5\x15\v\x2\x90\x91\x5\t\x5\x2\x91\x92\x5\v"+
		"\x6\x2\x92\x93\x5\r\a\x2\x93&\x3\x2\x2\x2\x94\x95\x5\x15\v\x2\x95\x96"+
		"\x5\xF\b\x2\x96\x97\x5\x11\t\x2\x97\x98\x5\t\x5\x2\x98(\x3\x2\x2\x2\x99"+
		"\x9A\x5\x15\v\x2\x9A\x9B\x5\x13\n\x2\x9B\x9C\x5\x15\v\x2\x9C\x9D\x5\r"+
		"\a\x2\x9D*\x3\x2\x2\x2\x9E\x9F\x5\x17\f\x2\x9F\xA0\x5\r\a\x2\xA0,\x3\x2"+
		"\x2\x2\xA1\xA2\x5\x17\f\x2\xA2\xA3\x5\x11\t\x2\xA3\xA4\x5\x19\r\x2\xA4"+
		".\x3\x2\x2\x2\xA5\xA6\x5\t\x5\x2\xA6\xA7\x5\x1B\xE\x2\xA7\xA8\x5\x1D\xF"+
		"\x2\xA8\xA9\x5\x13\n\x2\xA9\x30\x3\x2\x2\x2\xAA\xAB\a*\x2\x2\xAB\x32\x3"+
		"\x2\x2\x2\xAC\xAD\a+\x2\x2\xAD\x34\x3\x2\x2\x2\xAE\xAF\a`\x2\x2\xAF\x36"+
		"\x3\x2\x2\x2\xB0\xB1\a-\x2\x2\xB1\x38\x3\x2\x2\x2\xB2\xB3\a/\x2\x2\xB3"+
		":\x3\x2\x2\x2\xB4\xB5\a\x31\x2\x2\xB5<\x3\x2\x2\x2\xB6\xB7\a\x25A2\x2"+
		"\x2\xB7>\x3\x2\x2\x2\xB8\xB9\a\'\x2\x2\xB9@\x3\x2\x2\x2\xBA\xBB\a@\x2"+
		"\x2\xBB\xBC\a?\x2\x2\xBC\x42\x3\x2\x2\x2\xBD\xBE\a@\x2\x2\xBE\x44\x3\x2"+
		"\x2\x2\xBF\xC0\a>\x2\x2\xC0\xC1\a?\x2\x2\xC1\x46\x3\x2\x2\x2\xC2\xC3\a"+
		">\x2\x2\xC3H\x3\x2\x2\x2\xC4\xC5\a?\x2\x2\xC5\xC6\a?\x2\x2\xC6J\x3\x2"+
		"\x2\x2\xC7\xC8\a#\x2\x2\xC8\xC9\a?\x2\x2\xC9L\x3\x2\x2\x2\xCA\xCB\a?\x2"+
		"\x2\xCBN\x3\x2\x2\x2\xCC\xCD\a\x31\x2\x2\xCD\xCE\a?\x2\x2\xCEP\x3\x2\x2"+
		"\x2\xCF\xD0\a,\x2\x2\xD0\xD1\a?\x2\x2\xD1R\x3\x2\x2\x2\xD2\xD3\a/\x2\x2"+
		"\xD3\xD4\a?\x2\x2\xD4T\x3\x2\x2\x2\xD5\xD6\a-\x2\x2\xD6\xD7\a?\x2\x2\xD7"+
		"V\x3\x2\x2\x2\xD8\xD9\a-\x2\x2\xD9\xDA\a-\x2\x2\xDAX\x3\x2\x2\x2\xDB\xDC"+
		"\a/\x2\x2\xDC\xDD\a/\x2\x2\xDDZ\x3\x2\x2\x2\xDE\xDF\a\x46\x2\x2\xDF\xE0"+
		"\ak\x2\x2\xE0\xE1\au\x2\x2\xE1\xE2\ar\x2\x2\xE2\xE3\an\x2\x2\xE3\xE4\a"+
		"\x63\x2\x2\xE4\xE5\a{\x2\x2\xE5\\\x3\x2\x2\x2\xE6\xEA\t\x2\x2\x2\xE7\xE9"+
		"\t\xF\x2\x2\xE8\xE7\x3\x2\x2\x2\xE9\xEC\x3\x2\x2\x2\xEA\xE8\x3\x2\x2\x2"+
		"\xEA\xEB\x3\x2\x2\x2\xEB^\x3\x2\x2\x2\xEC\xEA\x3\x2\x2\x2\xED\xEF\x5\a"+
		"\x4\x2\xEE\xED\x3\x2\x2\x2\xEF\xF0\x3\x2\x2\x2\xF0\xEE\x3\x2\x2\x2\xF0"+
		"\xF1\x3\x2\x2\x2\xF1\xF8\x3\x2\x2\x2\xF2\xF4\t\x10\x2\x2\xF3\xF5\x5\a"+
		"\x4\x2\xF4\xF3\x3\x2\x2\x2\xF5\xF6\x3\x2\x2\x2\xF6\xF4\x3\x2\x2\x2\xF6"+
		"\xF7\x3\x2\x2\x2\xF7\xF9\x3\x2\x2\x2\xF8\xF2\x3\x2\x2\x2\xF8\xF9\x3\x2"+
		"\x2\x2\xF9`\x3\x2\x2\x2\xFA\xFB\t\x11\x2\x2\xFB\xFC\x3\x2\x2\x2\xFC\xFD"+
		"\b\x31\x2\x2\xFD\x62\x3\x2\x2\x2\xFE\x100\a\xF\x2\x2\xFF\xFE\x3\x2\x2"+
		"\x2\xFF\x100\x3\x2\x2\x2\x100\x101\x3\x2\x2\x2\x101\x104\a\f\x2\x2\x102"+
		"\x104\a\xF\x2\x2\x103\xFF\x3\x2\x2\x2\x103\x102\x3\x2\x2\x2\x104\x105"+
		"\x3\x2\x2\x2\x105\x103\x3\x2\x2\x2\x105\x106\x3\x2\x2\x2\x106\x107\x3"+
		"\x2\x2\x2\x107\x108\b\x32\x2\x2\x108\x64\x3\x2\x2\x2\x109\x10B\a$\x2\x2"+
		"\x10A\x10C\n\x12\x2\x2\x10B\x10A\x3\x2\x2\x2\x10C\x10D\x3\x2\x2\x2\x10D"+
		"\x10B\x3\x2\x2\x2\x10D\x10E\x3\x2\x2\x2\x10E\x10F\x3\x2\x2\x2\x10F\x110"+
		"\a$\x2\x2\x110\x66\x3\x2\x2\x2\v\x2\xEA\xF0\xF6\xF8\xFF\x103\x105\x10D"+
		"\x3\b\x2\x2";
	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN.ToCharArray());
}
} // namespace Lumos
