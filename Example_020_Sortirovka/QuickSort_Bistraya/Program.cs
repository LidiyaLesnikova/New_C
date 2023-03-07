using static Sorting;
using static Infrastructure;

int size = 100;
var arr = size.CreateArray()
            .Show()
            .SortQuick(0, size - 1)
            .Show()
            ;