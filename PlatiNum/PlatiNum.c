// PlatiNum.cpp: 定义控制台应用程序的入口点。
//

#include "stdio.h"
#include "stdafx.h"

int main()
{
	float weight;
	float value;
	printf("are you worth your weight in platinum?");
	printf("let check it out");
	printf("please enter your weight in pounds:");
	scanf_s("%f", &weight);
	value = 1700 * weight * 14;
	printf("%2f", value);
	getchar();
    return 0;
}

