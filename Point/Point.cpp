// Point.cpp: 定义控制台应用程序的入口点。
//
#include "stdafx.h"
#include <stdio.h>

int main()
{
	int i = 23;
	int *p;
	p = &i;
	int *a;
	a = p;
	*p = 20;
	printf("p=%d,&i=%d\n", *p, i);
	
	return 0;
}

