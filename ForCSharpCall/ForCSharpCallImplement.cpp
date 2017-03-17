#include "ForCSharpCallDefine.h"

Calculate::Calculate()
{

}

int Calculate::Addition(int a, int b)
{
	return a + b;
}

int Calculate::Subtraction(int a, int b)
{
	return a - b;
}

int Calculate::Multiplication(int a, int b)
{
	return a * b;
}

float Calculate::Division(int a, int b)
{
	return (float)a / b;
}


char** Calculate::Printnames(char** ppNames, int iNbOfNames)
{
	ppNames[3] = "aaa";
	ppNames[4] = "abc";
	return ppNames;
}