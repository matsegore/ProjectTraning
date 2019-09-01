using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTraning
{
    class Strings
    {

        public void Execute()
        {
            string text1 = "ooooppppprdaergser";

            string text2 = "iiiiiissssssaekmglekmg";

            string unitedText = UniteText(text1, text2);

            string sortedText = SortString(unitedText);

            string deletedDup = DeleteDuplicates(sortedText);

            DisplayText(deletedDup, unitedText);

        }

        private string UniteText(string text1, string text2)
        {

            string unitedText = String.Concat(text1, text2);

            return unitedText;

        }

        private string SortString(string unitedText)
        {
            string sortedText = String.Concat(unitedText.OrderBy(a => a));

            return sortedText;
        }

        private string DeleteDuplicates(string sortedText)
        {
            string deletedDup = String.Concat(sortedText.OrderBy(a => a).Distinct());

            return deletedDup;
        }

        private void DisplayText(string deletedDup, string unitedText)
        {
            Console.WriteLine($"Text: {unitedText}");

            Console.WriteLine($"Sorted text: {deletedDup}");
        }
    }
}
