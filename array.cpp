#include "Array.h"
#include <cstdlib>
#include<iostream>
using namespace std;
Array::Array(int size)
{
	//사이즈를 확인하고 양수이면 new를 사용하여 배열 data를 할당, len값 초기화
	if(size<0)
	{
		cout << "error" << endl;
		// 매개변수 size가 음수인 경우 에러메세지를 출력하였음
	}
	else
	{	
		// 매개변수 size가 음수가 아닌 경우 size 만큼의 배열 메모리를 할당해 생성함
		data = new int[size];
		len = size;
	}
}
Array::~Array()
{
	// 소멸자; 할당된 메모리 해제
	delete[] data;
}
int Array::length() const
{
	// 배열의 크기 리턴
	return len;
}

/* left value */
// 배열에 원소를 대입하거나 값을 반환하는 부분으로 []연산자의 오버로딩이다
int& Array::operator[](int i) // 배열에 원소 삽입
{
	static int tmp;

	// 배열의 인덱스가 범위 내에 있으면 값 리턴, 그렇지 않으면 에러메세지 출력하고 tmp리턴
	if(i >= 0 && i < len) // i가 주어진 리스트 범위 내에 있는 경우
	{
		return data[i];
	}
	else // i가 주어진 리스트 범위 밖에 있으면 오류 메세지 출력
	{
		cout << "array bound error!" << endl;
		return tmp;
	}
}

/* right value */
int Array::operator[](int i) const // 배열의 원소값 반환
{
	//배열의 인덱스가 범위 내에 잇으면 값을 리턴, 그렇지 않으면 에러메세지 출력하고 0을 리턴
	if(i >= 0 && i<len) // i가 주어진 리스트 범위 내에 있는 경우
	{
		return data[i];
	}
	else // i가 주어진 리스트 범위 밖에 있으면 오류 메세지 출력
	{
		cout << "array bound error!" << endl;
		return 0;
	}
}
void Array::print() //배열의 모든 내용을 출력해주는 함수
{
	int i;
	cout << "[";
	for (i = 0; i < len; i++) // 반복문을 통해 리스트의 전체 원소를 출력함
		cout << " " << data[i];
	cout << "]";
	cout << endl; // 마지막 줄바꿈
}
