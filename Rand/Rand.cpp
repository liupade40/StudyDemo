// Rand.cpp: 定义控制台应用程序的入口点。
//

#include "stdafx.h"
#include <iostream>
#include <ctime>
#include <cstdlib>
#include <string>

using namespace std;

//int main()
//{
//	int i, j;
//
//	// 设置种子
//	srand((unsigned)time(NULL));
//
//	/* 生成 10 个随机数 */
//	for (i = 0; i < 10; i++)
//	{
//		// 生成实际的随机数
//		j = rand();
//		cout << "随机数： " << j << endl;
//	}
//
//	return 0;
//
//
//}

//int main()
//{
//	int  var = 20;   // 实际变量的声明
//	int  *ip;        // 指针变量的声明
//
//	ip = &var;       // 在指针变量中存储 var 的地址
//
//	cout << "Value of var variable: ";
//	cout << var << endl;
//
//	// 输出在指针变量中存储的地址
//	cout << "Address stored in ip variable: ";
//	cout << ip << endl;
//
//	// 访问指针中地址的值
//	cout << "Value of *ip variable: ";
//	cout << *ip << endl;
//
//	return 0;
//}

// 函数声明
//double getAverage(int *arr, int size);

//int main()
//{
//	// 带有 5 个元素的整型数组
//	int balance[5] = { 1000, 2, 3, 17, 50 };
//	double avg;
//
//	// 传递一个指向数组的指针作为参数
//	avg = getAverage(balance, 5);
//
//	// 输出返回值
//	cout << "Average value is: " << avg << endl;
//
//	return 0;
//}
//
//double getAverage(int *arr, int size)
//{
//	int    i, sum = 0;
//	double avg=1;
//
//	cout << arr  ;
//
//	return avg;
//}
//void change(int *a, int *b);
//int main()
//{
//	int a=1, b=2;
//	change(&a, &b);
//	cout << a << endl;
//	cout << b << endl;
//}
//
//void change(int *a, int *b)
//{
//	int temp;
//	temp = *a;
//	*a = *b;
//	*b = temp;
//}
//void change(int& a, int& b)
//{
//	int temp;
//	temp = a;
//	a = b;
//	b = temp;
//}

template <typename T>
 T const& Max(T const& a, T const& b)
{
	return a < b ? b : a;
}
int main()
{

	int i = 39;
	int j = 20;
	cout << "Max(i, j): "+ Max(i, j) << endl;

	double f1 = 13.5;
	double f2 = 20.7;
	cout << "Max(f1, f2): " << Max(f1, f2) << endl;

	string s1 = "Hello";
	string s2 = "World";
	cout << "Max(s1, s2): " << Max(s1, s2) << endl;
	cin >> f1;
	cout << f1<<endl;
	return 0;
}