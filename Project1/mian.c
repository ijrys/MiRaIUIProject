#include <stdio.h>
#include <stdlib.h>

int main (void) {
	int z = 10;
	int x = sizeof (z++);
	z++;
	printf ("%d\n", z);


	system ("pause");
	return 0;
}