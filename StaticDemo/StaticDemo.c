// StaticDemo.cpp: 定义控制台应用程序的入口点。
//

#include "stdafx.h"
#include "my.h"
#include <errno.h>
#include <string.h>
#include <stdio.h>
/* 函数声明 */
//void func1(void);
//
// int count = 10;        /* 全局变量 - static 是默认的 */
//
//int main()
//{
//	while (count--)
//	{
//		func1();
//	}
//	return 0;
//}
//
//void func1(void)
//{
//	/* 'thingy' 是 'func1' 的局部变量 - 只初始化一次
//	* 每次调用函数 'func1' 'thingy' 值不会被重置。
//	*/
//	static int thingy = 5;
//	thingy++;
//	printf(" thingy 为 %d ， count 为 %d\n", thingy, count);
//}

//int main()
//{
//	int  var = 20;   /* 实际变量的声明 */
//	int  *ip;        /* 指针变量的声明 */
//
//	ip = &var;  /* 在指针变量中存储 var 的地址 */
//
//	printf("Address of var variable: %p\n", &var);
//
//	/* 在指针变量中存储的地址 */
//	printf("Address stored in ip variable: %p\n", ip);
//
//	/* 使用指针访问值 */
//	printf("Value of *ip variable: %d\n", *ip);
//
//	return 0;
//}


//const int MAX = 3;
//
//int main()
//{
//	int  var[] = { 10, 100, 200 };
//	int  i, *ptr;
//
//	/* 指针中的数组地址 */
//	ptr = var;
//	for (i = 0; i < MAX; i++)
//	{
//
//		printf("存储地址：var[%d] = %x\n", i, ptr);
//		printf("存储值：var[%d] = %d\n", i, *ptr);
//
//		/* 移动到下一个位置 */
//		ptr++;
//	}
//	return 0;
//}

//int main()
//{
//	myself("1000s");
//	return 0;
//}

extern int errno;

int main()
{
	FILE * pf;
	int errnum;
	pf = fopen_s(pf,"unexist.txt", "rb");
	if (pf == NULL)
	{
		errnum = errno;
		fprintf(pf,stderr, "错误号: %d\n", errno);
		perror("通过 perror 输出错误");
		fprintf(stderr, "打开文件错误: %s\n", strerror_s("111",sizeof(""), errnum));
	}
	else
	{
		fclose(pf);
	}
	return 0;
}