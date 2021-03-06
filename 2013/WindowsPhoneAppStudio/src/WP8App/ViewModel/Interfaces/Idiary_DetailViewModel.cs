// ------------------------------------------------------------------------
// ========================================================================
// THIS CODE AND INFORMATION ARE GENERATED BY AUTOMATIC CODE GENERATOR
// ========================================================================
// Template:   IViewModel.tt
using System.Collections.ObjectModel;
using System.Windows.Input;
using WPAppStudio.Controls;
using WPAppStudio.Entities;
using WPAppStudio.Entities.Base;

namespace WPAppStudio.ViewModel.Interfaces
{
    /// <summary>
    /// diary_Detail ViewModel interface.
    /// </summary>
    [System.Runtime.CompilerServices.CompilerGenerated]
    [System.CodeDom.Compiler.GeneratedCode("Radarc", "4.0")]
    public interface Idiary_DetailViewModel
    {		
        /// <summary>
        /// Gets/Sets the CurrentdiarySchema property.
        /// </summary>
		diarySchema CurrentdiarySchema { get; set; }

        
        /// <summary>
        /// Gets the TextToSpeechdiary_DetailStaticControlCommand command.
        /// </summary>
		ICommand TextToSpeechdiary_DetailStaticControlCommand { get; }

        
        /// <summary>
        /// Gets the TextToSpeechdescStaticControlCommand command.
        /// </summary>
		ICommand TextToSpeechdescStaticControlCommand { get; }

        
        /// <summary>
        /// Gets the Sharediary_DetailStaticControlCommand command.
        /// </summary>
		ICommand Sharediary_DetailStaticControlCommand { get; }

        
        /// <summary>
        /// Gets the SharedescStaticControlCommand command.
        /// </summary>
		ICommand SharedescStaticControlCommand { get; }

        
        /// <summary>
        /// Gets the PinToStartdiary_DetailStaticControlCommand command.
        /// </summary>
		ICommand PinToStartdiary_DetailStaticControlCommand { get; }

        
        /// <summary>
        /// Gets the PinToStartdescStaticControlCommand command.
        /// </summary>
		ICommand PinToStartdescStaticControlCommand { get; }

	}
}
