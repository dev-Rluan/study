#pragma once

typedef struct _trr
{
	int* a;
	int maxcount;
	int count;
	
}tArr;

void trrInit(tArr* tArr);

void push_back(tArr* tArr, int value);

void trrReSize(tArr* tArr);

void Remove(tArr* tArr);

void bubbleSort(tArr* tArr);