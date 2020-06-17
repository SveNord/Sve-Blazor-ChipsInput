using System.Collections.Generic;

namespace Sve.Blazor.ChipsInput.Components
{
    public class ChipValidationArgs
    {
        /// <summary>
        /// The current chip value that could potentially be added
        /// </summary>
        public string CurrentChip { get; set; }

        /// <summary>
        /// A list of all chips
        /// </summary>
        public List<string> Chips { get; set; }

        /// <summary>
        /// The list of validation errors
        /// </summary>
        public List<string> ValidationErrors { get; set; }

        public ChipValidationArgs(List<string> chips, string currentChip, List<string> validationErrors)
        {
            Chips = chips;
            CurrentChip = currentChip;
            ValidationErrors = validationErrors;
        }
    }
}
