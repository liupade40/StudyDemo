// ChangeValue.cpp: 定义控制台应用程序的入口点。
//

#include "stdafx.h"
#include <stdio.h>
void Method2(int a)
{
	a = 30;
	printf("a=%d\n", a);
}
void Method(int *i)
{
	*i = 20;
}

void MethodArray(int *p, int count)
{

	for (int i = 0; i < count; i++)
	{
		printf("%d\n", *p + i);
	}
}
int main()
{
	int a = 10;
	Method2(a);
	int i = 10;
	Method(&i);
	printf("i= %d\n", i);
	int number[] = { 1,2,3,4,5 };
	int count = sizeof(number) / sizeof(number[0]);
	MethodArray(number, count);
	int *p2 = number;
	for (int i = 0; i < count; i++)
	{
		printf("%d\n", number[i]);
	}
	return 0;
}

