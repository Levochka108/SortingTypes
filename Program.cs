using static Sorting;
using static System.Console;

int[] array = { 7, 8, 5, 4, 3, 6, 2, 1, 0 };

WriteLine($"[{String.Join(',', array)}]");
SortSelection(array);
WriteLine($"[{String.Join(',', array)}]");
