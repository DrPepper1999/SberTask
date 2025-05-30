namespace SberTask;

/// <summary>
/// Задача 2: В поле N x M передвигаться можно только вправо и вниз. Найти количество всех возможный путей.
/// </summary>
public static class PathHelper
{
    public static int GetPathCount(int m, int n)
    {
        if (m == 0 || n == 0)
        {
            return 0;
        }
        
        var arr = new int[m, n];
        for (var i = 0; i < m; i++)
        {
            for (var j = 0; j < n; j++)
            {
                if (i == 0 || j == 0)
                {
                    arr[i, j] = 1;
                    continue;
                }

                arr[i, j] = arr[i-1, j] + arr[i, j-1];
            }
        }

        return arr[m-1, n-1];
    }
}