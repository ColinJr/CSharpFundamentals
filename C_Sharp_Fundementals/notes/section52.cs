/* Arrays
 * 2 kinds, single dimensional, and multidimensional
 *  Simngle dimensional
 *      just a series of values,
 *      var numbers = new int[5];
 *      var numbers = new int[5] { 1, 2, 3, 4, 5 };
 *  multidemension arrays use multiple dimensions of ordering values, vertical and horizontal
 *    they have 2 subtypes, rectangular and jagged
 *    rectangular array each row has the exact same number of columns, 
 *          like a 3x5 array could be seen as  3x5 rectangular graph
 *         [0 1 2 3 4]
 *         [0 1 2 3 4]
 *         [0 1 2 3 4]
 *        to declare a new rectangular array one would do:
 *          var matrix = new int[3, 5];
 *          var matrix = new int[3, 5]
 *          {
 *              {1,2,3,4,5},
 *              {16,17,18,19,20},
 *              {31.32,33,34,35}
 *          };
 *          var element = matrix[0,0];
 *        
 *     Jagged array each row can have varying columns, looking asymetrical
 *      a way of looking at a jagged array, is as an array of arrays
 *          [0, 1, 2]
 *          [0, 1, 2, 3, 4, 5,]
 *          [0, 1, 2, 3]
 *      
 * 
 * 
 * 