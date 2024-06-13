namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool GetVisited(int a)
            {
                if (visited[a] == false)
                {
                    visited[a] = true;
                    return visited[a];
                }
                else
                {
                    return !visited[a];
                }
            }
        }
    }
}