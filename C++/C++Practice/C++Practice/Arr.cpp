#include "Arr.h"
#include <iostream>

void trrInit(tArr* tArr)
{
	tArr->a = (int*)malloc(sizeof(int) * 2);
	tArr->count = 0;
	tArr->maxcount = 2;
}

void push_back(tArr* tArr, int value)
{
	if (tArr->maxcount <= tArr->count)
	{
		trrReSize(tArr);
	}
	tArr->a[tArr->count++] = value;
	bubbleSort(tArr);

}

void trrReSize(tArr* tArr)
{
	int* resize = (int*)malloc(tArr->maxcount * sizeof(int) * 2);
	for (int i = 0; i < tArr->count; i++)
	{
		resize[i] = tArr->a[i];
	}
	free(tArr->a);
	tArr->a = resize;
	tArr->maxcount *= 2;
}

void Remove(tArr* tArr)
{
	free(tArr->a);
	tArr->count = 0;
	tArr->maxcount = 0;
}

void bubbleSort(tArr* tArr)
{
	int temp;
	for (int i = tArr->count -1;  i > 0; i--)
	{
		for (int j = 0; j < i; j++)
		{
			if (tArr->a[j] > tArr->a[j + 1])
			{
				temp = tArr->a[j];
				tArr->a[j] = tArr->a[j + 1];
				tArr->a[j + 1] = temp;
			}
		}
		
	}
}
