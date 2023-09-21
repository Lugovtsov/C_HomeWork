/* Задача 62: Заполните спирально массив 4 на 4. или (n на n) */


Console.Clear();

System.Console.Write("Высота массива:");
int rows = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Ширина массива:");
int cols = Convert.ToInt32(Console.ReadLine());

Console.Clear();

int[,] array = Spiral(rows, cols);
int[,] Spiral(int rows, int cols)
{
    int[,] array = new int[rows, cols];            
    int end = rows * cols;                          
    int right = cols - 1;                          
    int bottom = rows - 1;                        
    int left = 0;                               
    int top = 1;                                    
    int direction = 1;                              
    int y = 0;                                     
    int x = 0;
    int pause = 500;                                

    for (int i = 1; i <= end; i++)
    {
        array[y, x] = i;                            
        PrintCurrent(array, y, x);                  
        Thread.Sleep(pause);                        

        if (direction == 1 && x < right) x++;       
        else if (direction == 1 && x == right)      
        {
            direction = 2;                          
            right--;                                
        }
        if (direction == 2 && y < bottom) y++;      
        else if (direction == 2 && y == bottom)     
        {
            direction = 3;                          
            bottom--;                              
        }
        if (direction == 3 && x > left) x--;        
        else if (direction == 3 && x == left)       
        {
            direction = 4;                          
            left++;                                 
        }
        if (direction == 4 && y > top) y--;         
        else if (direction == 4 && y == top)        
        {
            direction = 1;                         
            top++;                                  
            x++;                                   
        }
    }
    return array;
}
void PrintCurrent(int[,] array, int y, int x)                  
{
    Console.SetCursorPosition(0, 0);                            
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (j == x && i == y)                               
            {
                Console.ForegroundColor = ConsoleColor.Red;
                System.Console.Write(array[i, j] + "\t");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else if (array[i, j] != 0)                          
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                System.Console.Write(array[i, j] + "\t");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else                                                
            {
                Console.ForegroundColor = ConsoleColor.Black;
                System.Console.Write(array[i, j] + "\t");
                Console.ForegroundColor = ConsoleColor.White;
            }

        }
        System.Console.WriteLine();
    }
}