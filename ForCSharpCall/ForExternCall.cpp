#ifdef FORCSHARPCALL_EXPORTS //�P�M�צW�١A�u�O�᭱�T�w��_EXPORTS
#define FORCSHARPCALL_API __declspec(dllexport) //�Ъ`�N�I���T���OExport�n�G�_
#else
#define FORCSHARPCALL_API __declspec(dllimport)
#endif

#include "ForCSharpCallDefine.h"

//�i�H�Nclass������ŧi�b�~���ܦ�����
//Calculate cal;

extern "C" FORCSHARPCALL_API int Add(int a, int b)
//extern "C" __declspec(dllexport) int __stdcall Add(int a, int b)
{
	Calculate cal;//�ŧi�bfunction���A�u����function��ϥ�
	return cal.Addition(a, b);
}

extern "C" FORCSHARPCALL_API int Sub(int a, int b)
//extern "C" __declspec(dllexport) int __stdcall Sub(int a, int b)
{
	Calculate cal;//�ŧi�bfunction���A�u����function��ϥ�
	return cal.Subtraction(a, b);
}

extern "C" FORCSHARPCALL_API int Multi(int a, int b)
{
	Calculate cal;//�ŧi�bfunction���A�u����function��ϥ�
	return cal.Multiplication(a, b);
}

extern "C" FORCSHARPCALL_API float Div(int a, int b)
{
	Calculate cal;//�ŧi�bfunction���A�u����function��ϥ�
	return cal.Division(a, b);
}

#include <stdio.h>
#include <Windows.h>

struct Name
{
	char FirstName[100];
	char LastName[100];
	char *Array[3];
};

extern "C" __declspec(dllexport) struct Name __cdecl GetName(struct Name *name)
{
	//strncpy_s(name->FirstName, "FirstName", sizeof(name->FirstName));
	name->Array[0] = "Foo 0";
	name->Array[1] = "Foo 1";
	name->Array[2] = "Foo 2";
	return *name;
}

extern "C" __declspec(dllexport) void __cdecl Hello()
{
	printf("Hello\n");
}

typedef struct FooParams
{
    char *a;
    char *b;
    void *whatever; //some other type
} FooParams;


extern "C" FORCSHARPCALL_API char** Pri(char** ppNames, int iNbOfNames)
//extern "C" _declspec(dllexport) void printnames(char** ppNames, int iNbOfNames)
{
	Calculate cal;
    /*for(int iName=0; iName < iNbOfNames; iName++)
    {
        OutputDebugStringA(ppNames[iName]);
    }*/
	return cal.Printnames(ppNames, iNbOfNames);;
	//return ppNames[4]**;
}





