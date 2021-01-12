/*Arrays are a data structure for storing multiple variables
 * 
 * working with storing 3 numbers, you would do
*/
int number1;
int number2;
int number3;

int[] numbers = new int[3];
/* Where the first "int[]" is used to tell the compiler we are declaring an array,
 *the second "int[3]" is stating how large the array should be 
 *
 *you must allocate memory for an array, so we use the "new" operator
 *
 *with the declared array we can access its elements using an index we supply in the square brackets
 *
 *arrays are zero-indexed, meaning the array's first element's index is 0, the second is 1. and so on.
 *this looks like so */
int[] numbers = new int[3];

numbers[0] = 1;
numbers[1] = 2;
numbers[2] = 3;

/* If you know the values you wish to store in the array ahead of time, you can use object initialization syntax to shortem the code like this*/
int[] numbers = new int[3] { 1, 2, 3 };