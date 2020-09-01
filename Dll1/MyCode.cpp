#include "stdafx.h"
#include "MyCode.h"
int Add(int a, int b)
{
	return (a + b);
}
void Add2(int *p)
{
	int i = 11111;
	p = &i;
}