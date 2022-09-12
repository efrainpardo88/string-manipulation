using System.Text;

namespace StringManipulation.App
{
    public class StringManipulation
    {
        public string sortingOperations(int n = 0, string[]? arr = null)
        {
            var result = new StringBuilder();

            // Validate parameters and if N is equal to the number of strings on the list
            if (n == 0 || arr == null || arr?.Length != n) return "-404";

            /***  WRITE YOUR LOGIC HERE  ***/
            for (int i = 0; i < n; i++)
            {
                var str = arr[i].ToCharArray();
                var strOrder = new Dictionary<char, int>();

                foreach (var item in str.Distinct())
                {
                    strOrder.Add(item, str.Where(i => i == item).Count());
                }

                result.AppendLine(strOrder
                    .OrderByDescending(item => item.Value)
                    .ThenBy(item => item.Key)
                    .Aggregate(new StringBuilder(), (current, next) =>
                    {
                        string letters = "";
                        for (int i = 0; i < next.Value; i++)
                        {
                            letters += next.Key;
                        }
                        return current.Append(letters);
                    }).ToString());
            }

            return result.ToString();
        }
    }
}