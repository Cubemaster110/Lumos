grammar Lumos;

/*
 * Parser Rules
 */
 
 //PEMDAS in a nutshell, with alternative names for the visitor, once we get to that. 
 expr							: NUMBER											#Number
								| display (DIGIT|LETTER+)							#Print
							    | (SIN|COS|TAN|ASIN|ACOS|ATAN) LPAREN expr RPAREN	#TrigFunction
								| LPAREN expr RPAREN								#Parentheses
								| <assoc=right> expr POW expr						#Exponents	
								| expr (TIMES|DIV) expr								#MultiplicationOrDivision
								| expr (MIN|PLUS) expr								#AdditionOrSubtraction
								| EOF												#EOF
								;	

display							: DISPLAY ;

methodCall						: methodName LPAREN methodCallArguments RPAREN ;

methodName						: NAME ;

methodCallArguments				: //None 
								| expr (',' expr)* 
								;
								

relop							: EQ			#EqualTo
								| NE			#NotEqualTo	
								| GE			#GreaterThanOrEqualTo
								| GT			#GreaterThan	
								| LE			#LessThanOrEqualTo
								| LT			#LessThan
								;				
			

assop							: ASSEQ			#AssignEquals
								| ASSDIVEQ		#AssignDivideEquals
								| ASSMULTEQ		#AssignTimesEquals
								| ASSSUBEQ		#AssignMinusEquals
								| ASSPLUSEQ		#AssignPlusEquals
								; 


compileUnit						: EOF ;

/*
 * Lexer Rules
 */

fragment LETTER				: [A-Za-z] ;
fragment DIGIT				: [0-9] ;
fragment S					: ('S'|'s') ;
fragment I					: ('I'|'i') ;
fragment N					: ('N'|'n') ;
fragment C					: ('C'|'c') ;
fragment O					: ('O'|'o') ;
fragment T					: ('T'|'t') ;
fragment A					: ('A'|'a') ;
fragment L					: ('L'|'l') ;
fragment G					: ('G'|'g') ;
fragment Q					: ('Q'|'q') ;
fragment R					: ('R'|'r') ;


//Trig Functions
SIN							: S I N ;

COS							: C O S ;

TAN							: T A N ;

ASIN						: A S I N ;
 
ACOS						: A C O S ;

ATAN						: A T A N ;

//Others
LN							: L N ;

LOG							: L O G ;

SQRT						: S Q R T ;


//Operators

LPAREN						: '(' ;

RPAREN						: ')' ; 

POW							: '^' ;

PLUS						: '+' ;

MIN							: '-' ;

DIV							: '/' ;

TIMES						: '■' ; 

MOD							: '%' ;



//Comparison Operators

GE							: '>''=' ;

GT							: '>' ;

LE							: '<''=' ;

LT							: '<' ;

EQ							: '=''=' ;

NE							: '!''=';

//Assignment Operators. Names consist of Assign (ASS); Operation-Equals (EQ, DIVEQ, MULTEQ)

ASSEQ						: '=' ;

ASSDIVEQ					: '/''=' ;

ASSMULTEQ					: '*''=' ;

ASSSUBEQ					: '-''=' ;

ASSPLUSEQ					: '+''=' ;

//Still ASSOP, but these are for incrementing. 

PLUSPLUS					: '+''+' ;

MINUSMINUS					: '-''-' ;


//Built-In functions
DISPLAY						: 'Display' ;

//Others
NAME						: [a-zA-Z][a-zA-Z0-9]* ;

NUMBER						: DIGIT+ ([.] DIGIT+)? ;

WS							: (' ' | '\t'|'\u000C') -> skip ;
 
NEWLINE						: ('\r'? '\n' | '\r')+ -> skip ;

STRING						: '"' (~["])+ '"' ;
