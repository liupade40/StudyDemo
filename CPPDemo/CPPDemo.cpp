// CPPDemo.cpp: 定义控制台应用程序的入口点。
//
#include <iostream>
#include "stdafx.h"
using namespace std;

int main()
{
	cout << "Hello, world!" << endl;
    return 0;
}
extern "C" __declspec(dllexport) int Add(int a, int b)
{

	return a + b;
}
