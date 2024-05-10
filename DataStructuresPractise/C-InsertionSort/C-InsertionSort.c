#include <stdio.h>
#include <math.h>

void Insertionsort(int arr[], int n) {

	int i, key, j;
	for (i = 1; i < n; i++) {
		key = arr[i];
		j = i - 1;
		while (j >= 0 && arr[j] > key) {
			arr[j + 1] = arr[j];
			j -= 1;

		}
		arr[j + 1] = key;
	}
}
void OutputArray(int arr[], int n) {
	int i;
	for (i = 0; i < n; i++) {
		printf("%d\t", arr[i]);
		//printf("\n");
	}
		
	
}

int main()
{
	int arr[]= { 12,11,13,5,6 };
	int n = sizeof(arr) / sizeof(arr[0]);

	Insertionsort(arr, n);
	OutputArray(arr, n);

	return 0;
}
